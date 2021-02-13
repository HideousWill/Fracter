using System;
using System.Windows.Forms;

using HideousWorks.Fracter.Model;


namespace HideousWorks.Fracter.View.Panels
{
    public partial class MainPanel : UserControl
    {
        SetGenerator Generator { get; set; }

        public MainPanel()
        {
            InitializeComponent();

            Generator = new SetGenerator();
        }

        private void MainPanel_Load( object sender, System.EventArgs e )
        {
            VisualizerPanel.Generator = Generator;
            GeneratorPanel.Generator  = Generator;
            GeneratorPanel.Navigator  = VisualizerPanel.ImageNavigator;
        }
    }
}
