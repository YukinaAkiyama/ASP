using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230310test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
        }
    }
}
