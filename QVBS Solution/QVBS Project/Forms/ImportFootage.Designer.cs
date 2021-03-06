﻿namespace QVBS_Project
{
    partial class ImportFootage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFootage));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.clipListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addLoopButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.addEventButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.clipListBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Files:";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(4, 309);
            this.openButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(141, 22);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open from File...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // clipListBox
            // 
            this.clipListBox.FormattingEnabled = true;
            this.clipListBox.Location = new System.Drawing.Point(4, 17);
            this.clipListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clipListBox.Name = "clipListBox";
            this.clipListBox.Size = new System.Drawing.Size(142, 277);
            this.clipListBox.TabIndex = 0;
            this.clipListBox.SelectedIndexChanged += new System.EventHandler(this.clipListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox2.Location = new System.Drawing.Point(164, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(213, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 15);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(209, 213);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addLoopButton);
            this.groupBox3.Controls.Add(this.addPlayerButton);
            this.groupBox3.Controls.Add(this.addEventButton);
            this.groupBox3.Location = new System.Drawing.Point(166, 245);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(207, 96);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add to current scene as...";
            // 
            // addLoopButton
            // 
            this.addLoopButton.Enabled = false;
            this.addLoopButton.Location = new System.Drawing.Point(136, 17);
            this.addLoopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addLoopButton.Name = "addLoopButton";
            this.addLoopButton.Size = new System.Drawing.Size(56, 74);
            this.addLoopButton.TabIndex = 0;
            this.addLoopButton.Text = "Loop";
            this.addLoopButton.UseVisualStyleBackColor = true;
            this.addLoopButton.Click += new System.EventHandler(this.addLoopButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Enabled = false;
            this.addPlayerButton.Location = new System.Drawing.Point(76, 17);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(56, 74);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // addEventButton
            // 
            this.addEventButton.Enabled = false;
            this.addEventButton.Location = new System.Drawing.Point(15, 17);
            this.addEventButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(56, 74);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // ImportFootage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ImportFootage";
            this.Text = "Import Footage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox clipListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addLoopButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button addEventButton;
    }
}