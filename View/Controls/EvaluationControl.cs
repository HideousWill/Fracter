using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HideousWorks.Fracter.Common;
using HideousWorks.Fracter.Model.Evaluator;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class EvaluationControl : UserControl
    {
        //----------------------------------------------------------------------
        public int Iterations
        {
            get { return Convert.ToInt32( IterationUpDown.Value ); }
            set { IterationUpDown.Value = value; }
        }

        //----------------------------------------------------------------------
        public double Convergence
        {
            get { return Convert.ToDouble( ConvergenceUpDown.Value ); }
            set { ConvergenceUpDown.Value = Convert.ToDecimal( value ); }
        }

        //----------------------------------------------------------------------
        public IFractalEvaluator Evaluator
        {
            get { return GeneratorComboBox.SelectedItem as IFractalEvaluator; }
        }

        //----------------------------------------------------------------------
        public EvaluationControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------
        private void EvaluationControl_Load( object sender, EventArgs e )
        {
            GeneratorComboBox.Items.AddRange( GetEvaluators().ToArray() );

            if( 0 < GeneratorComboBox.Items.Count )
            {
                GeneratorComboBox.SelectedIndex = 0;
            }
        }

        //----------------------------------------------------------------------
        static List<IFractalEvaluator> GetEvaluators()
        {
            var evaluators = Helpers.GetInstancesOfTypesImplementing< IFractalEvaluator >();

            return null == evaluators ? new List<IFractalEvaluator>() : new List<IFractalEvaluator>( evaluators );
        }
    }
}
