namespace AffinityChanger
{
    partial class ProcessManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManager));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAddedProcesses = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ofdSelectedFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOptions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkHideTaskbar = new System.Windows.Forms.CheckBox();
            this.chkStartWindows = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkPromptExit = new System.Windows.Forms.CheckBox();
            this.tbOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Process";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAddedProcesses
            // 
            this.lstAddedProcesses.BackColor = System.Drawing.Color.Silver;
            this.lstAddedProcesses.ForeColor = System.Drawing.Color.Black;
            this.lstAddedProcesses.HideSelection = false;
            this.lstAddedProcesses.Location = new System.Drawing.Point(6, 62);
            this.lstAddedProcesses.Name = "lstAddedProcesses";
            this.lstAddedProcesses.Size = new System.Drawing.Size(357, 209);
            this.lstAddedProcesses.TabIndex = 1;
            this.lstAddedProcesses.UseCompatibleStateImageBehavior = false;
            this.lstAddedProcesses.View = System.Windows.Forms.View.List;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(240, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Process";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbOptions
            // 
            this.tbOptions.Controls.Add(this.tabPage1);
            this.tbOptions.Controls.Add(this.tabPage2);
            this.tbOptions.Location = new System.Drawing.Point(-4, -2);
            this.tbOptions.Name = "tbOptions";
            this.tbOptions.Padding = new System.Drawing.Point(0, 0);
            this.tbOptions.SelectedIndex = 0;
            this.tbOptions.Size = new System.Drawing.Size(377, 303);
            this.tbOptions.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lstAddedProcesses);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processes";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.chkPromptExit);
            this.tabPage2.Controls.Add(this.chkHideTaskbar);
            this.tabPage2.Controls.Add(this.chkStartWindows);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // chkHideTaskbar
            // 
            this.chkHideTaskbar.AutoSize = true;
            this.chkHideTaskbar.ForeColor = System.Drawing.Color.White;
            this.chkHideTaskbar.Location = new System.Drawing.Point(21, 42);
            this.chkHideTaskbar.Name = "chkHideTaskbar";
            this.chkHideTaskbar.Size = new System.Drawing.Size(102, 17);
            this.chkHideTaskbar.TabIndex = 1;
            this.chkHideTaskbar.Text = "Hide in TaskBar";
            this.chkHideTaskbar.UseVisualStyleBackColor = true;
            this.chkHideTaskbar.CheckedChanged += new System.EventHandler(this.chkHideTaskbar_CheckedChanged);
            // 
            // chkStartWindows
            // 
            this.chkStartWindows.AutoSize = true;
            this.chkStartWindows.ForeColor = System.Drawing.Color.White;
            this.chkStartWindows.Location = new System.Drawing.Point(21, 19);
            this.chkStartWindows.Name = "chkStartWindows";
            this.chkStartWindows.Size = new System.Drawing.Size(117, 17);
            this.chkStartWindows.TabIndex = 0;
            this.chkStartWindows.Text = "Start with Windows";
            this.chkStartWindows.UseVisualStyleBackColor = true;
            this.chkStartWindows.CheckedChanged += new System.EventHandler(this.chkStartWindows_CheckedChanged);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // chkPromptExit
            // 
            this.chkPromptExit.AutoSize = true;
            this.chkPromptExit.ForeColor = System.Drawing.Color.White;
            this.chkPromptExit.Location = new System.Drawing.Point(21, 65);
            this.chkPromptExit.Name = "chkPromptExit";
            this.chkPromptExit.Size = new System.Drawing.Size(94, 17);
            this.chkPromptExit.TabIndex = 2;
            this.chkPromptExit.Text = "Prompt on Exit";
            this.chkPromptExit.UseVisualStyleBackColor = true;
            this.chkPromptExit.CheckedChanged += new System.EventHandler(this.chkPromptExit_CheckedChanged);
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(369, 297);
            this.Controls.Add(this.tbOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcessManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priority Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessManager_FormClosing);
            this.Resize += new System.EventHandler(this.ProcessManager_Resize);
            this.tbOptions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstAddedProcesses;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog ofdSelectedFile;
        private System.Windows.Forms.TabControl tbOptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkHideTaskbar;
        private System.Windows.Forms.CheckBox chkStartWindows;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox chkPromptExit;
    }
}

