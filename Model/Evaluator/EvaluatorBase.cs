using System;
using System.Collections.Generic;
using System.Reflection;


namespace HideousWorks.Fracter.Model.Evaluator
{
    public abstract class EvaluatorBase : IFractalEvaluator
    {
        //----------------------------------------------------------------------
        public abstract int Evaluate( Complex subject, int iterations, double tolerance );
    }
}