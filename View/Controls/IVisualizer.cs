using System;
using System.Drawing;

using HideousWorks.Fracter.ColorTable;


namespace HideousWorks.Fracter.View.Controls
{
    public interface IImageNavigator
    {
        event EventHandler< RectangleEventArgs > RectangleSelected;
    }

    public interface IVisualizer : IImageNavigator
    {
        ColorTableBase Palette { get; set; }

		bool IsAnimated { get; set; }

		float AnimFPS { get; set; }

        bool IsIncrementalUpdateEnabled { get; set; }

        bool IsPerRowUpdateEnabled { get; set; }

        void Reload();
    }

    public class RectangleEventArgs : EventArgs
    {
        public Rectangle Rectangle { get; private set; }

        public RectangleEventArgs( Rectangle rectangle )
        {
            Rectangle = rectangle;
        }

        public RectangleEventArgs( RectangleF rectangle )
        {
            Rectangle = Rectangle.Round( rectangle );
        }
    }
}