using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    public partial class MainForm : Form
    {
        Screen currentScreen;
        public MainForm()
        {
            InitializeComponent();
            refreshOutputLocation(Screen.AllScreens[1]);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importFootageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form importForm = new ImportFootage(this);
            importForm.Show();
        }

        private void switchOutputDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDisplay newForm = new ChangeDisplay(this);
            newForm.Show();
        }

        public void addToEvents(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            eventsListView.Items.Add(newRow);
        }

        public void addToPlayers(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            playersListView.Items.Add(newRow);
        }

        public void addToLoops(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            loopsListView.Items.Add(newRow);
        }

        public void refreshOutputLocation(Screen screen)
        {
            this.currentScreen = screen;
            currentScreenLabel.Text = "Displaying Graphics layers on" + screen.DeviceName;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form newForm = new OutputForm();
            newForm.Location = new Point(currentScreen.Bounds.X, currentScreen.Bounds.Y);
            newForm.Size = new Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
            newForm.Show();
        }

    }


}
