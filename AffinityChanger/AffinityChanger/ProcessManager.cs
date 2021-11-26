using AffinityChanger.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using AffinityChanger.Classes;

namespace AffinityChanger
{
    public partial class ProcessManager : Form
    {
        Timer timer = new Timer();
        RegistryKey startReg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        mProcesses procList = new mProcesses();

        public ProcessManager()
        {
            InitializeComponent();
            ofdSelectedFile.Filter = "Executable Files (*.exe)|*.exe";

            UpdateOptions(Cache.LoadOptions());

            // Load ListView with items from app cache

            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstAddedProcesses.Items) {
                string rawPath = RemoveOkPath(item.Text); //To Remove Later
                if (VerifyIfOpen(rawPath))
                    item.Text = AddOkPath(item.Text);
                else
                    item.Text = RemoveOkPath(item.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                procList.Add(new mProcess(path));
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

        public void UpdateOptions(AppSettings settings)
        {
            chkStartWindows.Checked = settings.win_start;
            chkHideTaskbar.Checked = settings.hide_taskbar;
            chkPromptExit.Checked = settings.prompt_exit;
        }

        #region Checkboxes Checked Change

        private void chkStartWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartWindows.Checked)
                startReg.SetValue("AffinityChanger", Application.ExecutablePath);
            else
                startReg.DeleteValue("AffinityChanger");

            SaveOptions();
        }

        private void chkHideTaskbar_CheckedChanged(object sender, EventArgs e)
        {
            SaveOptions();
        }

        private void chkPromptExit_CheckedChanged(object sender, EventArgs e)
        {
            SaveOptions();
        }

        #endregion

        #region Checkboxes Events

        public void SaveOptions()
        {
            Cache.SaveOptions(chkStartWindows.Checked.ToString(), chkHideTaskbar.Checked.ToString(),
                chkPromptExit.Checked.ToString());
        }

        private void ProcessManager_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (chkHideTaskbar.Checked)
                {
                    Hide();
                    trayIcon.Visible = true;
                }
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void ProcessManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chkPromptExit.Checked)
            {
                DialogResult result = MessageBox.Show("You are about to close the program, do you wish to continue?", "Window Closing", MessageBoxButtons.YesNo);
                if(result == DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
            }
        }

        #endregion
    }
}