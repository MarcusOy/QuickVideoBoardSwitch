using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    public partial class MainForm : Form
    {

        Screen currentScreen;
        OutputForm outputForm;
        Scene currentScene;
        List<Scene> scenesList;

        public MainForm()
        {
            InitializeComponent();

            if (Screen.AllScreens.Count() > 1)
            {
                refreshOutputLocation(Screen.AllScreens[1]);
            }
            else
            {
                MessageBox.Show("The computer doesn't have a second display connected.");
                refreshOutputLocation(Screen.AllScreens[0]);
            }
            //if (Properties.Settings.Default.Scenes != null)
            //{
            //    scenesList = loadScenes();
            //}

            //if (Properties.Settings.Default.LastScene != null)
            //{
            //    loadFromScene(loadLastScene());
            //}
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
            if (outputForm != null)
            {
                outputForm.Show();
                outputForm.resume();
            }
            else
            {
                outputForm = new OutputForm(this);
                outputForm.Location = new Point(currentScreen.Bounds.X, currentScreen.Bounds.Y);
                outputForm.Size = new Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
                outputForm.Show();
                outputForm.resume();
            }
            
            playButton.Enabled = false;
            stopButton.Enabled = true;
            pauseButton.Enabled = true;

            playEventGraphic.Enabled = true;
            playPlayerButton.Enabled = true;
            playLoopGraphic.Enabled = true;
        }

        private void playEventGraphic_Click(object sender, EventArgs e)
        {
            if (eventsListView.SelectedItems != null)
            {
                outputForm.playGraphic((Clip)eventsListView.SelectedItems[0].Tag);
            }
            
        }

        private void playPlayerButton_Click(object sender, EventArgs e)
        {
            if (playersListView.SelectedItems != null)
            {
                outputForm.playGraphic((Clip)playersListView.SelectedItems[0].Tag);
            }
        }

        private void playLoopGraphic_Click(object sender, EventArgs e)
        {
            if (loopsListView.SelectedItems != null)
            {
                outputForm.playLoop((Clip)loopsListView.SelectedItems[0].Tag);
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            outputForm.pause();

            playButton.Enabled = true;
            stopButton.Enabled = false;
            pauseButton.Enabled = true;

            playEventGraphic.Enabled = false;
            playPlayerButton.Enabled = false;
            playLoopGraphic.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            outputForm.Close();
            outputForm = null;

            playButton.Enabled = true;
            stopButton.Enabled = false;
            pauseButton.Enabled = false;

            playEventGraphic.Enabled = false;
            playPlayerButton.Enabled = false;
            playLoopGraphic.Enabled = false;
        }

        public void updatePlayLabels(String graphic, String loop)
        {
            if (graphic != "")
                this.graphicTextBox.Text = graphic;

            if (loop != "")
                this.loopTextBox.Text = loop;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saveLastScene(saveIntoScene());
        }

        private List<Scene> loadScenes()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Scenes)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (List<Scene>)bf.Deserialize(ms);
            }
        }

        private Scene loadLastScene()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.LastScene)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (Scene)bf.Deserialize(ms);
            }
        }

        private void saveScenes(List<Scene> scenes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, scenes);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                Properties.Settings.Default.Scenes = Convert.ToBase64String(buffer);
                Properties.Settings.Default.Save();
            }
        }

        private void saveLastScene(Scene scene)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, scene);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                Properties.Settings.Default.LastScene = Convert.ToBase64String(buffer);
                Properties.Settings.Default.Save();
            }
        }

        private Scene saveIntoScene()
        {
            string[] temp = this.Text.Split('-');
            return new Scene(temp[0].Trim(), eventsListView.Items, playersListView.Items, loopsListView.Items);
        }

        private void loadFromScene(Scene scene)
        {
            this.Text = scene.Name + " - QuickVideoBoardSwitch";

            for (int x = 0; x < scene.EventsList.Count; x++)
            {
                this.eventsListView.Items.Add(scene.EventsList[x]);
            }

            for (int x = 0; x < scene.PlayersList.Count; x++)
            {
                this.playersListView.Items.Add(scene.PlayersList[x]);
            }

            for (int x = 0; x < scene.LoopsList.Count; x++)
            {
                this.loopsListView.Items.Add(scene.LoopsList[x]);
            }


        }

        private void renameSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String input = Microsoft.VisualBasic.Interaction.InputBox("What do you want to name the scene?");

            if (input != "")
            {
                this.Text = input + " - QuickVideoBoardSwitcher";
            }
        }
    }


}
