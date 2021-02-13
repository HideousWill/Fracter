using System;
using System.Diagnostics;
using System.Drawing;

using HideousWorks.Fracter.Common;


namespace HideousWorks.Fracter.Model
{
    public class SetGenerator : ISetData, ITextSource
    {

        #region ITextSource Members

        //----------------------------------------------------------------------
        public event EventHandler<TextDataEventArgs> TextReady;

        //----------------------------------------------------------------------
        void InvokeTextReady( string text )
        {
            InvokeTextReady( new TextDataEventArgs( text ) );
        }

        //----------------------------------------------------------------------
        void InvokeTextReady( TextDataEventArgs e )
        {
            var handler = TextReady;
            if( handler != null ) handler( this, e );
        }

        //----------------------------------------------------------------------
        public string Name
        {
            get { return ToString(); }
        }

        #endregion

        #region ISetData Members

        //----------------------------------------------------------------------
        public event EventHandler< EventArgs > SetStarted;
        void RaiseSetStarted( EventArgs e )
        {
            var handler = SetStarted;
            if( handler != null ) handler( this, e );
        }

        //----------------------------------------------------------------------
        public event EventHandler EntireSetChanged;
        void RaiseEntireSetChanged( EventArgs e )
        {
            var changed = EntireSetChanged;
            if( changed != null )
            {
                changed( this, e );
            }
        }

        //----------------------------------------------------------------------
        public event EventHandler<RowChangedEventArgs> RowChanged;
        void RaiseRowChanged( RowChangedEventArgs e )
        {
            var changed = RowChanged;
            if( changed != null )
            {
                changed( this, e );
            }
        }

        //----------------------------------------------------------------------
        public int SampleWidth { get; private set; }

        //----------------------------------------------------------------------
        public int SampleHeight { get; private set; }

        //----------------------------------------------------------------------
        public int[ , ] Data { get; private set; }


        #endregion

        //----------------------------------------------------------------------
        public static GeneratorInfo DefaultInfo
        {
            get
            {
                return new GeneratorInfo
                {
                    Iterations = 200,
                    ConvergenceLimit = 2.0,
                    Range = new ComplexRange( new DoubleRange( -2.0, 3.0 ),
                                              new DoubleRange( -1.5, 3.0 ) ),
                    Resolution = new Size( 256, 256 )
                };
            }
        }

        //----------------------------------------------------------------------
        public GeneratorInfo Info { get; set; }

        //----------------------------------------------------------------------
        public void Generate()
        {
            if( null == Info ) return;

            CreateDataStore();

            RaiseSetStarted( EventArgs.Empty );

            StartRecording();

            var thisImaginary = Info.ImaginaryMin;

            for( var row = 0; row < SampleHeight; row++ )
            {
                GenerateRow( row, thisImaginary );

                RaiseRowChanged( new RowChangedEventArgs( row ) );

                thisImaginary += Info.ImaginaryDelta;
            }

            RaiseEntireSetChanged( EventArgs.Empty );

            StopRecording();
        }

        //----------------------------------------------------------------------
        void GenerateRow( int row, double thisImaginary ) 
        {
            var thisReal = Info.RealMin;

            for( var col = 0; col < SampleWidth; col++ )
            {
                var iterations   = Info.Evaluator.Evaluate( new Complex( thisReal, thisImaginary ), Info.Iterations, Info.ConvergenceLimit );
                Data[ col, row ] = iterations;

                RecordEvaluation( iterations );

                thisReal += Info.RealDelta;
            }
        }

        //----------------------------------------------------------------------
        void CreateDataStore()
        {
            SampleWidth  = Info.Resolution.Width;
            SampleHeight = Info.Resolution.Height;

            Data = new int[ SampleWidth, SampleHeight ];
        }

        #region Instrumentation

        //----------------------------------------------------------------------
        int TotalIterations { get; set; }
        //----------------------------------------------------------------------
        int ElementsInSet { get; set; }

        //----------------------------------------------------------------------
        readonly Stopwatch m_Timer = new Stopwatch();
        Stopwatch Timer { get { return m_Timer; } }

        //----------------------------------------------------------------------
        void StartRecording()
        {
            TotalIterations = 0;
            ElementsInSet = 0;
            Timer.Start();
        }

        //----------------------------------------------------------------------
        void RecordEvaluation( int iterations )
        {
            if( 0 == iterations ) { ++ElementsInSet; }
            else { TotalIterations += iterations; }
        }

        //----------------------------------------------------------------------
        void StopRecording()
        {
            Timer.Stop();

            InvokeTextReady( String.Format(
                "Generation time: {0} ms;\n  iterations = {1}; inSet = {2};\n  rate = {3}",
                Timer.Elapsed.TotalMilliseconds,
                TotalIterations,
                ElementsInSet,
                (Timer.Elapsed.TotalMilliseconds / TotalIterations) * 1000 ) );

        }

        #endregion
    }
}
