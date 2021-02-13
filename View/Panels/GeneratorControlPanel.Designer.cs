using HideousWorks.Fracter.View.Controls;


namespace HideousWorks.Fracter.View.Panels
{
    partial class GeneratorControlPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EvaluationUserControl = new HideousWorks.Fracter.View.Controls.EvaluationControl();
            this.SampleRateUserControl = new HideousWorks.Fracter.View.Controls.SampleRateControl();
            this.ComplexRangeUserControl = new HideousWorks.Fracter.View.Controls.ComplexRangeControl();
            this.DefaultsButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add( this.EvaluationUserControl );
            this.groupBox1.Controls.Add( this.SampleRateUserControl );
            this.groupBox1.Controls.Add( this.ComplexRangeUserControl );
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 300, 362 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator Controls";
            // 
            // EvaluationUserControl
            // 
            this.EvaluationUserControl.Convergence = 2;
            this.EvaluationUserControl.Iterations = 200;
            this.EvaluationUserControl.Location = new System.Drawing.Point( 3, 247 );
            this.EvaluationUserControl.Name = "EvaluationUserControl";
            this.EvaluationUserControl.Size = new System.Drawing.Size( 295, 100 );
            this.EvaluationUserControl.TabIndex = 3;
            // 
            // SampleRateUserControl
            // 
            this.SampleRateUserControl.Location = new System.Drawing.Point( 3, 171 );
            this.SampleRateUserControl.Name = "SampleRateUserControl";
            this.SampleRateUserControl.Resolution = new System.Drawing.Size( 256, 256 );
            this.SampleRateUserControl.Size = new System.Drawing.Size( 295, 70 );
            this.SampleRateUserControl.TabIndex = 2;
            // 
            // ComplexRangeUserControl
            // 
            this.ComplexRangeUserControl.Location = new System.Drawing.Point( 3, 19 );
            this.ComplexRangeUserControl.LockAspectRatio = true;
            this.ComplexRangeUserControl.Name = "ComplexRangeUserControl";
            this.ComplexRangeUserControl.Size = new System.Drawing.Size( 295, 146 );
            this.ComplexRangeUserControl.TabIndex = 0;
            // 
            // DefaultsButton
            // 
            this.DefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultsButton.Location = new System.Drawing.Point( 141, 371 );
            this.DefaultsButton.Name = "DefaultsButton";
            this.DefaultsButton.Size = new System.Drawing.Size( 75, 23 );
            this.DefaultsButton.TabIndex = 1;
            this.DefaultsButton.Text = "Defaults";
            this.DefaultsButton.UseVisualStyleBackColor = true;
            this.DefaultsButton.Click += new System.EventHandler( this.DefaultsButton_Click );
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point( 222, 371 );
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size( 75, 23 );
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler( this.GenerateButton_Click );
            // 
            // GeneratorControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.GenerateButton );
            this.Controls.Add( this.DefaultsButton );
            this.Controls.Add( this.groupBox1 );
            this.Name = "GeneratorControlPanel";
            this.Size = new System.Drawing.Size( 303, 398 );
            this.groupBox1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ComplexRangeControl ComplexRangeUserControl;
        private SampleRateControl SampleRateUserControl;
        private EvaluationControl EvaluationUserControl;
        private System.Windows.Forms.Button DefaultsButton;
        private System.Windows.Forms.Button GenerateButton;
    }
}
