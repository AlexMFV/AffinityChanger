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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAddedProcesses = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ofdSelectedFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Process";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAddedProcesses
            // 
            this.lstAddedProcesses.BackColor = System.Drawing.Color.DimGray;
            this.lstAddedProcesses.ForeColor = System.Drawing.Color.White;
            this.lstAddedProcesses.HideSelection = false;
            this.lstAddedProcesses.Location = new System.Drawing.Point(12, 86);
            this.lstAddedProcesses.Name = "lstAddedProcesses";
            this.lstAddedProcesses.Size = new System.Drawing.Size(345, 199);
            this.lstAddedProcesses.TabIndex = 1;
            this.lstAddedProcesses.UseCompatibleStateImageBehavior = false;
            this.lstAddedProcesses.View = System.Windows.Forms.View.List;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(240, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Process";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(369, 297);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstAddedProcesses);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "ProcessManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstAddedProcesses;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog ofdSelectedFile;
    }
}

