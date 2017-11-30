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
            this.components = new System.ComponentModel.Container();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importFootageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchOutputDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsSearchTextBox = new System.Windows.Forms.TextBox();
            this.playersSearchTextBox = new System.Windows.Forms.TextBox();
            this.loopSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playEventGraphic = new System.Windows.Forms.Button();
            this.playPlayerButton = new System.Windows.Forms.Button();
            this.playLoopGraphic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentScreenLabel = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.loopTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graphicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loopsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capturetimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsListView
            // 
            this.eventsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.eventsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.eventsListView.FullRowSelect = true;
            this.eventsListView.GridLines = true;
            this.eventsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eventsListView.Location = new System.Drawing.Point(11, 69);
            this.eventsListView.Margin = new System.Windows.Forms.Padding(2);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(189, 188);
            this.eventsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.eventsListView.TabIndex = 0;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 175;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSceneToolStripMenuItem,
            this.openSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.toolStripSeparator1,
            this.importFootageToolStripMenuItem,
            this.switchOutputDisplayToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            this.newSceneToolStripMenuItem.Click += new System.EventHandler(this.newSceneToolStripMenuItem_Click);
            // 
            // openSceneToolStripMenuItem
            // 
            this.openSceneToolStripMenuItem.Name = "openSceneToolStripMenuItem";
            this.openSceneToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openSceneToolStripMenuItem.Text = "Open Scene";
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // importFootageToolStripMenuItem
            // 
            this.importFootageToolStripMenuItem.Name = "importFootageToolStripMenuItem";
            this.importFootageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.importFootageToolStripMenuItem.Text = "Import Footage";
            this.importFootageToolStripMenuItem.Click += new System.EventHandler(this.importFootageToolStripMenuItem_Click);
            // 
            // switchOutputDisplayToolStripMenuItem
            // 
            this.switchOutputDisplayToolStripMenuItem.Name = "switchOutputDisplayToolStripMenuItem";
            this.switchOutputDisplayToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.switchOutputDisplayToolStripMenuItem.Text = "Switch Output Display";
            this.switchOutputDisplayToolStripMenuItem.Click += new System.EventHandler(this.switchOutputDisplayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameSceneToolStripMenuItem,
            this.fadeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // renameSceneToolStripMenuItem
            // 
            this.renameSceneToolStripMenuItem.Name = "renameSceneToolStripMenuItem";
            this.renameSceneToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.renameSceneToolStripMenuItem.Text = "Rename Scene";
            this.renameSceneToolStripMenuItem.Click += new System.EventHandler(this.renameSceneToolStripMenuItem_Click);
            // 
            // fadeToolStripMenuItem
            // 
            this.fadeToolStripMenuItem.CheckOnClick = true;
            this.fadeToolStripMenuItem.Name = "fadeToolStripMenuItem";
            this.fadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fadeToolStripMenuItem.Text = "Fade";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players:";
            // 
            // eventsSearchTextBox
            // 
            this.eventsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsSearchTextBox.Location = new System.Drawing.Point(11, 48);
            this.eventsSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventsSearchTextBox.Name = "eventsSearchTextBox";
            this.eventsSearchTextBox.Size = new System.Drawing.Size(189, 20);
            this.eventsSearchTextBox.TabIndex = 3;
            // 
            // playersSearchTextBox
            // 
            this.playersSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playersSearchTextBox.Location = new System.Drawing.Point(204, 48);
            this.playersSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.playersSearchTextBox.Name = "playersSearchTextBox";
            this.playersSearchTextBox.Size = new System.Drawing.Size(189, 20);
            this.playersSearchTextBox.TabIndex = 4;
            // 
            // loopSearchTextBox
            // 
            this.loopSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loopSearchTextBox.Location = new System.Drawing.Point(397, 48);
            this.loopSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loopSearchTextBox.Name = "loopSearchTextBox";
            this.loopSearchTextBox.Size = new System.Drawing.Size(189, 20);
            this.loopSearchTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loops:";
            // 
            // playEventGraphic
            // 
            this.playEventGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playEventGraphic.Enabled = false;
            this.playEventGraphic.Location = new System.Drawing.Point(11, 262);
            this.playEventGraphic.Margin = new System.Windows.Forms.Padding(2);
            this.playEventGraphic.Name = "playEventGraphic";
            this.playEventGraphic.Size = new System.Drawing.Size(188, 24);
            this.playEventGraphic.TabIndex = 10;
            this.playEventGraphic.Text = "Play Selected Event Graphic";
            this.playEventGraphic.UseVisualStyleBackColor = true;
            this.playEventGraphic.Click += new System.EventHandler(this.playEventGraphic_Click);
            // 
            // playPlayerButton
            // 
            this.playPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playPlayerButton.Enabled = false;
            this.playPlayerButton.Location = new System.Drawing.Point(204, 262);
            this.playPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.playPlayerButton.Name = "playPlayerButton";
            this.playPlayerButton.Size = new System.Drawing.Size(188, 24);
            this.playPlayerButton.TabIndex = 10;
            this.playPlayerButton.Text = "Play Selected Player Graphic";
            this.playPlayerButton.UseVisualStyleBackColor = true;
            this.playPlayerButton.Click += new System.EventHandler(this.playPlayerButton_Click);
            // 
            // playLoopGraphic
            // 
            this.playLoopGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playLoopGraphic.Enabled = false;
            this.playLoopGraphic.Location = new System.Drawing.Point(398, 262);
            this.playLoopGraphic.Margin = new System.Windows.Forms.Padding(2);
            this.playLoopGraphic.Name = "playLoopGraphic";
            this.playLoopGraphic.Size = new System.Drawing.Size(188, 24);
            this.playLoopGraphic.TabIndex = 10;
            this.playLoopGraphic.Text = "Play Selected Loop Graphic";
            this.playLoopGraphic.UseVisualStyleBackColor = true;
            this.playLoopGraphic.Click += new System.EventHandler(this.playLoopGraphic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.currentScreenLabel);
            this.groupBox1.Controls.Add(this.previewPanel);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.loopTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.graphicTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(575, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now Playing:";
            // 
            // currentScreenLabel
            // 
            this.currentScreenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentScreenLabel.AutoSize = true;
            this.currentScreenLabel.Location = new System.Drawing.Point(4, 84);
            this.currentScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentScreenLabel.Name = "currentScreenLabel";
            this.currentScreenLabel.Size = new System.Drawing.Size(258, 17);
            this.currentScreenLabel.TabIndex = 5;
            this.currentScreenLabel.Text = "Displaying Graphics layers on Display 2";
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPanel.Location = new System.Drawing.Point(387, 10);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(2);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(188, 99);
            this.previewPanel.TabIndex = 4;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(280, 76);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 24);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pauseButton.Enabled = false;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(280, 48);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 24);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(279, 20);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 24);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // loopTextBox
            // 
            this.loopTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loopTextBox.Location = new System.Drawing.Point(64, 50);
            this.loopTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loopTextBox.Name = "loopTextBox";
            this.loopTextBox.ReadOnly = true;
            this.loopTextBox.Size = new System.Drawing.Size(204, 23);
            this.loopTextBox.TabIndex = 2;
            this.loopTextBox.Text = "None";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loop:";
            // 
            // graphicTextBox
            // 
            this.graphicTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicTextBox.Location = new System.Drawing.Point(64, 21);
            this.graphicTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.graphicTextBox.Name = "graphicTextBox";
            this.graphicTextBox.ReadOnly = true;
            this.graphicTextBox.Size = new System.Drawing.Size(204, 23);
            this.graphicTextBox.TabIndex = 2;
            this.graphicTextBox.Text = "None";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Graphic:";
            // 
            // playersListView
            // 
            this.playersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.playersListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.playersListView.FullRowSelect = true;
            this.playersListView.GridLines = true;
            this.playersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playersListView.Location = new System.Drawing.Point(205, 69);
            this.playersListView.Margin = new System.Windows.Forms.Padding(2);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(189, 188);
            this.playersListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.playersListView.TabIndex = 0;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 175;
            // 
            // loopsListView
            // 
            this.loopsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.loopsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loopsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.loopsListView.FullRowSelect = true;
            this.loopsListView.GridLines = true;
            this.loopsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.loopsListView.Location = new System.Drawing.Point(397, 69);
            this.loopsListView.Margin = new System.Windows.Forms.Padding(2);
            this.loopsListView.Name = "loopsListView";
            this.loopsListView.Size = new System.Drawing.Size(189, 188);
            this.loopsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.loopsListView.TabIndex = 0;
            this.loopsListView.UseCompatibleStateImageBehavior = false;
            this.loopsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 175;
            // 
            // capturetimer
            // 
            this.capturetimer.Interval = 50;
            this.capturetimer.Tick += new System.EventHandler(this.capturetimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playLoopGraphic);
            this.Controls.Add(this.playPlayerButton);
            this.Controls.Add(this.playEventGraphic);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(612, 1000);
            this.MinimumSize = new System.Drawing.Size(612, 452);
            this.Name = "MainForm";
            this.Text = "New Scene - QuickVideoBoardSwitch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
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
        private System.Windows.Forms.Button playEventGraphic;
        private System.Windows.Forms.Button playPlayerButton;
        private System.Windows.Forms.Button playLoopGraphic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox loopTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox graphicTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Label currentScreenLabel;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView loopsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem switchOutputDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSceneToolStripMenuItem;
        private System.Windows.Forms.Timer capturetimer;
    }
}

