﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230308test2
{
    public partial class Form1 : Form
    {
        int peaches = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str1 = textBox1.Text;
            int day = int.Parse(str1);
           

            for (int i = 1; i < day; i++)
            {
                peaches = peaches*2 + 1;
            }
            textBox2.Text = Convert.ToString(peaches);
            peaches = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
