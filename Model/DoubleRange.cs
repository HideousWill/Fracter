using System;


namespace HideousWorks.Fracter.Model
{
    public class DoubleRange
    {
        //----------------------------------------------------------------------
        public double Min { get; private set; }

        //----------------------------------------------------------------------
        public double Max { get { return Min + Extent; } }

        //----------------------------------------------------------------------
        public double Extent { get; private set; }

        //----------------------------------------------------------------------
        public DoubleRange( double min, double extent )
        {
            Min = min;
            Extent = extent;
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return String.Format( "Min={0}, Extent={1}", Min, Extent );
        }

        //----------------------------------------------------------------------
        public DoubleRange ComputeScaled( double offset, double scale )
        {
            return new DoubleRange( (Min + (offset * Extent)), Extent * scale );
        }
    }
}
