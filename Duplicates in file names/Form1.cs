using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Duplicates_in_file_names
{
    public partial class Form1 : Form
    {
        FileNamesManipulator fileNamesManipulator = new FileNamesManipulator();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
                fileNamesManipulator.SetSelectedPath(folderBrowserDialog.SelectedPath);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fileNameTree.Nodes.Clear();

            if (fileNamesManipulator.IsPathSelected())
            {
                if (searchDuplicatesBackgroundWorker.IsBusy != true)
                {
                    searchDuplicatesBackgroundWorker.RunWorkerAsync();
                }

            }
            else
            {
                fileNameTree.Nodes.Add("Select a directory");
            }
            

        }

        private void wordsToSearchNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            fileNamesManipulator.SetWordsToMatch(wordsToSearchNumericUpDown.Value);

        }

        private void caseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fileNamesManipulator.SetCaseSensitivity(caseSensitiveCheckBox.Checked);
        }

        private void searchDuplicatesBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            fileNamesManipulator.Refresh();
            fileNamesManipulator.MatchWords();
        }

        private void searchDuplicatesBackgroundWorker__RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dictionary<string, List<string>> matches = fileNamesManipulator.GetMatches();

            if (matches.Count > 0)
            {
                foreach (KeyValuePair<string, List<string>> match in matches)
                {
                    TreeNode node = new TreeNode(match.Key);

                    foreach (string fileName in match.Value)
                    {
                        node.Nodes.Add(fileName);
                    }

                    fileNameTree.Nodes.Add(node);
                }
            }
            else
            {
                fileNameTree.Nodes.Add("No duplicates have been found.");
            }
        }
        
    }

}
