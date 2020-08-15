using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AffinityChanger
{
    public partial class ProcessManager : Form
    {
        Timer timer = new Timer();

        public ProcessManager()
        {
            InitializeComponent();

            // Load ListView with items from app cache

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            foreach (ListViewItem item in lstAddedProcesses.Items) {
                string rawPath = RemoveOkPath(item.Text); //To Remove Later
                if (VerifyIfOpen(rawPath))
                    item.Text = AddOkPath(item.Text);
                else
                    item.Text = RemoveOkPath(item.Text);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
            DialogResult result = ofdSelectedFile.ShowDialog();
            string path;

            if (result == DialogResult.OK)
            {
                path = ofdSelectedFile.FileName;
                ListViewItem item = new ListViewItem();
                item.Text = path;
                lstAddedProcesses.Items.Add(item);
            }
            
            // Save path to app cache

            timer.Start();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if(lstAddedProcesses.SelectedIndices.Count > 0)
                foreach(ListViewItem item in lstAddedProcesses.Items)
                    if (item.Selected)
                        item.Remove();

            // Remove selected from app cache
        }

        public bool VerifyIfOpen(string path)
        {
            foreach (Process proc in Process.GetProcesses())
                try
                {
                    if (proc.MainModule != null)
                        if (proc.MainModule.FileName == path)
                            return true;
                }
                catch (Exception ex)
                {
                    continue;
                }

            return false;
        }

        public string RemoveOkPath(string path)
        {
            if (path.Contains("(Open)"))
                return path.Replace("(Open)", "");

            return path;
        }

        public string AddOkPath(string path)
        {
            if (!path.Contains("(Open)"))
                return path + "(Open)";

            return path;
        }
    }
}
