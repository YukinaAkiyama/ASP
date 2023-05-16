using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230322RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//打开本地rtf文件，并在textbox1中显示文件名，在richtextbox1中显示文件内容
        private void button4_Click(object sender, EventArgs e)        
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        

//将richtextbox中的内容保存
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "RTF文件|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Rtf);
            }
        }

//在richtextbox中查找textbox2中输入的内容，并用光标选中查找到的内容，每点击一次按钮就查找下一项
        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            int searchStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            int searchEnd = richTextBox1.Text.Length;
            int index = richTextBox1.Find(searchText, searchStart, searchEnd, RichTextBoxFinds.None);
            if (index != -1)
            {
                richTextBox1.Select(index, searchText.Length);
            }
            else
            {
                MessageBox.Show("未找到匹配项");
            }
        }
//将richtextbox中所有与textbox2中输入内容相同的内容，全都替换为textbox3中输入的内容
        private void button3_Click(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            string replaceText = textBox3.Text;
            int searchStart = 0;
            int searchEnd = richTextBox1.Text.Length;
            int index = richTextBox1.Find(searchText, searchStart, searchEnd, RichTextBoxFinds.None);
            while (index != -1)
            {
                richTextBox1.Select(index, searchText.Length);
                richTextBox1.SelectedText = replaceText;
                searchStart = index + replaceText.Length;
                if (searchStart < richTextBox1.Text.Length)
                {
                    index = richTextBox1.Find(searchText, searchStart, searchEnd, RichTextBoxFinds.None);
                }
                else
                {
                    index = -1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
