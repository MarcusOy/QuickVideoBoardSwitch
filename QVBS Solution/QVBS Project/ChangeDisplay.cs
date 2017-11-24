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
    public partial class ChangeDisplay : Form
    {
        MainForm mainForm;
        public ChangeDisplay(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            foreach (var screen in Screen.AllScreens)
            {
                // For each screen, add the screen properties to a list box.
                listBox1.Items.Add(new ScreenDetails(screen));
                //listBox1.Items.Add("Device Name: " + screen.DeviceName);
                //listBox1.Items.Add("Bounds: " + screen.Bounds.ToString());
                //listBox1.Items.Add("Type: " + screen.GetType().ToString());
                //listBox1.Items.Add("Working Area: " + screen.WorkingArea.ToString());
                //listBox1.Items.Add("Primary Screen: " + screen.Primary.ToString());
            }
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                ScreenDetails temp = (ScreenDetails)listBox1.Items[listBox1.SelectedIndex];
                nameTextBox.Text = temp.Screen.DeviceName;
                boundsTextBox.Text = temp.Screen.Bounds.ToString();
                typeTextBox.Text = temp.Screen.GetType().ToString();
                workingAreaTextBox.Text = temp.Screen.WorkingArea.ToString();
            }
        }
    }
}
