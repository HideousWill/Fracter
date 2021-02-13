using System;
using System.Drawing;
using System.Windows.Forms;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class SampleRateControl : UserControl
    {
        //----------------------------------------------------------------------
        public Size Resolution
        {
            get { return new Size( Convert.ToInt32( RealUpDown.Value ), Convert.ToInt32( ImaginaryUpDown.Value ) ); }
            set
            {
                RealUpDown.Value = value.Width;
                ImaginaryUpDown.Value = value.Height;
            }
        }

        //----------------------------------------------------------------------
        public SampleRateControl()
        {
            InitializeComponent();
        }
    }
}
