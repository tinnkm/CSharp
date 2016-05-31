using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning03
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login my =   new Login(loginAction);
            bool flag = my(textBox1.Text,textBox2.Text);
            if (flag)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private bool loginAction(string userName, string password)
        {
            if (userName == "tinnkm" && password == "tinnkm")
            {
                
                return true;
            }
            return false;
        }

    }

    public delegate bool Login(string name,string password);
}
