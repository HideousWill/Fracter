using System;


namespace HideousWorks.Fracter.Model
{
    public class DoubleValueEventArgs : EventArgs
    {
        //----------------------------------------------------------------------
        public double Value { get; private set; }

        //----------------------------------------------------------------------
        public DoubleValueEventArgs( double d )
        {
            Value = d;
        }

        //----------------------------------------------------------------------
        public DoubleValueEventArgs( Decimal d )
            : this( Convert.ToDouble( d ) )
        { }
    }
}
