namespace HideousWorks.Fracter.View.Controls
{
    partial class EvaluationControl
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
            this.IterationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneratorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvergenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.IterationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ConvergenceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.IterationUpDown );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.label3 );
            this.groupBox1.Controls.Add( this.GeneratorComboBox );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.ConvergenceUpDown );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 295, 100 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluation Technique";
            // 
            // IterationUpDown
            // 
            this.IterationUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IterationUpDown.Location = new System.Drawing.Point( 83, 46 );
            this.IterationUpDown.Maximum = new decimal( new int[] {
            256,
            0,
            0,
            0} );
            this.IterationUpDown.Minimum = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            this.IterationUpDown.Name = "IterationUpDown";
            this.IterationUpDown.Size = new System.Drawing.Size( 76, 20 );
            this.IterationUpDown.TabIndex = 1;
            this.IterationUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IterationUpDown.Value = new decimal( new int[] {
            200,
            0,
            0,
            0} );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 6, 22 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 57, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Generator:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 6, 48 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 53, 13 );
            this.label3.TabIndex = 0;
            this.label3.Text = "Iterations:";
            // 
            // GeneratorComboBox
            // 
            this.GeneratorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneratorComboBox.FormattingEnabled = true;
            this.GeneratorComboBox.Location = new System.Drawing.Point( 83, 19 );
            this.GeneratorComboBox.Name = "GeneratorComboBox";
            this.GeneratorComboBox.Size = new System.Drawing.Size( 206, 21 );
            this.GeneratorComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 6, 74 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 74, 13 );
            this.label2.TabIndex = 0;
            this.label2.Text = "Convergence:";
            // 
            // ConvergenceUpDown
            // 
            this.ConvergenceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvergenceUpDown.DecimalPlaces = 5;
            this.ConvergenceUpDown.Increment = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
            this.ConvergenceUpDown.Location = new System.Drawing.Point( 83, 72 );
            this.ConvergenceUpDown.Maximum = new decimal( new int[] {
            10,
            0,
            0,
            0} );
            this.ConvergenceUpDown.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
            this.ConvergenceUpDown.Name = "ConvergenceUpDown";
            this.ConvergenceUpDown.Size = new System.Drawing.Size( 76, 20 );
            this.ConvergenceUpDown.TabIndex = 1;
            this.ConvergenceUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ConvergenceUpDown.Value = new decimal( new int[] {
            2,
            0,
            0,
            0} );
            // 
            // EvaluationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "EvaluationControl";
            this.Size = new System.Drawing.Size( 295, 100 );
            this.Load += new System.EventHandler( this.EvaluationControl_Load );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.IterationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ConvergenceUpDown)).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GeneratorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IterationUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ConvergenceUpDown;
    }
}
