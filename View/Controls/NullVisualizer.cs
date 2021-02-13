using System;

using HideousWorks.Fracter.ColorTable;


namespace HideousWorks.Fracter.View.Controls
{
    public sealed class NullVisualizer : IVisualizer
    {
        public event EventHandler< RectangleEventArgs > RectangleSelected;

        public ColorTableBase Palette { get; set; }

	    public bool IsAnimated { get; set; }
	    public float AnimFPS { get; set; }

	    public bool IsIncrementalUpdateEnabled { get; set; }

        public bool IsPerRowUpdateEnabled { get; set; }

        public void Reload() { }
    }
}