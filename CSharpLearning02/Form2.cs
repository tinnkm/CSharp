using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
        
            InitializeComponent();
        }

        private getText get;

        public Form2(string text,getText get):this()
        {
            textBox1.Text = text;
            this.get = get;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get(textBox1.Text);
            this.Close();
        }
    }
}
