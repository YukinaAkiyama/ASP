using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230329test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //在textbox1中显示“欢迎你来到Visual C#俱乐部！”，宋体，斜体，加粗，三号，禁用textbox1
            textBox1.Text = "欢迎你来到Visual C#俱乐部！";
            textBox1.Font = new Font("宋体", 18, FontStyle.Bold | FontStyle.Italic);
            textBox1.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
//选中radiobutton1时，将textbox1中字体设置为宋体
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Font = new Font("宋体", textBox1.Font.Size, textBox1.Font.Style);
            }
        }


//选中radiobutton2时，将textbox1中字体设置为隶书
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Font = new Font("隶书", textBox1.Font.Size, textBox1.Font.Style);
            }
        }


//选中radiobutton3时，将textbox1中字体设置为黑体
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Font = new Font("黑体", textBox1.Font.Size, textBox1.Font.Style);
            }
        }

//选中radiobutton4时，将textbox1中字体大小设置12
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 12, textBox1.Font.Style);
            }
        }


//选中radiobutton5时，将textbox1中字体大小设置18
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 18, textBox1.Font.Style);
            }
        }

//选中checkbox1时，将textbox1中字体风格设置为倾斜，取消选中时恢复为正常
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Italic);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Regular);
            }
        }

        
//选中checkbox2时，将textbox1中字体风格设置为加粗，取消选中时恢复为正常
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Regular);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
