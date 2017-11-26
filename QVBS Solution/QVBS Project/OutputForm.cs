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
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
            loopPlayer.uiMode = "none";
            graphicPlayer.uiMode = "none";

        }

        public void resume()
        {
            loopPlayer.Ctlcontrols.play();
            graphicPlayer.Ctlcontrols.play();
        }

        public void pause()
        {
            loopPlayer.Ctlcontrols.pause();
            graphicPlayer.Ctlcontrols.pause();
        }

        public void playLoop(Clip loop)
        {
            loopPlayer.URL = loop.FileName;
            loopPlayer.Ctlcontrols.play();
        }

        public void playGraphic(Clip graphic)
        {
            graphicPlayer.URL = graphic.FileName;
            graphicPlayer.Ctlcontrols.play();
        }

        private void graphicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (graphicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                graphicPlayer.Visible = true;
            }
            else if (graphicPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                graphicPlayer.Visible = false;
            }

        }
    }
}
