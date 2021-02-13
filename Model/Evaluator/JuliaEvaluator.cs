namespace HideousWorks.Fracter.Model.Evaluator
{
    public class JuliaEvaluator : EvaluatorBase
    {
        //----------------------------------------------------------------------
        public override int Evaluate( Complex subject, int iterations, double tolerance )
        {
            var current = subject;
            var c = new Complex( -.9, .9 );

            for( var i = 0; i < iterations; i++ )
            {
                current = (current.Pow( 2 ) + c) / (current - c);

                if( current.Abs > tolerance )
                {
                    return i;
                }
            }

            return 0;
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return "Julia Set";
        }
    }
}