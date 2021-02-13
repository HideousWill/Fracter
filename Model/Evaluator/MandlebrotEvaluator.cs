namespace HideousWorks.Fracter.Model.Evaluator
{
    public class MandlebrotEvaluator : EvaluatorBase
    {
        //----------------------------------------------------------------------
        public override int Evaluate( Complex subject, int iterations, double tolerance )
        {
            var current = new Complex();

            for( var i = 0; i < iterations; i++ )
            {
                current = current * current + subject;

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
            return "Mandlebrot Set";
        }
    }
}
