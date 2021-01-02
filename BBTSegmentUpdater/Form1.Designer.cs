namespace BBTSegmentUpdater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "LiveSplit (*.LSS)|*.LSS|All files (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "LiveSplit File Browser";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Enabled = false;
            this.fileTextBox.Location = new System.Drawing.Point(93, 12);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(229, 23);
            this.fileTextBox.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 41);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(310, 145);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.openFileButton);
            this.Name = "Form1";
            this.Text = "BBT Segment Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}

