using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230308test3
{
    public partial class Form1 : Form
    {
        int func_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Font = new Font("Microsoft Sans Serif", 14);
            listBox1.Items.Add("百元买百鸡：\n");
            for (int i = 0; i < 20; i++)     //公鸡最多只能有19只
            {
                for (int j = 0; j < 33; j++)  //母鸡最多有32只
                {
                    if ((100 - i - j) % 3 == 0 && i * 5 + j * 3 + (100 - i - j) / 3 == 100)  //满足花百钱，鸡百只输出
                    {
                        func_num+=1;
                        Console.WriteLine("公鸡有{0},母鸡有{1},小鸡有{2}", i, j, 100 - i - j);
                        listBox1.Items.Add("方案"+func_num+"：公鸡有" + i + "只,母鸡有" + j + "只,小鸡有" + (100 - i - j) + "只\n");
                    }
                }
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
