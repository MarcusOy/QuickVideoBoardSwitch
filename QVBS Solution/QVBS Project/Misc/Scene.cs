using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    [Serializable]
    public class Scene
    {
        String name;
        List<Clip> eventsList;
        List<Clip> playersList;
        List<Clip> loopsList;

        public Scene()
        {
            this.Name = "New Scene";
            this.EventsList = null;
            this.PlayersList = null;
            this.LoopsList = null;

        }

        public Scene(String name, List<Clip> events, List<Clip> players, List<Clip> loops)
        {
            this.Name = name;
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

        public List<Clip> EventsList
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

        public List<Clip> PlayersList
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

        public List<Clip> LoopsList
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

        public override string ToString()
        {
            return this.name;
        }
    }
}
