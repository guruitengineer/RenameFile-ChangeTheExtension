namespace FileUtility
{
    partial class RenameFile
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.cntVal = new System.Windows.Forms.NumericUpDown();
            this.lblCounterStart = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cntVal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(197, 35);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(13, 35);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(178, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(197, 85);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // cntVal
            // 
            this.cntVal.Location = new System.Drawing.Point(136, 85);
            this.cntVal.Name = "cntVal";
            this.cntVal.Size = new System.Drawing.Size(55, 20);
            this.cntVal.TabIndex = 3;
            this.cntVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCounterStart
            // 
            this.lblCounterStart.AutoSize = true;
            this.lblCounterStart.Location = new System.Drawing.Point(14, 85);
            this.lblCounterStart.Name = "lblCounterStart";
            this.lblCounterStart.Size = new System.Drawing.Size(97, 13);
            this.lblCounterStart.TabIndex = 4;
            this.lblCounterStart.Text = "Enter Counter Start";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(95, 162);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RenameFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCounterStart);
            this.Controls.Add(this.cntVal);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "RenameFile";
            this.Text = "SelectFolder";
            ((System.ComponentModel.ISupportInitialize)(this.cntVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.NumericUpDown cntVal;
        private System.Windows.Forms.Label lblCounterStart;
        private System.Windows.Forms.Button btnBack;
    }
}

