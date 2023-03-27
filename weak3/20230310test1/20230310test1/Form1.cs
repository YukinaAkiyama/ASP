using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230310test1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "这里是C#实习基地";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            int width = ra.Next(Screen.PrimaryScreen.Bounds.Width - this.Width);
            int height = ra.Next(Screen.PrimaryScreen.Bounds.Height - this.Height);
            this.Location = new Point(width, height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您正在退出系统", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MessageBox.Show("欢迎下次再来", "再见");
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
