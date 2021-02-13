using System;


namespace HideousWorks.Fracter.Model
{
    public interface ISetData : ISampleSizeSource
    {
        event EventHandler< EventArgs > SetStarted;
        event EventHandler EntireSetChanged;
        event EventHandler< RowChangedEventArgs > RowChanged;

        int[ , ] Data { get; }
    }

    public class RowChangedEventArgs : EventArgs
    {
        public int RowIndex { get; private set; }

        public RowChangedEventArgs( int rowIndex )
        {
            RowIndex = rowIndex;
        }
    }
}