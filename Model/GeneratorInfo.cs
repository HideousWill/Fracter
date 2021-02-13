using System;
using System.Drawing;

using HideousWorks.Fracter.Model.Evaluator;


namespace HideousWorks.Fracter.Model
{
    public sealed class GeneratorInfo
    {
        public double RealMin        { get { return Range.Real.Min; } }
        public double RealDelta      { get { return Range.Real.Extent / Resolution.Width; } }
        public double ImaginaryMin   { get { return Range.Imaginary.Min; } }
        public double ImaginaryDelta { get { return Range.Imaginary.Extent / Resolution.Height; } }

        public void ScaleRange( Rectangle targetRectangle )
        {
            var offset = Convert.ToDouble( targetRectangle.X     ) / Resolution.Width;
            var scale  = Convert.ToDouble( targetRectangle.Width ) / Resolution.Width;
            var realRange = Range.Real.ComputeScaled( offset, scale );

            offset = Convert.ToDouble( targetRectangle.Y      ) / Resolution.Height;
            scale  = Convert.ToDouble( targetRectangle.Height ) / Resolution.Height;
            var imaginaryRange = Range.Imaginary.ComputeScaled( offset, scale );

            Range = new ComplexRange( realRange, imaginaryRange );
        }


        #region Raw elements

        public ComplexRange Range { get; set; }
        public Size Resolution { get; set; }

        public double ConvergenceLimit { get; set; }
        public int Iterations { get; set; }

        public IFractalEvaluator Evaluator { get; set; }

        #endregion

    }

    public class ComplexRange
    {
        public ComplexRange( DoubleRange real, DoubleRange imaginary )
        {
            Real = real;
            Imaginary = imaginary;
        }

        public DoubleRange Real { get; private set; }

        public DoubleRange Imaginary { get; private set; }
    }


    interface IFractalData
    {
        event EventHandler EntireSetChanged;
        event EventHandler< RowChangedEventArgs > RowChanged;

        int[ , ] Data { get; }

        Size Resolution { get; }

        Complex GetSamplePoint( int x, int y );
    }
}
