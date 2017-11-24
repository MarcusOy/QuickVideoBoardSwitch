namespace QVBS_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.eventsListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isPlayingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importFootageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchOutputDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsSearchTextBox = new System.Windows.Forms.TextBox();
            this.playersSearchTextBox = new System.Windows.Forms.TextBox();
            this.loopSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loopsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsListView
            // 
            this.eventsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.isPlayingColumn});
            this.eventsListView.FullRowSelect = true;
            this.eventsListView.GridLines = true;
            this.eventsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eventsListView.Location = new System.Drawing.Point(15, 85);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(251, 231);
            this.eventsListView.TabIndex = 0;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 125;
            // 
            // isPlayingColumn
            // 
            this.isPlayingColumn.Text = "Is Playing?";
            this.isPlayingColumn.Width = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.toolStripSeparator1,
            this.importFootageToolStripMenuItem,
            this.switchOutputDisplayToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSceneToolStripMenuItem
            // 
            this.openSceneToolStripMenuItem.Name = "openSceneToolStripMenuItem";
            this.openSceneToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.openSceneToolStripMenuItem.Text = "Open Scene";
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // importFootageToolStripMenuItem
            // 
            this.importFootageToolStripMenuItem.Name = "importFootageToolStripMenuItem";
            this.importFootageToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.importFootageToolStripMenuItem.Text = "Import Footage";
            this.importFootageToolStripMenuItem.Click += new System.EventHandler(this.importFootageToolStripMenuItem_Click);
            // 
            // switchOutputDisplayToolStripMenuItem
            // 
            this.switchOutputDisplayToolStripMenuItem.Name = "switchOutputDisplayToolStripMenuItem";
            this.switchOutputDisplayToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.switchOutputDisplayToolStripMenuItem.Text = "Switch Output Display";
            this.switchOutputDisplayToolStripMenuItem.Click += new System.EventHandler(this.switchOutputDisplayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players:";
            // 
            // eventsSearchTextBox
            // 
            this.eventsSearchTextBox.Location = new System.Drawing.Point(15, 59);
            this.eventsSearchTextBox.Name = "eventsSearchTextBox";
            this.eventsSearchTextBox.Size = new System.Drawing.Size(251, 22);
            this.eventsSearchTextBox.TabIndex = 3;
            // 
            // playersSearchTextBox
            // 
            this.playersSearchTextBox.Location = new System.Drawing.Point(272, 59);
            this.playersSearchTextBox.Name = "playersSearchTextBox";
            this.playersSearchTextBox.Size = new System.Drawing.Size(251, 22);
            this.playersSearchTextBox.TabIndex = 4;
            // 
            // loopSearchTextBox
            // 
            this.loopSearchTextBox.Location = new System.Drawing.Point(529, 59);
            this.loopSearchTextBox.Name = "loopSearchTextBox";
            this.loopSearchTextBox.Size = new System.Drawing.Size(251, 22);
            this.loopSearchTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loops:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Play Selected Event Graphic";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Play Selected Player Graphic";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Play Selected Loop Graphic";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 139);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now Playing:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Displaying Graphics layers on Display 2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(514, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 127);
            this.panel1.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(251, 127);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(373, 94);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(133, 29);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(373, 59);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(133, 29);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(372, 24);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(133, 29);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(271, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loop:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(271, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Graphic:";
            // 
            // playersListView
            // 
            this.playersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.playersListView.FullRowSelect = true;
            this.playersListView.GridLines = true;
            this.playersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playersListView.Location = new System.Drawing.Point(273, 85);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(251, 231);
            this.playersListView.TabIndex = 0;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Is Playing?";
            this.columnHeader2.Width = 87;
            // 
            // loopsListView
            // 
            this.loopsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.loopsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.loopsListView.FullRowSelect = true;
            this.loopsListView.GridLines = true;
            this.loopsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.loopsListView.Location = new System.Drawing.Point(529, 85);
            this.loopsListView.Name = "loopsListView";
            this.loopsListView.Size = new System.Drawing.Size(251, 231);
            this.loopsListView.TabIndex = 0;
            this.loopsListView.UseCompatibleStateImageBehavior = false;
            this.loopsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is Playing?";
            this.columnHeader4.Width = 87;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loopSearchTextBox);
            this.Controls.Add(this.playersSearchTextBox);
            this.Controls.Add(this.eventsSearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loopsListView);
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.eventsListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "lel xd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader isPlayingColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventsSearchTextBox;
        private System.Windows.Forms.TextBox playersSearchTextBox;
        private System.Windows.Forms.TextBox loopSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem openSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importFootageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView loopsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem switchOutputDisplayToolStripMenuItem;
    }
}

