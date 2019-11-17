namespace MainPlugin.PlayVideo
{
    partial class PlayVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayVideo));
            this.WMP_Video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP_Video
            // 
            this.WMP_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP_Video.Enabled = true;
            this.WMP_Video.Location = new System.Drawing.Point(0, 0);
            this.WMP_Video.Name = "WMP_Video";
            this.WMP_Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_Video.OcxState")));
            this.WMP_Video.Size = new System.Drawing.Size(800, 450);
            this.WMP_Video.TabIndex = 0;
            // 
            // PlayVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WMP_Video);
            this.Name = "PlayVideo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video player";
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP_Video;
    }
}