using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Login += new Action<object, LoginModel>(Login);
        }

        private void Login(object arg1, LoginModel arg2)
        {
            if (arg2.UserName == "tinnkm" && arg2.Password == "888888")
            {
                arg2.IsLogin = true;
            }
        }
    }
}
