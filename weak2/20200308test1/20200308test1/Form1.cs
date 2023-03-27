using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200308test1
{

    public partial class Form1 : Form
    {
        int cost = 15;
        int multiple;
        float true_multiple;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            float weight = float.Parse(str1);

            if (0 <weight)
            {
                multiple = (int)(weight / 15);
                true_multiple = weight / 15;
                if (true_multiple > multiple)
                {
                    multiple += 1;
                }
                switch (multiple)
                {
                    case 1: 
                        textBox2.Text = Convert.ToString("5");
                        break;
                    case 2: 
                        textBox2.Text = Convert.ToString("9");
                        break;
                    case 3: 
                        textBox2.Text = Convert.ToString("12");
                        break;
                    case 4:
                        textBox2.Text = Convert.ToString("14");
                        break;
                    case 5:
                        textBox2.Text = Convert.ToString("15");
                        break;
                    default:
                        textBox2.Text = Convert.ToString("ERROR");
                        break;

                }
                if (multiple > 5)
                {
                    for (int i = 5; i <= multiple; i++)
                    {
                        cost += 1;
                    }
                    textBox2.Text = Convert.ToString(cost);
                }

                cost = 15;


                /*                Console.WriteLine(multiple.ToString());
                                Console.WriteLine(true_multiple.ToString());*/
            }
            else
            {
                textBox2.Text = Convert.ToString("重量小于0");
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
