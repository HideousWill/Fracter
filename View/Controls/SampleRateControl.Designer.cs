namespace HideousWorks.Fracter.View.Controls
{
    partial class SampleRateControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ImaginaryUpDown = new System.Windows.Forms.NumericUpDown();
            this.RealUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LockAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.ImaginaryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.RealUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 143, 21 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 55, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Imaginary:";
            // 
            // ImaginaryUpDown
            // 
            this.ImaginaryUpDown.Increment = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            this.ImaginaryUpDown.Location = new System.Drawing.Point( 204, 19 );
            this.ImaginaryUpDown.Maximum = new decimal( new int[] {
            1024,
            0,
            0,
            0} );
            this.ImaginaryUpDown.Minimum = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            this.ImaginaryUpDown.Name = "ImaginaryUpDown";
            this.ImaginaryUpDown.Size = new System.Drawing.Size( 53, 20 );
            this.ImaginaryUpDown.TabIndex = 1;
            this.ImaginaryUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ImaginaryUpDown.Value = new decimal( new int[] {
            256,
            0,
            0,
            0} );
            // 
            // RealUpDown
            // 
            this.RealUpDown.Increment = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            this.RealUpDown.Location = new System.Drawing.Point( 57, 19 );
            this.RealUpDown.Maximum = new decimal( new int[] {
            1024,
            0,
            0,
            0} );
            this.RealUpDown.Minimum = new decimal( new int[] {
            16,
            0,
            0,
            0} );
            this.RealUpDown.Name = "RealUpDown";
            this.RealUpDown.Size = new System.Drawing.Size( 53, 20 );
            this.RealUpDown.TabIndex = 1;
            this.RealUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RealUpDown.Value = new decimal( new int[] {
            256,
            0,
            0,
            0} );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 13, 21 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 32, 13 );
            this.label2.TabIndex = 0;
            this.label2.Text = "Real:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.LockAspectRatioCheckBox );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.ImaginaryUpDown );
            this.groupBox1.Controls.Add( this.RealUpDown );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 295, 70 );
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling Rate";
            // 
            // LockAspectRatioCheckBox
            // 
            this.LockAspectRatioCheckBox.AutoSize = true;
            this.LockAspectRatioCheckBox.Checked = true;
            this.LockAspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LockAspectRatioCheckBox.Location = new System.Drawing.Point( 6, 45 );
            this.LockAspectRatioCheckBox.Name = "LockAspectRatioCheckBox";
            this.LockAspectRatioCheckBox.Size = new System.Drawing.Size( 114, 17 );
            this.LockAspectRatioCheckBox.TabIndex = 2;
            this.LockAspectRatioCheckBox.Text = "Lock Aspect Ratio";
            this.LockAspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // SampleRateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "SampleRateControl";
            this.Size = new System.Drawing.Size( 295, 70 );
            ((System.ComponentModel.ISupportInitialize) (this.ImaginaryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.RealUpDown)).EndInit();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ImaginaryUpDown;
        private System.Windows.Forms.NumericUpDown RealUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LockAspectRatioCheckBox;
    }
}
