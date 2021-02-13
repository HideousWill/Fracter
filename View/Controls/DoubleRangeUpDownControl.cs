using System;
using System.Windows.Forms;

using HideousWorks.Fracter.Model;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class DoubleRangeUpDownControl : UserControl
    {
        //----------------------------------------------------------------------
        public event EventHandler<DoubleValueEventArgs> MinValueChanged;
        void RaiseMinValueChanged( decimal d )
        {
            var changed = MinValueChanged;
            if( changed != null )
            {
                changed( this, new DoubleValueEventArgs( d ) );
            }
        }

        //----------------------------------------------------------------------
        public event EventHandler<DoubleValueEventArgs> MaxValueChanged;
        void RaiseMaxValueChanged( decimal d )
        {
            var changed = MaxValueChanged;
            if( changed != null )
            {
                changed( this, new DoubleValueEventArgs( d ) );
            }
        }

        //----------------------------------------------------------------------
        public string Title
        {
            get { return GroupBox.Text; } 
            set { GroupBox.Text = value; }
        }

        //----------------------------------------------------------------------
        public double Min
        {
            get { return Convert.ToDouble( MinUpDown.Value ); }
            set
            {
                MinUpDown.Value = Convert.ToDecimal( value );
                SetMaxDisplay();
            }
        }

        //----------------------------------------------------------------------
        public double Extent
        {
            get { return Convert.ToDouble( ExtentUpDown.Value ); }
            set
            {
                ExtentUpDown.Value = Convert.ToDecimal( value );
                SetMaxDisplay();
            }
        }

        //----------------------------------------------------------------------
        public double Max
        {
            get { return Min + Extent; }
        }

        //----------------------------------------------------------------------
        public DoubleRange Range
        {
            get { return new DoubleRange( Min, Extent ); }
        }

        //----------------------------------------------------------------------
        public DoubleRangeUpDownControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------
        public DoubleRangeUpDownControl( double min, double extent ) : this()
        {
            SetValues( min, extent );
        }

        //----------------------------------------------------------------------
        public DoubleRangeUpDownControl( string title, double min, double extent ) : this( min, extent )
        {
            Title = title;
        }

        //----------------------------------------------------------------------
        public void SetValues( double min, double extent )
        {
            Min = min;
            Extent = extent;
        }

        //----------------------------------------------------------------------
        public void SetValues( DoubleRange range )
        {
            SetValues( range.Min, range.Extent );
        }

        //----------------------------------------------------------------------
        void SetMaxDisplay()
        {
            MaxTextBox.Text = String.Format( "{0:F5}", Max );
        }

        //----------------------------------------------------------------------
        private void MinUpDown_ValueChanged( object sender, EventArgs e )
        {
            SetMaxDisplay();
            RaiseMinValueChanged( MinUpDown.Value );
        }

        //----------------------------------------------------------------------
        private void ExtentUpDown_ValueChanged( object sender, EventArgs e )
        {
            SetMaxDisplay();
            RaiseMaxValueChanged( ExtentUpDown.Value );
        }
    }
}
