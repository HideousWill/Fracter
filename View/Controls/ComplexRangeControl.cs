using System.Windows.Forms;

using HideousWorks.Fracter.Model;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class ComplexRangeControl : UserControl
    {
        //----------------------------------------------------------------------
        public ComplexRange ComplexRange
        {
            get { return new ComplexRange( RealRange, ImaginaryRange ); }
            set { RealRange = value.Real; ImaginaryRange = value.Imaginary; }
        }

        //----------------------------------------------------------------------
        public DoubleRange RealRange
        {
            get { return RealUpDownControl.Range; }
            set { RealUpDownControl.SetValues( value ); }
        }

        //----------------------------------------------------------------------
        public DoubleRange ImaginaryRange
        {
            get { return ImaginaryUpDownControl.Range; }
            set { ImaginaryUpDownControl.SetValues( value ); }
        }

        //----------------------------------------------------------------------
        public bool LockAspectRatio
        {
            get { return LockAspectRatioCheckBox.Checked; }
            set { LockAspectRatioCheckBox.Checked = value; }
        }

        //----------------------------------------------------------------------
        public ComplexRangeControl()
        {
            InitializeComponent();
        }
    }
}
