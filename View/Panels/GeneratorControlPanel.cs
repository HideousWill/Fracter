using System;
using System.Windows.Forms;

using HideousWorks.Fracter.Model;
using HideousWorks.Fracter.View.Controls;
using HideousWorks.Fracter.View.Forms;


namespace HideousWorks.Fracter.View.Panels
{
    public partial class GeneratorControlPanel : UserControl
    {
        //----------------------------------------------------------------------
        public SetGenerator Generator { get; set; }

        //----------------------------------------------------------------------
        IImageNavigator m_Navigator;
        public IImageNavigator Navigator
        {
            get { return m_Navigator; }
            set
            {
                if( null != m_Navigator )
                {
                    m_Navigator.RectangleSelected -= HandleRectangleChanged;
                }

                m_Navigator = value;

                if( null != m_Navigator )
                {
                    m_Navigator.RectangleSelected += HandleRectangleChanged;
                }
            }
        }

        //----------------------------------------------------------------------
        void HandleRectangleChanged( object sender, RectangleEventArgs e )
        {
            if( null == Generator ) return;

            Generator.Info.ScaleRange( e.Rectangle );

            ComplexRangeUserControl.ComplexRange = Generator.Info.Range;

            Generator.Generate();
        }

        //----------------------------------------------------------------------
        public GeneratorControlPanel()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------
        protected override void Dispose( bool disposing )
        {
            if( IsDisposed ) return;

            if( disposing )
            {
                if( null != components )
                {
                    components.Dispose();
                }

                Navigator = null;
            }
            base.Dispose( disposing );
        }

        //----------------------------------------------------------------------
        private void GenerateButton_Click( object sender, EventArgs e )
        {
            if( null == Generator ) return;
            
            Generator.Info = GetGeneratorInfo();

//            ShowProperties( Generator.Info );

            Generator.Generate();
        }

#if  KILL_EXPERIMENT
        TestForm TestForm { get; set; }

        void ShowProperties( object source )
        {
            if( null == TestForm )
            {
                TestForm = new TestForm();
                TestForm.Closed += HandleTestFormClosed;
            }

            TestForm.Displayed = source;

            if( ! TestForm.Visible )
            {
                TestForm.Show();
            }
        }

        void HandleTestFormClosed( object sender, EventArgs e )
        {
            TestForm.Closed -= HandleTestFormClosed;
            TestForm = null;
        }
#endif

        //----------------------------------------------------------------------
        GeneratorInfo GetGeneratorInfo()
        {
            var info = new GeneratorInfo();

            info.Range = new ComplexRange( 
                ComplexRangeUserControl.RealRange, 
                ComplexRangeUserControl.ImaginaryRange );

            info.Iterations = EvaluationUserControl.Iterations;
            info.ConvergenceLimit = EvaluationUserControl.Convergence;
            info.Evaluator = EvaluationUserControl.Evaluator;

            info.Resolution = SampleRateUserControl.Resolution;

            return info;
        }

        //----------------------------------------------------------------------
        private void DefaultsButton_Click( object sender, System.EventArgs e )
        {
            ComplexRangeUserControl.ComplexRange = SetGenerator.DefaultInfo.Range;
            SampleRateUserControl.Resolution     = SetGenerator.DefaultInfo.Resolution;
            EvaluationUserControl.Iterations     = SetGenerator.DefaultInfo.Iterations;
            EvaluationUserControl.Convergence    = SetGenerator.DefaultInfo.ConvergenceLimit;

            Generator.Info = SetGenerator.DefaultInfo;
            Generator.Info.Evaluator = EvaluationUserControl.Evaluator;

            Generator.Generate();
        }
    }
}
