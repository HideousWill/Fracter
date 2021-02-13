using System;


namespace HideousWorks.Fracter.Common
{
    public interface ITextSource
    {
        event EventHandler< TextDataEventArgs > TextReady;

        string Name { get; }
    }
}