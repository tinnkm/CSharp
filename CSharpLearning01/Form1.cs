using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                GetTree(filetree.Nodes, textBox1.Text);
            }
        }

        private void GetTree(TreeNodeCollection nodes,string locattion)
        {
            string[] directorys = Directory.GetDirectories(locattion);
            if (directorys.Length > 0) { 
                foreach (var dir in directorys)
                {
                    TreeNode subnode = nodes.Add(Path.GetFileName(dir));
                    GetTree(subnode.Nodes, dir);
                }
            }
            
            string[] files = Directory.GetFiles(locattion);
            if (files.Length > 0) { 
                foreach (var file in files)
                {
                    nodes.Add(Path.GetFileName(file));
                }
            }
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            string path = filetree.SelectedNode.FullPath;
            if (path.EndsWith("txt"))
            {
                string filepath = Path.Combine(textBox1.Text, path);
                showdetail.Text = File.ReadAllText(filepath);
            }
        }

       
    }
}
