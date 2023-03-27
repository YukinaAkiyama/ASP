using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230310test3
{
    public partial class Form1 : Form
    {
        public string str1;
        public string str2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 += str1[i];
            }
            textBox4.Text = Convert.ToString(this.str2);
            str2 = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = textBox3.SelectionStart;
            str1 = "";
            str1 = textBox3.SelectedText;
            int length = str1.Length;
            textBox2.Text = Convert.ToString(length);
            textBox1.Text = Convert.ToString(start);
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
