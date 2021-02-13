namespace HideousWorks.Fracter.Model.Evaluator
{
    public class SpottyEvaluator : EvaluatorBase
    {
        //----------------------------------------------------------------------
        public override int Evaluate( Complex subject, int iterations, double tolerance )
        {
            var c = new Complex( 0.1, 0.2 );

            var curr = new Complex( 1, 2 );

            for( var i = 0; i < iterations; i++ )
            {
                curr = (subject * curr) + c / curr.Pow( 2 );

                if( curr.Abs > tolerance )
                {
                    return i;
                }
            }

            return 0;
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return "Spotty Set";
        }
    }
}