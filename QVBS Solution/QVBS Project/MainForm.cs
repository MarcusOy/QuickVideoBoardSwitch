using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    public partial class MainForm : Form
    {
        // Fields
        Screen currentScreen;
        OutputForm outputForm;
        Scene currentScene;
        List<Scene> scenesList;
        // Initializes form
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
            if (Properties.Settings.Default.Scenes != "")
            {
                scenesList = loadScenes();
            }

            if (Properties.Settings.Default.LastScene != "")
            {
                loadFromScene(loadLastScene());
            }
        }
        // Closes the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Displays the form to import footage into program
        private void importFootageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form importForm = new ImportFootage(this);
            importForm.Show();
        }
        // Displays the form to change displays for output window
        private void switchOutputDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDisplay newForm = new ChangeDisplay(this);
            newForm.Show();
        }
        // Adds a clip to the events section
        public void addToEvents(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            eventsListView.Items.Add(newRow);
        }
        // Adds a clip to the players section
        public void addToPlayers(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            playersListView.Items.Add(newRow);
        }
        // Adds a clip to the loops section
        public void addToLoops(Clip clip)
        {
            ListViewItem newRow = new ListViewItem(new[] { clip.Name, "" });
            newRow.Tag = clip;
            loopsListView.Items.Add(newRow);
        }
        // Changes the location of output window based on what screen is selected
        public void refreshOutputLocation(Screen screen)
        {
            this.currentScreen = screen;
            currentScreenLabel.Text = "Displaying Graphics layers on" + screen.DeviceName;
            if (outputForm != null)
            {
                outputForm.Location = new Point(currentScreen.Bounds.X, currentScreen.Bounds.Y);
                outputForm.Size = new Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
            }
        }
        // Resumes videos if output window is present
        // If not, open a new output window and wait
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

            capturetimer.Enabled = true;
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
        // Pauses all video on output window
        private void pauseButton_Click(object sender, EventArgs e)
        {
            outputForm.pause();

            playButton.Enabled = true;
            stopButton.Enabled = false;
            pauseButton.Enabled = true;

            playEventGraphic.Enabled = false;
            playPlayerButton.Enabled = false;
            playLoopGraphic.Enabled = false;

            capturetimer.Enabled = false;
        }
        // Stops and closes output window
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

            capturetimer.Enabled = false;
            previewPanel.BackgroundImage = null;

            updatePlayLabels("None", "None");
        }
        // Updates labels that show what is playing
        public void updatePlayLabels(String graphic, String loop)
        {
            if (graphic != "")
                this.graphicTextBox.Text = graphic;

            if (loop != "")
                this.loopTextBox.Text = loop;
        }
        // Saves the current scene into the program's properties when the form closes
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLastScene(saveIntoScene());
        }
        // Loads all saved scenes from program's Properties
        private List<Scene> loadScenes()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Scenes)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (List<Scene>)bf.Deserialize(ms);
            }
        }
        // Loads last opened up scene
        private Scene loadLastScene()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.LastScene)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (Scene)bf.Deserialize(ms);
            }
        }
        // Saves all the saved scenes and input it into program's Properties
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
        // Saves the current scene so it can be loaded when program is launched again
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
        // Saves data into scene object
        private Scene saveIntoScene()
        {
            string[] temp = this.Text.Split('-');

            List<Clip> eventsList = new List<Clip>();
            List<Clip> playersList = new List<Clip>();
            List<Clip> loopsList = new List<Clip>();

            for (int x = 0; x < this.eventsListView.Items.Count; x++)
            {
                eventsList.Add((Clip)this.eventsListView.Items[x].Tag);
            }

            for (int x = 0; x < this.playersListView.Items.Count; x++)
            {
                playersList.Add((Clip)this.playersListView.Items[x].Tag);
            }
            for (int x = 0; x < this.loopsListView.Items.Count; x++)
            {
                loopsList.Add((Clip)this.loopsListView.Items[x].Tag);
            }

            return new Scene(temp[0].Trim(), eventsList, playersList, loopsList);
        }
        // Loads data from scene object
        private void loadFromScene(Scene scene)
        {
            this.Text = scene.Name + " - QuickVideoBoardSwitch";

            for (int x = 0; x < scene.EventsList.Count; x++)
            {
                ListViewItem temp = new ListViewItem(scene.EventsList[x].Name);
                temp.Tag = scene.EventsList[x];
                this.eventsListView.Items.Add(temp);
            }

            for (int x = 0; x < scene.PlayersList.Count; x++)
            {
                ListViewItem temp = new ListViewItem(scene.PlayersList[x].Name);
                temp.Tag = scene.PlayersList[x];
                this.playersListView.Items.Add(temp);
            }

            for (int x = 0; x < scene.LoopsList.Count; x++)
            {
                ListViewItem temp = new ListViewItem(scene.LoopsList[x].Name);
                temp.Tag = scene.LoopsList[x];
                this.loopsListView.Items.Add(temp);
            }


        }
        // Calls an imput box that allows a scene rename
        private void renameSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String input = Microsoft.VisualBasic.Interaction.InputBox("What do you want to name the scene?");

            if (input != "")
            {
                this.Text = input + " - QuickVideoBoardSwitcher";
            }
        }
        // Event sub that calls the method to capture the screen
        // Also garbage collect to save RAM
        private void capturetimer_Tick(object sender, EventArgs e)
        {
            captureScreen();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        // Method to capture the screen
        private void captureScreen()
        {
            Bitmap bmp = new Bitmap(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(currentScreen.Bounds.X, currentScreen.Bounds.Y, 0, 0, bmp.Size);
            previewPanel.BackgroundImage = bmp;
        }
        // Removes all list items and resets name
        private void newSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "New Scene - QuickVideoBoardSwitch";
            this.eventsListView.Items.Clear();
            this.playersListView.Items.Clear();
            this.loopsListView.Items.Clear();

        }
    }


}
