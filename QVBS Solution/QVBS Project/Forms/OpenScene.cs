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
    public partial class OpenScene : Form
    {
        MainForm mainForm;
        public OpenScene(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            if (this.mainForm.scenesList != null)
            {
                for (int x = 0; x < this.mainForm.scenesList.Count; x++)
                {
                    scenesListBox.Items.Add(this.mainForm.scenesList[x]);
                }
                scenesListBox.SelectedIndex = 0;
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (scenesListBox.SelectedIndex >= 0)
            {
                this.mainForm.loadFromScene((Scene)scenesListBox.Items[scenesListBox.SelectedIndex]);
            }
            this.Close();
        }

        private void scenesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this scene?", "Remove Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = scenesListBox.SelectedIndex;
                    scenesListBox.Items.RemoveAt(index);
                    this.mainForm.scenesList.RemoveAt(index);
                }

            }
        }
    }
}
