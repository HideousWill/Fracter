using System.Windows.Forms;

using HideousWorks.Fracter.Model;
using HideousWorks.Fracter.View.Controls;


namespace HideousWorks.Fracter.View.Panels
{
    public partial class VisualizerPanel : UserControl
    {
        SetGenerator m_Generator;
        public SetGenerator Generator
        {
            get { return m_Generator; }
            set
            {
                m_Generator = value;

                NavigableImage.Data = value;
            }
        }

        public IImageNavigator ImageNavigator
        {
            get { return NavigableImage; }
        }

        public VisualizerPanel()
        {
            InitializeComponent();

            VisualizerSettings.Visualizer = NavigableImage;
        }
    }
}
