using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230308test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, m, k;
            for (i = 0; i <= 9; i++)//前两个数 
            {
                for (j = 0; j <= 9; j++)//后两个数 
                {
                    if (j != i)//这两个数不相等 
                    {
                        k = 1000 * i + 100 * i + j * 10 + j;//一个整数的平方 
                        for (m = 3; m * m <= k; m++)
                        {
                            if (m * m == k)
                            {
                                textBox1.Text=Convert.ToString("这个车牌号是"+k);
                            }
                        }
                    }
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
