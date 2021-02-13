using System;
using System.Windows.Forms;

using HideousWorks.Fracter.ColorTable;


namespace HideousWorks.Fracter.View.Controls
{
    public partial class VisualizerControl : UserControl
    {
        //----------------------------------------------------------------------
        IVisualizer m_Visualizer;
        public IVisualizer Visualizer
        {
            get { return m_Visualizer; }
            set
            {
                m_Visualizer = value;

                SetViewerPalette();
            }
        }

        //----------------------------------------------------------------------
        ColorTableList m_ColorTables;
        public ColorTableList ColorTables
        {
            get { return m_ColorTables; }
            set
            {
                m_ColorTables = value;
                ColorTableComboBox.Items.Clear();

                if( null == value ) return;

                ColorTableComboBox.Items.AddRange( value.ToArray() );
                ColorTableComboBox.SelectedIndex = 0;
            }
        }

        //----------------------------------------------------------------------
        ColorTableBase SelectedColorTable { get { return ColorTableComboBox.SelectedItem as ColorTableBase; } }

        //----------------------------------------------------------------------
        public VisualizerControl()
        {
            InitializeComponent();

            Visualizer = new NullVisualizer();
        }

        //----------------------------------------------------------------------
        void SetViewerPalette()
        {
            Visualizer.Palette = SelectedColorTable;
        }

        //----------------------------------------------------------------------
        private void VisualizerControl_Load( object sender, EventArgs e )
        {
            ColorTables = new ColorTableList();
        }

        //----------------------------------------------------------------------
        private void ColorTableComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            SetViewerPalette();

            var seedable = SelectedColorTable as IRandomSeeded;

            RandomSeedUpDown.Enabled = (null != seedable);
            RandomSeedLabel.Enabled = RandomSeedUpDown.Enabled;

            if( null != seedable )
            {
                RandomSeedUpDown.Value = seedable.Seed;
            }
        }

        //----------------------------------------------------------------------
        private void RandomSeedUpDown_ValueChanged( object sender, EventArgs e )
        {
            var seedable = SelectedColorTable as IRandomSeeded;

            if( null == seedable ) return;

            seedable.Seed = Convert.ToInt32( RandomSeedUpDown.Value );
            Visualizer.Reload();
        }

        //----------------------------------------------------------------------
        private void UpdateWhileGeneratingCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            Visualizer.IsIncrementalUpdateEnabled = UpdateWhileGeneratingCheckBox.Checked;
        }

        //----------------------------------------------------------------------
        private void RefreshByRowCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            Visualizer.IsPerRowUpdateEnabled = RefreshByRowCheckBox.Checked;
        }

	    //----------------------------------------------------------------------
	    private void AnimateCheckBox1_CheckedChanged( object sender, EventArgs e )
	    {
		    Visualizer.IsAnimated = AnimateCheckBox1.Checked;
	    }

	    private void FpsUpDown_ValueChanged( object sender, EventArgs e )
	    {
		    Visualizer.AnimFPS = Convert.ToSingle( FpsUpDown.Value );
	    }
    }
}
