using System;


namespace HideousWorks.Fracter.Model
{
    public class Complex
    {
        //----------------------------------------------------------------------
        public double Real { get; private set; }

        //----------------------------------------------------------------------
        public double Imaginary { get; private set; }

        //----------------------------------------------------------------------
        public double Abs { get { return Math.Sqrt( Real * Real + Imaginary * Imaginary ); } }

        //----------------------------------------------------------------------
        public Complex Pow( int exp )
        {
            var result = this;
            for( var i = 1; i < exp; i++ )
            {
                result = result * this;
            }
            return result;
        }

        //----------------------------------------------------------------------
        public Complex( double real, double imaginary )
        {
            Real = real;
            Imaginary = imaginary;
        }

        //----------------------------------------------------------------------
        public Complex() : this( 0, 0 )
        { }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return String.Format( "{0}, {1}", Real, Imaginary );
        }

        //----------------------------------------------------------------------
        public static Complex operator -( Complex other )
        {
            return new Complex( -other.Real, -other.Imaginary );
        }

        //----------------------------------------------------------------------
        public static Complex operator +( Complex lhs, Complex rhs )
        {
            return new Complex( lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary );
        }

        //----------------------------------------------------------------------
        public static Complex operator -( Complex lhs, Complex rhs )
        {
            return new Complex( lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary );
        }

        //----------------------------------------------------------------------
        public static Complex operator *( Complex lhs, Complex rhs )
        {
            return new Complex( (lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary),
                                (lhs.Real * rhs.Imaginary + rhs.Real * lhs.Imaginary) );
        }

        //----------------------------------------------------------------------
        public static Complex operator /( Complex lhs, Complex rhs )
        {
            var d = rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary;

            if( d == 0 )
            {
                return new Complex( 0, 0 );
            }

            var c1 = lhs.Real * rhs.Real + lhs.Imaginary * rhs.Imaginary;
            var c2 = lhs.Imaginary * rhs.Real - lhs.Real * rhs.Imaginary;

            return new Complex( c1 / d, c2 / d );
        }
    }
}
