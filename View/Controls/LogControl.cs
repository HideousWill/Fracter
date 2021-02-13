using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HideousWorks.Fracter.Common;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class LogControl : UserControl
    {
        //----------------------------------------------------------------------
        readonly List< ITextSource > m_Sources = new List< ITextSource >();
        List<ITextSource> Sources { get { return m_Sources; } }

        //----------------------------------------------------------------------
        public LogControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------
        public void AddSource( ITextSource source )
        {
            if( Sources.Contains( source ) ) return;

            source.TextReady += HandleTextReady;
            Sources.Add( source );
        }

        //----------------------------------------------------------------------
        public void RemoveSource( ITextSource source )
        {
            if( ! Sources.Contains( source ) ) return;

            source.TextReady -= HandleTextReady;
            Sources.Remove( source );
        }

        //----------------------------------------------------------------------
        public void Clear()
        {
            LogTextBox.Clear();
        }

        //----------------------------------------------------------------------
        public void AppendAndScrollText( string text )
        {
            if( InvokeRequired )
            {
                Invoke( new Action<string>( AppendAndScrollText ), new[] { text } );
            }
            else
            {
                var startIndex = LogTextBox.TextLength;
                LogTextBox.AppendText( text + Environment.NewLine );
                var endIndex = LogTextBox.TextLength;
                LogTextBox.Select( startIndex, endIndex - startIndex );
                LogTextBox.ScrollToCaret();
            }
        }

        //----------------------------------------------------------------------
        void HandleTextReady( object source, TextDataEventArgs e )
        {
            if( string.IsNullOrEmpty( e.Text ) ) return;

            AppendAndScrollText( e.Text );
        }
    }
}
