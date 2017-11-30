namespace QVBS_Project
{
    partial class OutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputForm));
            this.loopPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.graphicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.loopPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // loopPlayer
            // 
            this.loopPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loopPlayer.Enabled = true;
            this.loopPlayer.Location = new System.Drawing.Point(0, 0);
            this.loopPlayer.Name = "loopPlayer";
            this.loopPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("loopPlayer.OcxState")));
            this.loopPlayer.Size = new System.Drawing.Size(403, 393);
            this.loopPlayer.TabIndex = 0;
            // 
            // graphicPlayer
            // 
            this.graphicPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicPlayer.Enabled = true;
            this.graphicPlayer.Location = new System.Drawing.Point(0, 0);
            this.graphicPlayer.Name = "graphicPlayer";
            this.graphicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("graphicPlayer.OcxState")));
            this.graphicPlayer.Size = new System.Drawing.Size(403, 393);
            this.graphicPlayer.TabIndex = 2;
            this.graphicPlayer.Visible = false;
            this.graphicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.graphicPlayer_PlayStateChange_1);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 393);
            this.Controls.Add(this.graphicPlayer);
            this.Controls.Add(this.loopPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OutputForm";
            this.Text = "Output";
            ((System.ComponentModel.ISupportInitialize)(this.loopPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer loopPlayer;
        private AxWMPLib.AxWindowsMediaPlayer graphicPlayer;
    }
}