namespace HideousWorks.Fracter.View.Controls
{
    partial class VisualizerControl
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
			this.AnimateCheckBox = new System.Windows.Forms.GroupBox();
			this.AnimateCheckBox1 = new System.Windows.Forms.CheckBox();
			this.FpsUpDown = new System.Windows.Forms.NumericUpDown();
			this.ColorTableComboBox = new System.Windows.Forms.ComboBox();
			this.RefreshByRowCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.UpdateWhileGeneratingCheckBox = new System.Windows.Forms.CheckBox();
			this.RandomSeedLabel = new System.Windows.Forms.Label();
			this.RandomSeedUpDown = new System.Windows.Forms.NumericUpDown();
			this.AnimateCheckBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomSeedUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// AnimateCheckBox
			// 
			this.AnimateCheckBox.Controls.Add(this.AnimateCheckBox1);
			this.AnimateCheckBox.Controls.Add(this.FpsUpDown);
			this.AnimateCheckBox.Controls.Add(this.ColorTableComboBox);
			this.AnimateCheckBox.Controls.Add(this.RefreshByRowCheckBox);
			this.AnimateCheckBox.Controls.Add(this.label3);
			this.AnimateCheckBox.Controls.Add(this.UpdateWhileGeneratingCheckBox);
			this.AnimateCheckBox.Controls.Add(this.RandomSeedLabel);
			this.AnimateCheckBox.Controls.Add(this.RandomSeedUpDown);
			this.AnimateCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnimateCheckBox.Location = new System.Drawing.Point(0, 0);
			this.AnimateCheckBox.Name = "AnimateCheckBox";
			this.AnimateCheckBox.Size = new System.Drawing.Size(472, 80);
			this.AnimateCheckBox.TabIndex = 0;
			this.AnimateCheckBox.TabStop = false;
			this.AnimateCheckBox.Text = "Image Controls";
			// 
			// AnimateCheckBox1
			// 
			this.AnimateCheckBox1.AutoSize = true;
			this.AnimateCheckBox1.Location = new System.Drawing.Point(183, 21);
			this.AnimateCheckBox1.Name = "AnimateCheckBox1";
			this.AnimateCheckBox1.Size = new System.Drawing.Size(64, 17);
			this.AnimateCheckBox1.TabIndex = 10;
			this.AnimateCheckBox1.Text = "Animate";
			this.AnimateCheckBox1.UseVisualStyleBackColor = true;
			this.AnimateCheckBox1.CheckedChanged += new System.EventHandler(this.AnimateCheckBox1_CheckedChanged);
			// 
			// FpsUpDown
			// 
			this.FpsUpDown.DecimalPlaces = 1;
			this.FpsUpDown.Location = new System.Drawing.Point(183, 45);
			this.FpsUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.FpsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.FpsUpDown.Name = "FpsUpDown";
			this.FpsUpDown.Size = new System.Drawing.Size(64, 20);
			this.FpsUpDown.TabIndex = 9;
			this.FpsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.FpsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.FpsUpDown.ValueChanged += new System.EventHandler(this.FpsUpDown_ValueChanged);
			// 
			// ColorTableComboBox
			// 
			this.ColorTableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ColorTableComboBox.FormattingEnabled = true;
			this.ColorTableComboBox.Location = new System.Drawing.Point(77, 19);
			this.ColorTableComboBox.Name = "ColorTableComboBox";
			this.ColorTableComboBox.Size = new System.Drawing.Size(91, 21);
			this.ColorTableComboBox.TabIndex = 4;
			this.ColorTableComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorTableComboBox_SelectedIndexChanged);
			// 
			// RefreshByRowCheckBox
			// 
			this.RefreshByRowCheckBox.AutoSize = true;
			this.RefreshByRowCheckBox.Location = new System.Drawing.Point(268, 47);
			this.RefreshByRowCheckBox.Name = "RefreshByRowCheckBox";
			this.RefreshByRowCheckBox.Size = new System.Drawing.Size(103, 17);
			this.RefreshByRowCheckBox.TabIndex = 7;
			this.RefreshByRowCheckBox.Text = "Refresh By Row";
			this.RefreshByRowCheckBox.UseVisualStyleBackColor = true;
			this.RefreshByRowCheckBox.CheckedChanged += new System.EventHandler(this.RefreshByRowCheckBox_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Color Table:";
			// 
			// UpdateWhileGeneratingCheckBox
			// 
			this.UpdateWhileGeneratingCheckBox.AutoSize = true;
			this.UpdateWhileGeneratingCheckBox.Location = new System.Drawing.Point(268, 21);
			this.UpdateWhileGeneratingCheckBox.Name = "UpdateWhileGeneratingCheckBox";
			this.UpdateWhileGeneratingCheckBox.Size = new System.Drawing.Size(146, 17);
			this.UpdateWhileGeneratingCheckBox.TabIndex = 6;
			this.UpdateWhileGeneratingCheckBox.Text = "Update While Generating";
			this.UpdateWhileGeneratingCheckBox.UseVisualStyleBackColor = true;
			this.UpdateWhileGeneratingCheckBox.CheckedChanged += new System.EventHandler(this.UpdateWhileGeneratingCheckBox_CheckedChanged);
			// 
			// RandomSeedLabel
			// 
			this.RandomSeedLabel.AutoSize = true;
			this.RandomSeedLabel.Location = new System.Drawing.Point(36, 49);
			this.RandomSeedLabel.Name = "RandomSeedLabel";
			this.RandomSeedLabel.Size = new System.Drawing.Size(35, 13);
			this.RandomSeedLabel.TabIndex = 0;
			this.RandomSeedLabel.Text = "Seed:";
			// 
			// RandomSeedUpDown
			// 
			this.RandomSeedUpDown.Location = new System.Drawing.Point(77, 46);
			this.RandomSeedUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.RandomSeedUpDown.Name = "RandomSeedUpDown";
			this.RandomSeedUpDown.Size = new System.Drawing.Size(53, 20);
			this.RandomSeedUpDown.TabIndex = 1;
			this.RandomSeedUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RandomSeedUpDown.ValueChanged += new System.EventHandler(this.RandomSeedUpDown_ValueChanged);
			// 
			// VisualizerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.AnimateCheckBox);
			this.Name = "VisualizerControl";
			this.Size = new System.Drawing.Size(472, 80);
			this.Load += new System.EventHandler(this.VisualizerControl_Load);
			this.AnimateCheckBox.ResumeLayout(false);
			this.AnimateCheckBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomSeedUpDown)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnimateCheckBox;
        private System.Windows.Forms.ComboBox ColorTableComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RandomSeedLabel;
        private System.Windows.Forms.NumericUpDown RandomSeedUpDown;
        private System.Windows.Forms.CheckBox RefreshByRowCheckBox;
        private System.Windows.Forms.CheckBox UpdateWhileGeneratingCheckBox;
		private System.Windows.Forms.NumericUpDown FpsUpDown;
		private System.Windows.Forms.CheckBox AnimateCheckBox1;
	}
}
