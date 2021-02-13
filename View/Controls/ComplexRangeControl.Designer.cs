namespace HideousWorks.Fracter.View.Controls
{
    partial class ComplexRangeControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RealUpDownControl = new DoubleRangeUpDownControl();
            this.ImaginaryUpDownControl = new DoubleRangeUpDownControl();
            this.LockAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.LockAspectRatioCheckBox );
            this.groupBox1.Controls.Add( this.RealUpDownControl );
            this.groupBox1.Controls.Add( this.ImaginaryUpDownControl );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 295, 146 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complex Range";
            // 
            // RealUpDownControl
            // 
            this.RealUpDownControl.Extent = 3;
            this.RealUpDownControl.Location = new System.Drawing.Point( 3, 19 );
            this.RealUpDownControl.Min = -2;
            this.RealUpDownControl.Name = "RealUpDownControl";
            this.RealUpDownControl.Size = new System.Drawing.Size( 141, 97 );
            this.RealUpDownControl.TabIndex = 2;
            this.RealUpDownControl.Title = "Real Range";
            // 
            // ImaginaryUpDownControl
            // 
            this.ImaginaryUpDownControl.Extent = 3;
            this.ImaginaryUpDownControl.Location = new System.Drawing.Point( 150, 20 );
            this.ImaginaryUpDownControl.Min = -1.5;
            this.ImaginaryUpDownControl.Name = "ImaginaryUpDownControl";
            this.ImaginaryUpDownControl.Size = new System.Drawing.Size( 141, 96 );
            this.ImaginaryUpDownControl.TabIndex = 3;
            this.ImaginaryUpDownControl.Title = "Imaginary Range";
            // 
            // LockAspectRatioCheckBox
            // 
            this.LockAspectRatioCheckBox.AutoSize = true;
            this.LockAspectRatioCheckBox.Checked = true;
            this.LockAspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LockAspectRatioCheckBox.Location = new System.Drawing.Point( 7, 123 );
            this.LockAspectRatioCheckBox.Name = "LockAspectRatioCheckBox";
            this.LockAspectRatioCheckBox.Size = new System.Drawing.Size( 114, 17 );
            this.LockAspectRatioCheckBox.TabIndex = 4;
            this.LockAspectRatioCheckBox.Text = "Lock Aspect Ratio";
            this.LockAspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComplexRangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "ComplexRangeControl";
            this.Size = new System.Drawing.Size( 295, 146 );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DoubleRangeUpDownControl RealUpDownControl;
        private DoubleRangeUpDownControl ImaginaryUpDownControl;
        private System.Windows.Forms.CheckBox LockAspectRatioCheckBox;
    }
}
