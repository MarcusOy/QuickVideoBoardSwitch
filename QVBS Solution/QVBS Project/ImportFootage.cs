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
    public partial class ImportFootage : Form
    {
        MainForm mainForm;
        public ImportFootage(MainForm mainForm)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            this.mainForm = mainForm;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                try
                {
                    foreach (String filename in openFileDialog.FileNames)
                    {
                        Clip clip = new Clip(System.IO.Path.GetFileName(filename), filename);

                        clipListBox.Items.Add(clip);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            clipListBox.SelectedIndex = 0;
           
        }

        private void clipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clipListBox.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                Clip currentClip = (Clip)clipListBox.Items[clipListBox.SelectedIndex];
                axWindowsMediaPlayer1.URL = currentClip.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                addEventButton.Enabled = true;
                addPlayerButton.Enabled = true;
                addLoopButton.Enabled = true;
            }
            else
            {
                addEventButton.Enabled = false;
                addPlayerButton.Enabled = false;
                addLoopButton.Enabled = false;
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            this.mainForm.addToEvents((Clip)clipListBox.Items[clipListBox.SelectedIndex]);
            clipListBox.Items.RemoveAt(clipListBox.SelectedIndex);
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            this.mainForm.addToPlayers((Clip)clipListBox.Items[clipListBox.SelectedIndex]);
            clipListBox.Items.RemoveAt(clipListBox.SelectedIndex);
        }

        private void addLoopButton_Click(object sender, EventArgs e)
        {
            this.mainForm.addToLoops((Clip)clipListBox.Items[clipListBox.SelectedIndex]);
            clipListBox.Items.RemoveAt(clipListBox.SelectedIndex);
        }
    }
}
