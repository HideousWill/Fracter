using System;


namespace HideousWorks.Fracter.Common
{
    public class TextDataEventArgs : EventArgs
    {
        public string Text { get; private set; }

        public TextDataEventArgs( string text )
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}