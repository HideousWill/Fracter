namespace HideousWorks.Fracter.View.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel1 = new HideousWorks.Fracter.View.Panels.MainPanel();
            this.SuspendLayout();
            // 
            // mainPanel1
            // 
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point( 0, 0 );
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size( 709, 565 );
            this.mainPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 709, 565 );
            this.Controls.Add( this.mainPanel1 );
            this.Name = "MainForm";
            this.Text = "Fracter";
            this.ResumeLayout( false );

        }

        #endregion

        private HideousWorks.Fracter.View.Panels.MainPanel mainPanel1;



    }
}