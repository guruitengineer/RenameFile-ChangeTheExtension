namespace FileUtility
{
    partial class SelectTask
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
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.btnChangeExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Location = new System.Drawing.Point(75, 61);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(144, 23);
            this.btnRenameFiles.TabIndex = 0;
            this.btnRenameFiles.Text = "Rename Files";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // btnChangeExt
            // 
            this.btnChangeExt.Location = new System.Drawing.Point(75, 166);
            this.btnChangeExt.Name = "btnChangeExt";
            this.btnChangeExt.Size = new System.Drawing.Size(144, 23);
            this.btnChangeExt.TabIndex = 1;
            this.btnChangeExt.Text = "Change Extension";
            this.btnChangeExt.UseVisualStyleBackColor = true;
            this.btnChangeExt.Click += new System.EventHandler(this.btnChangeExt_Click);
            // 
            // SelectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnChangeExt);
            this.Controls.Add(this.btnRenameFiles);
            this.Name = "SelectTask";
            this.Text = "SelectTask";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.Button btnChangeExt;
    }
}