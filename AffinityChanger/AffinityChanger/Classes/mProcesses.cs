using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinityChanger.Classes
{
    public class mProcesses : CollectionBase
    {
        public void Add(mProcess item)
        {
            List.Add(item);
        }

        public void Remove(mProcess item)
        {
            List.Remove(item);
        }

        public mProcess this[int index]
        {
            get { return (mProcess)List[index]; }
            set { List[index] = value; }
        }
    }
}
