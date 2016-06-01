using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using CSharpLearning04.Model;

namespace CSharpLearning04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument document = null;
            XElement element = null;
            try
            {
                document = XDocument.Load("UserInfo.xml");
                element = document.Root;
            }
            catch
            {
                document = new XDocument();
            }
            finally
            {
                if (element == null)
                {
                    element = new XElement("userInfo");
                    document.Add(element);
                }
                int id = int.Parse(AddId.Text);
                string userName = AddName.Text;
                string password = AddPassword.Text;
                XElement elementById = document.XPathSelectElement("/userInfo/person[@id='" + id + "']");
                if (elementById == null)
                {
                    elementById = new XElement("person");
                    elementById.SetAttributeValue("id", id);
                    elementById.Add(new XElement("userName", userName));
                    elementById.Add(new XElement("password", password));
                    Person person = new Person(id, userName,password);
                    GetValue(id.ToString(), userName, password);
                    document.Save("UserInfo.xml");
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("ID已存在!");
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument document = null;
            try
            {
                document = XDocument.Load("UserInfo.xml");
                XElement element = document.Root;
                IEnumerable<XElement> subElements = element.Elements();
                foreach (XElement subElement in subElements)
                {
                    string id = subElement.Attribute("id").Value;

                    string userName = subElement.Element("userName").Value;
                    string password = subElement.Element("password").Value;
                    GetValue(id, userName, password);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("用户文件不存在！");
                Application.Exit();
            }
        }

        private void GetValue(string id, string userName, string password)
        {
            listView1.BeginUpdate();
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(userName);
            lvi.SubItems.Add(password);
            listView1.Items.Add(lvi);
            listView1.EndUpdate();
        }



        private void Selected(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

            }

        }

    }
}
