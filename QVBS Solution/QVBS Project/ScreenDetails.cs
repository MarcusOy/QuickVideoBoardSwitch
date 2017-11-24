using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QVBS_Project
{
    class ScreenDetails
    {
        Screen screen;

        public Screen Screen
        {
            get
            {
                return screen;
            }

            set
            {
                screen = value;
            }
        }

        public ScreenDetails(Screen screen)
        {
            this.Screen = screen;
        }



        public override string ToString()
        {
            return Screen.DeviceName;
        }
    }
}
