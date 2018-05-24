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

                fileNameTree.Nodes.Clear();
                //fileNamesManipulator.SetFileNames(Directory.GetFiles(folderBrowserDialog.SelectedPath));
                string[] mylist = { "element 1", "the second element", "this is the 3rd" };
                foreach (string element in mylist)
                {
                    string[] childrens = { "a", "b" };
                    TreeNode node = new TreeNode(element);

                    foreach (string children in childrens)
                    {
                        node.Nodes.Add(children);
                    }

                    fileNameTree.Nodes.Add(node);
                }
            }
        }
    }
}
