using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

using HideousWorks.Fracter.ColorTable;
using HideousWorks.Fracter.Model;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class NavigableImageControl : UserControl, IVisualizer
    {
        //----------------------------------------------------------------------
        public event EventHandler<RectangleEventArgs> RectangleSelected;
        public void InvokeRectangleSelected( RectangleEventArgs e )
        {
            var handler = RectangleSelected;
	        handler?.Invoke( this, e );
        }

	    //----------------------------------------------------------------------
		public bool IsAnimated
		{
			get => Palette.EnableAnimation;
			set => Palette.EnableAnimation = value;
		}

	    //----------------------------------------------------------------------
	    public float AnimFPS
	    {
		    get => (float) 1000 / Palette.AnimationIntervalMs;
		    set => Palette.AnimationIntervalMs = (int) (1000 / value);
	    }

        //----------------------------------------------------------------------
        ColorTableBase m_Palette;
	    public ColorTableBase Palette
	    {
		    get => m_Palette;
		    set
		    {
			    if( value == m_Palette ) return;

			    if( null != m_Palette )
			    {
				    m_Palette.PaletteChanged -= HandlePaletteChanged;
			    }

			    m_Palette = value;
			    if( null != m_Palette )
			    {
				    m_Palette.PaletteChanged += HandlePaletteChanged;

				    LoadDataToImage();
			    }
		    }
	    }

	    //----------------------------------------------------------------------
	    void HandlePaletteChanged( object sender, EventArgs e )
	    {
		    LoadDataToImage();
	    }

	    //----------------------------------------------------------------------
        Size m_PreferredImageSize;
        Size PreferredImageSize
        {
            get => m_PreferredImageSize;
	        set
            {
                // TODO: Rework this whole thing, as it is an entangled mess.
                // Actually, since I will move to creating the generated image
                // based on the actual size of the data, this whole bit should
                // go away soon.
                if( null != GeneratedImage ) 
                {
                    GeneratedImage.Dispose();
                    GeneratedImage = null;
                }

                m_PreferredImageSize = value;

                if( m_PreferredImageSize.Width.Equals( 0 ) ||
                    m_PreferredImageSize.Height.Equals( 0 ) ) return;

                if( null == GeneratedImage ||
                    !m_PreferredImageSize.Equals( GeneratedImage.Size ) )
                {
                    GeneratedImage = new Bitmap( m_PreferredImageSize.Width, m_PreferredImageSize.Height,
                                                 PixelFormat.Format32bppRgb );
                    PositionImage();
                    LoadDataToImage();
                }
            }
        }

        //----------------------------------------------------------------------
        public bool IsIncrementalUpdateEnabled { get; set; }

        //----------------------------------------------------------------------
        public bool IsPerRowUpdateEnabled { get; set; }

        //----------------------------------------------------------------------
        ISetData m_Data;
        public ISetData Data
        {
            get => m_Data;
	        set
            {
                if( null != m_Data )
                {
                    m_Data.SetStarted -= HandleSetStarted;
                    m_Data.RowChanged -= HandleRowDataChanged;
                    m_Data.EntireSetChanged -= HandleEntireDataChanged;
                }
                m_Data = value;
                if( null != m_Data )
                {
                    m_Data.SetStarted += HandleSetStarted;
                    m_Data.RowChanged += HandleRowDataChanged;
                    m_Data.EntireSetChanged += HandleEntireDataChanged;
                }
            }
        }

        //----------------------------------------------------------------------
        Bitmap GeneratedImage { get; set; }

        public NavigableImageControl()
        {
            InitializeComponent();

            SetStyle(
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.DoubleBuffer, true );

            Tracker = new MouseTracker();
        }

        //----------------------------------------------------------------------
        public void Reload()
        {
            LoadDataToImage();
        }

        //----------------------------------------------------------------------
        PointF ImagePosition { get; set; }

        //----------------------------------------------------------------------
        void PositionImage()
        {
            if( null == GeneratedImage ) return;
            
            var posX = (ClientRectangle.Width  - GeneratedImage.Width)  / 2;
            var posY = (ClientRectangle.Height - GeneratedImage.Height) / 2;

            ImagePosition = new PointF( posX, posY );
        }

        //----------------------------------------------------------------------
        void LoadDataToImage()
        {
            if( null == Data ) return;
            if( null == Palette ) return;

            var numberOfRows = Math.Min( PreferredImageSize.Height, Data.SampleHeight );

            for( var row = 0; row < numberOfRows; row++ )
            {
                LoadRowToImage( row );
            }

            if( IsPerRowUpdateEnabled ) return;

            Invalidate();
        }

        //----------------------------------------------------------------------
        void LoadRowToImage( int row )
        {
            var numberOfColumns = Math.Min( PreferredImageSize.Width, Data.SampleWidth );
            
            for( var col = 0; col < numberOfColumns; col++ )
            {
                GeneratedImage.SetPixel( col, row, Palette[ Data.Data[ col, row ] ] );
            }

            if( ! IsPerRowUpdateEnabled ) return;

            Invalidate();
            Update();
        }

        //----------------------------------------------------------------------
        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );

            if( null == GeneratedImage ) return;

            e.Graphics.DrawImage( GeneratedImage, ImagePosition );

            Tracker.DrawDragBox( e.Graphics );
        }

        //----------------------------------------------------------------------
        protected override void OnResize( EventArgs e )
        {
            base.OnResize( e );

            PositionImage();

            Invalidate();
        }

        //----------------------------------------------------------------------
        void HandleSetStarted( object sender, EventArgs e )
        {
            PreferredImageSize = new Size( Data.SampleWidth, Data.SampleHeight );
        }

        //----------------------------------------------------------------------
        void HandleEntireDataChanged( object sender, EventArgs e )
        {
            LoadDataToImage();
        }

        //----------------------------------------------------------------------
        void HandleRowDataChanged( object sender, RowChangedEventArgs e )
        {
            if( IsIncrementalUpdateEnabled )
            {
                LoadRowToImage( e.RowIndex );
            }
        }

        #region Mousing

        MouseTracker Tracker { get; set; }

        //----------------------------------------------------------------------
        protected override void OnMouseDown( MouseEventArgs e )
        {
            base.OnMouseDown( e );

            if( null == GeneratedImage ) return;

            Tracker = new MouseTracker( e, ImagePosition, GeneratedImage.Size );

            Invalidate();
        }

        //----------------------------------------------------------------------
        protected override void OnMouseUp( MouseEventArgs e )
        {
            base.OnMouseUp( e );

            if( Tracker.IsFrozen ) return;

            InvokeRectangleSelected( new RectangleEventArgs( Tracker.NewRectangle ) );

            Tracker.IsFrozen = true;

            Invalidate();
        }

        //----------------------------------------------------------------------
        protected override void OnMouseMove( MouseEventArgs e )
        {
            base.OnMouseMove( e );

            Tracker.ApplyMove( e );

            Invalidate();
        }

        #endregion
    }
}
