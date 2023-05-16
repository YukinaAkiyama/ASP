using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230331test2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        //打开form2，在form2关闭前，禁用form1
        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Enabled = false;
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }

        //启用form1
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }


        //打开form3，在form3关闭前，禁用form1
        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Enabled = false;
            form3.FormClosed += new FormClosedEventHandler(form3_FormClosed);
        }

        //启用form1
        private void form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }


        //退出程序
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
