using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QVBS_Project
{
    [Serializable]
    public class Clip
    {

        String fileName;
        String name;

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
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


        public Clip(String name, String fileName)
        {
            this.FileName = fileName;
            this.Name = name;

        }

        public override String ToString()
        {
            return this.Name;
        }
    }
}
