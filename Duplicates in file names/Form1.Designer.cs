namespace Duplicates_in_file_names
{
    partial class Form1
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.selectedDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.selectedDirectoryLabel = new System.Windows.Forms.Label();
            this.fileNameTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(509, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // selectedDirectoryTextBox
            // 
            this.selectedDirectoryTextBox.Location = new System.Drawing.Point(113, 6);
            this.selectedDirectoryTextBox.Name = "selectedDirectoryTextBox";
            this.selectedDirectoryTextBox.ReadOnly = true;
            this.selectedDirectoryTextBox.Size = new System.Drawing.Size(390, 20);
            this.selectedDirectoryTextBox.TabIndex = 1;
            // 
            // selectedDirectoryLabel
            // 
            this.selectedDirectoryLabel.AutoSize = true;
            this.selectedDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this.selectedDirectoryLabel.Name = "selectedDirectoryLabel";
            this.selectedDirectoryLabel.Size = new System.Drawing.Size(95, 13);
            this.selectedDirectoryLabel.TabIndex = 2;
            this.selectedDirectoryLabel.Text = "Selected directory:";
            // 
            // fileNameTree
            // 
            this.fileNameTree.Location = new System.Drawing.Point(15, 35);
            this.fileNameTree.Name = "fileNameTree";
            this.fileNameTree.Size = new System.Drawing.Size(569, 432);
            this.fileNameTree.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 479);
            this.Controls.Add(this.fileNameTree);
            this.Controls.Add(this.selectedDirectoryLabel);
            this.Controls.Add(this.selectedDirectoryTextBox);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 517);
            this.MinimumSize = new System.Drawing.Size(842, 517);
            this.Name = "Form1";
            this.Text = "Duplicates in file names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox selectedDirectoryTextBox;
        private System.Windows.Forms.Label selectedDirectoryLabel;
        private System.Windows.Forms.TreeView fileNameTree;
    }
}

