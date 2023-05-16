using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class SearchForm : Form
    {
        private int start = 0;
        public RichTextBox richTextBox = null;
        public SearchForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            richTextBox = Form1.form1.richTextBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string findText = textBox1.Text;
            richTextBox.Find(findText, start, richTextBox.TextLength, RichTextBoxFinds.None);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string findText = textBox1.Text;
            richTextBox.Find(findText, start, richTextBox.TextLength, RichTextBoxFinds.None);
            start = richTextBox.Text.IndexOf(findText, start) + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
