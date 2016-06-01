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

        public event Action<object, LoginModel> Login;
        private void login_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = new LoginModel();
            loginModel.UserName = textBox1.Text;
            loginModel.Password = textBox2.Text;
            Login(this, loginModel);
            if (loginModel.IsLogin)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

    }

    
 
}
