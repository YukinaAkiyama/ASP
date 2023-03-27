using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230308test5
{
    public partial class Form1 : Form
    {

        public int a;
        public int b;
        public int c;
        public string option;
        public float result;
        public string problem;
        public double all_problems = 0.0;
        public double right_problems = 0.0;
        public double Accuracy_rate;
        public Form1()
        {
            InitializeComponent();
           textBox1.Text = Convert.ToString(problems_make());

        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            all_problems = 0.0;
            right_problems = 0.0;
            listBox1.Items.Clear();
            textBox1.Text = Convert.ToString(problems_make());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text;
            float answer = float.Parse(str1);
            string str2;
            if (answer == result)
            {
                str2 = "正确";
                right_problems++; 
            }
            else
            {
                str2 = "错误";
            }
            string str3 = problem +"="+ answer + "    " + str2;
            listBox1.Items.Add(str3);
            textBox1.Text = Convert.ToString(problems_make());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accuracy_rate = right_problems/all_problems;
            double sorce = 100 * Accuracy_rate;
            string str1 = "你总共完成了" + all_problems + "题，正确题目数：" + right_problems + "错误题目数：" + (all_problems - right_problems);
            string str2 = "得分：" + sorce;
            listBox1.Items.Add(str1);
            listBox1.Items.Add(str2);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private string problems_make()
        {
            all_problems++;
            Random random = new Random();
            a = random.Next(9);
            b = random.Next(9);
            c = random.Next(4);
            switch (c)
            {
                case 1:
                    {
                        option = "+";
                        result = a + b ;
                        problem = a + "+" + b;
                    }break;
                case 2:
                    {
                        option = "-";
                        result = a - b ;
                        problem = a + "-" + b;
                    }
                    break;
                case 3:
                    {
                        option = "/";
                        result = a * b ;
                        problem = a + "/" + b;
                    }
                    break;
                case 4:
                    {
                        option = "*";
                        result = a * b ;
                        problem = a + "*" + b;
                    }
                    break;
            }
            return problem;
        }
    }
}
