using System;
using System.Drawing;
using System.Windows.Forms;


namespace HideousWorks.Fracter.View.Controls
{
    class MouseTracker
    {
        //----------------------------------------------------------------------
        public PointF ImagePosition { get; private set; }

        //----------------------------------------------------------------------
        public SizeF ImageSize { get; private set; }

        //----------------------------------------------------------------------
        public RectangleF NewRectangle
        {
            get
            {
                return IsMoveFiltered ? PanRectangle : ZoomRectangle;
            }
        }

        //----------------------------------------------------------------------
        public bool IsFrozen { get; set; }

        //----------------------------------------------------------------------
        public MouseTracker()
        {
            IsFrozen = true;
        }

        //----------------------------------------------------------------------
        public MouseTracker( MouseEventArgs e, PointF imagePosition, SizeF imageSize )
        {
            IsConstrained = e.Button.Equals( MouseButtons.Left );

            MouseDownPoint = new PointF( e.X, e.Y );
            MouseDragPoint = MouseDownPoint;

            ImagePosition = imagePosition;
            ImageSize     = imageSize;
            IsFrozen      = false;

            XMoveAspectScale = Convert.ToSingle( ImageSize.Height ) / ImageSize.Width;
            YMoveAspectScale = Convert.ToSingle( ImageSize.Width  ) / ImageSize.Height;
        }

        //----------------------------------------------------------------------
        public void ApplyMove( MouseEventArgs e )
        {
            if( IsFrozen ) return;

            MouseDragPoint = new PointF( e.X, e.Y );
        }

        //----------------------------------------------------------------------
        public void DrawDragBox( Graphics graphics )
        {
            if( IsFrozen ) return;

//            graphics.DrawRectangle( Pens.Red, Rectangle.Round( NewRectangle ) );
            graphics.DrawRectangle( Pens.Red, Rectangle.Round( DragRectangle ) );
        }

        //----------------------------------------------------------------------
        RectangleF ZoomRectangle
        {
            get
            {
                var r = DragRectangle;
                r.Offset( -ImagePosition.X, -ImagePosition.Y );
                return r;
            }
        }

        //----------------------------------------------------------------------
        RectangleF PanRectangle
        {
            get
            {
                var offset = new PointF( (MouseDownPoint.X - ImagePosition.X) - (ImageSize.Width / 2.0f),
                                         (MouseDownPoint.Y - ImagePosition.Y) - (ImageSize.Height / 2.0f) );

                return new RectangleF( offset, ImageSize );
            }
        }


        //----------------------------------------------------------------------
	    SizeF MoveFilter { get; } = new SizeF( 2, 2 );

	    //----------------------------------------------------------------------
        public bool IsMoveFiltered => DragRectangle.Size.Width  < MoveFilter.Width ||
                                      DragRectangle.Size.Height < MoveFilter.Height;

	    //----------------------------------------------------------------------
        PointF MouseDownPoint { get; set; }
        //----------------------------------------------------------------------
        PointF MouseDragPoint { get; set; }

        //----------------------------------------------------------------------
        bool IsConstrained { get; set; }
        //----------------------------------------------------------------------
        float XMoveAspectScale { get; set; }
        //----------------------------------------------------------------------
        float YMoveAspectScale { get; set; }

        //----------------------------------------------------------------------
        RectangleF DragRectangle
        {
            get
            {
                var deltaX = Math.Abs( MouseDragPoint.X - MouseDownPoint.X );
                var deltaY = Math.Abs( MouseDragPoint.Y - MouseDownPoint.Y );

                if( IsConstrained )
                {
                    if( deltaX > deltaY )
                    {
                        deltaY = XMoveAspectScale * deltaX;
                    }
                    else
                    {
                        deltaX = YMoveAspectScale * deltaY;
                    }
                }

                return new RectangleF(
                    Math.Min( MouseDownPoint.X, MouseDragPoint.X ),
                    Math.Min( MouseDownPoint.Y, MouseDragPoint.Y ),
                    deltaX,
                    deltaY );
            }
        }
    }
}