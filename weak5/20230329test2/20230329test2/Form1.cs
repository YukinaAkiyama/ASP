using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230329test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//获取textbox1（账号）和textbox2（密码）中的数据；正确的账号为 abc，密码为123456，输入正确则提示成功，输入错误则清除textbox2；你有三次机会，三次过后则禁用button1
        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBox1.Text;
            string password = textBox2.Text;
            if (account == "abc" && password == "123456")
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("账号或密码错误！");
                if (button1.Tag == null)
                {
                    button1.Tag = 1;
                }
                else
                {
                    button1.Tag = (int)button1.Tag + 1;
                }
                if ((int)button1.Tag == 3)
                {
                    button1.Enabled = false;
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

//在浏览器中打开 https://ssl.zc.qq.com/v3/index-chs.html
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ssl.zc.qq.com/v3/index-chs.html");
        }
    }
}
