using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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

                fileNamesManipulator.SetFileNames(Directory.GetFiles(folderBrowserDialog.SelectedPath));
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fileNameTree.Nodes.Clear();

            fileNamesManipulator.MatchWords();

            Dictionary<string, string[]> matches = fileNamesManipulator.GetMatches();

            foreach (KeyValuePair<string, string[]> match in matches)
            {
                TreeNode node = new TreeNode(match.Key);

                foreach (string fileName in match.Value)
                {
                    node.Nodes.Add(fileName);
                }

                fileNameTree.Nodes.Add(node);
            }

        }

        private void wordsToSearchNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            fileNamesManipulator.SetWordsToMatch(wordsToSearchNumericUpDown.Value);

        }
    }

}
