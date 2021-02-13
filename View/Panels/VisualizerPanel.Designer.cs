using HideousWorks.Fracter.View.Controls;


namespace HideousWorks.Fracter.View.Panels
{
    partial class VisualizerPanel
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
            this.VisualizerSettings = new VisualizerControl();
            this.NavigableImage = new HideousWorks.Fracter.View.Controls.NavigableImageControl();
            this.SuspendLayout();
            // 
            // VisualizerSettings
            // 
            this.VisualizerSettings.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizerSettings.Location = new System.Drawing.Point( 0, 0 );
            this.VisualizerSettings.Name = "VisualizerSettings";
            this.VisualizerSettings.Size = new System.Drawing.Size( 337, 80 );
            this.VisualizerSettings.TabIndex = 0;
            // 
            // NavigableImage
            // 
            this.NavigableImage.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigableImage.BackColor = System.Drawing.Color.GhostWhite;
            this.NavigableImage.Data = null;
            this.NavigableImage.IsIncrementalUpdateEnabled = false;
            this.NavigableImage.IsPerRowUpdateEnabled = false;
            this.NavigableImage.Location = new System.Drawing.Point( 0, 86 );
            this.NavigableImage.Name = "NavigableImage";
            this.NavigableImage.Palette = null;
            this.NavigableImage.Size = new System.Drawing.Size( 337, 337 );
            this.NavigableImage.TabIndex = 1;
            // 
            // VisulalizerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.NavigableImage );
            this.Controls.Add( this.VisualizerSettings );
            this.Name = "VisualizerPanel";
            this.Size = new System.Drawing.Size( 338, 426 );
            this.ResumeLayout( false );

        }

        #endregion

        private VisualizerControl VisualizerSettings;
        private NavigableImageControl NavigableImage;
    }
}
