namespace HideousWorks.Fracter.View.Panels
{
    partial class MainPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.RootSplitContainer = new System.Windows.Forms.SplitContainer();
			this.GeneratorLogSplitContainer = new System.Windows.Forms.SplitContainer();
			this.GeneratorPanel = new HideousWorks.Fracter.View.Panels.GeneratorControlPanel();
			this.LogPanel = new HideousWorks.Fracter.View.Controls.LogControl();
			this.VisualizerPanel = new HideousWorks.Fracter.View.Panels.VisualizerPanel();
			((System.ComponentModel.ISupportInitialize)(this.RootSplitContainer)).BeginInit();
			this.RootSplitContainer.Panel1.SuspendLayout();
			this.RootSplitContainer.Panel2.SuspendLayout();
			this.RootSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GeneratorLogSplitContainer)).BeginInit();
			this.GeneratorLogSplitContainer.Panel1.SuspendLayout();
			this.GeneratorLogSplitContainer.Panel2.SuspendLayout();
			this.GeneratorLogSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// RootSplitContainer
			// 
			this.RootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RootSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.RootSplitContainer.IsSplitterFixed = true;
			this.RootSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.RootSplitContainer.Name = "RootSplitContainer";
			// 
			// RootSplitContainer.Panel1
			// 
			this.RootSplitContainer.Panel1.Controls.Add(this.GeneratorLogSplitContainer);
			// 
			// RootSplitContainer.Panel2
			// 
			this.RootSplitContainer.Panel2.Controls.Add(this.VisualizerPanel);
			this.RootSplitContainer.Size = new System.Drawing.Size(716, 555);
			this.RootSplitContainer.SplitterDistance = 304;
			this.RootSplitContainer.TabIndex = 0;
			// 
			// GeneratorLogSplitContainer
			// 
			this.GeneratorLogSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneratorLogSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.GeneratorLogSplitContainer.Name = "GeneratorLogSplitContainer";
			this.GeneratorLogSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// GeneratorLogSplitContainer.Panel1
			// 
			this.GeneratorLogSplitContainer.Panel1.Controls.Add(this.GeneratorPanel);
			// 
			// GeneratorLogSplitContainer.Panel2
			// 
			this.GeneratorLogSplitContainer.Panel2.Controls.Add(this.LogPanel);
			this.GeneratorLogSplitContainer.Size = new System.Drawing.Size(304, 555);
			this.GeneratorLogSplitContainer.SplitterDistance = 405;
			this.GeneratorLogSplitContainer.TabIndex = 0;
			// 
			// GeneratorPanel
			// 
			this.GeneratorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneratorPanel.Generator = null;
			this.GeneratorPanel.Location = new System.Drawing.Point(0, 0);
			this.GeneratorPanel.Name = "GeneratorPanel";
			this.GeneratorPanel.Navigator = null;
			this.GeneratorPanel.Size = new System.Drawing.Size(304, 405);
			this.GeneratorPanel.TabIndex = 0;
			// 
			// LogPanel
			// 
			this.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogPanel.Location = new System.Drawing.Point(0, 0);
			this.LogPanel.Name = "LogPanel";
			this.LogPanel.Size = new System.Drawing.Size(304, 146);
			this.LogPanel.TabIndex = 0;
			// 
			// VisualizerPanel
			// 
			this.VisualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VisualizerPanel.Generator = null;
			this.VisualizerPanel.Location = new System.Drawing.Point(0, 0);
			this.VisualizerPanel.Name = "VisualizerPanel";
			this.VisualizerPanel.Size = new System.Drawing.Size(408, 555);
			this.VisualizerPanel.TabIndex = 0;
			// 
			// MainPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RootSplitContainer);
			this.Name = "MainPanel";
			this.Size = new System.Drawing.Size(716, 555);
			this.Load += new System.EventHandler(this.MainPanel_Load);
			this.RootSplitContainer.Panel1.ResumeLayout(false);
			this.RootSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RootSplitContainer)).EndInit();
			this.RootSplitContainer.ResumeLayout(false);
			this.GeneratorLogSplitContainer.Panel1.ResumeLayout(false);
			this.GeneratorLogSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GeneratorLogSplitContainer)).EndInit();
			this.GeneratorLogSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer RootSplitContainer;
        private System.Windows.Forms.SplitContainer GeneratorLogSplitContainer;
        private HideousWorks.Fracter.View.Controls.LogControl LogPanel;
        private HideousWorks.Fracter.View.Panels.VisualizerPanel VisualizerPanel;
        private HideousWorks.Fracter.View.Panels.GeneratorControlPanel GeneratorPanel;
    }
}
