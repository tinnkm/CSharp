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
                TreeNode subnode = filetree.Nodes.Add(textBox1.Text.Substring(textBox1.Text.LastIndexOf(@"\") + 1));
                GetTree(subnode, textBox1.Text);
            }
        }

        private void GetTree(TreeNode nodes,string locattion)
        {
            string[] directorys = Directory.GetDirectories(locattion);
            if (directorys.Length > 0) { 
                foreach (var dir in directorys)
                {
                    TreeNode subnode = nodes.Nodes.Add(dir.Substring(dir.LastIndexOf(@"\") + 1));
                    GetTree(subnode, dir);
                }
            }
            
            string[] files = Directory.GetFiles(locattion);
            if (files.Length > 0) { 
                foreach (var file in files)
                {
                    nodes.Nodes.Add(file.Substring(file.LastIndexOf(@"\") + 1));
                }
            }
        }

       
    }
}
