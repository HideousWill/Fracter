namespace HideousWorks.Fracter.Model.Evaluator
{
    public interface IFractalEvaluator
    {
        int Evaluate( Complex subject, int iterations, double tolerance );
    }
}