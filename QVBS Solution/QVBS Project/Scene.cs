using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    [Serializable]
    class Scene
    {
        String name;
        ListView.ListViewItemCollection eventsList;
        ListView.ListViewItemCollection playersList;
        ListView.ListViewItemCollection loopsList;

        public Scene()
        {
            this.Name = "New Scene";
            this.EventsList = null;
            this.PlayersList = null;
            this.LoopsList = null;

        }

        public Scene(String name, ListView.ListViewItemCollection events, ListView.ListViewItemCollection players, ListView.ListViewItemCollection loops)
        {
            this.Name = "New Scene";
            this.EventsList = events;
            this.PlayersList = players;
            this.LoopsList = loops;

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public ListView.ListViewItemCollection EventsList
        {
            get
            {
                return eventsList;
            }

            set
            {
                eventsList = value;
            }
        }

        public ListView.ListViewItemCollection PlayersList
        {
            get
            {
                return playersList;
            }

            set
            {
                playersList = value;
            }
        }

        public ListView.ListViewItemCollection LoopsList
        {
            get
            {
                return loopsList;
            }

            set
            {
                loopsList = value;
            }
        }
    }
}
