namespace HideousWorks.Fracter.View.Controls
{
    partial class DoubleRangeUpDownControl
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExtentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.MinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ExtentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add( this.MaxTextBox );
            this.GroupBox.Controls.Add( this.label3 );
            this.GroupBox.Controls.Add( this.MinUpDown );
            this.GroupBox.Controls.Add( this.ExtentUpDown );
            this.GroupBox.Controls.Add( this.label2 );
            this.GroupBox.Controls.Add( this.label1 );
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point( 0, 0 );
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size( 163, 98 );
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Double Range";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTextBox.Location = new System.Drawing.Point( 54, 16 );
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.ReadOnly = true;
            this.MaxTextBox.Size = new System.Drawing.Size( 88, 20 );
            this.MaxTextBox.TabIndex = 3;
            this.MaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 8, 16 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 30, 13 );
            this.label3.TabIndex = 2;
            this.label3.Text = "Max:";
            // 
            // MinUpDown
            // 
            this.MinUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MinUpDown.DecimalPlaces = 7;
            this.MinUpDown.Increment = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
            this.MinUpDown.Location = new System.Drawing.Point( 54, 71 );
            this.MinUpDown.Maximum = new decimal( new int[] {
            10,
            0,
            0,
            0} );
            this.MinUpDown.Minimum = new decimal( new int[] {
            10,
            0,
            0,
            -2147483648} );
            this.MinUpDown.Name = "MinUpDown";
            this.MinUpDown.Size = new System.Drawing.Size( 103, 20 );
            this.MinUpDown.TabIndex = 1;
            this.MinUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinUpDown.Value = new decimal( new int[] {
            1,
            0,
            0,
            -2147483648} );
            this.MinUpDown.ValueChanged += new System.EventHandler( this.MinUpDown_ValueChanged );
            // 
            // ExtentUpDown
            // 
            this.ExtentUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtentUpDown.DecimalPlaces = 7;
            this.ExtentUpDown.Increment = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
            this.ExtentUpDown.Location = new System.Drawing.Point( 54, 42 );
            this.ExtentUpDown.Maximum = new decimal( new int[] {
            10,
            0,
            0,
            0} );
            this.ExtentUpDown.Name = "ExtentUpDown";
            this.ExtentUpDown.Size = new System.Drawing.Size( 103, 20 );
            this.ExtentUpDown.TabIndex = 1;
            this.ExtentUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExtentUpDown.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            this.ExtentUpDown.ValueChanged += new System.EventHandler( this.ExtentUpDown_ValueChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 8, 73 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 27, 13 );
            this.label2.TabIndex = 0;
            this.label2.Text = "Min:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 8, 44 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 40, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Extent:";
            // 
            // DoubleRangeUpDownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.GroupBox );
            this.Name = "DoubleRangeUpDownControl";
            this.Size = new System.Drawing.Size( 163, 98 );
            this.GroupBox.ResumeLayout( false );
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.MinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ExtentUpDown)).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.NumericUpDown MinUpDown;
        private System.Windows.Forms.NumericUpDown ExtentUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxTextBox;

    }
}
