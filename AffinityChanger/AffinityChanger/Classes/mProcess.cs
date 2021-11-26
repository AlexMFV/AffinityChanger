using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityChanger.Classes
{
    public class mProcess
    {
        string full_path;
        string name;
        bool isActive;


        public mProcess(string path)
        {
            this.full_path = path;
            this.name = ProcessName();
            this.isActive = false;
        }

        public void SetProcessActive()
        {
            this.isActive = true;
            //SetProcessAffinity();
            //SetProcessPriority();
        }

        string ProcessName()
        {
            for(int i = this.full_path.Length-1; i >= 0; i--)
                if (this.full_path[i] == '\\')
                    return this.full_path.Remove(0, i+1);
            return null;
        }
    }
}
