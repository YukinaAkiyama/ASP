using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230412test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //以utf-8格式打开本地txt文件，以utf-8格式显示在richtextbox中
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                richTextBox1.Text = text;
            }
        }




        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //以utf-8格式保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = richTextBox1.Text;
                System.IO.File.WriteAllText(saveFileDialog.FileName, text, Encoding.UTF8);
            }
        }



        //以txt格式另存为richtextbox中的文件，utf-8格式
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = richTextBox1.Text;
                System.IO.File.WriteAllText(saveFileDialog.FileName, text, Encoding.UTF8);
            }
        }



//复制richtextbox中选中的内容
        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }



//剪切richtextbox中选中的内容
        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }


//粘贴到richtextbox光标处
        private void zhantieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }



        //修改richtextbox中内容的字体
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }


//修改richtextbox中字体的颜色
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }




        private void 查找ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 查找和替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
         private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "时间：" + DateTime.Now.ToString();
            int charCount = richTextBox1.Text.Length;
            this.toolStripStatusLabel2.Text = "字符数：" + charCount.ToString();
            //在toolStripStatusLabel3中显示“保存ToolStripMenuItem_Click”的使用状态，如果使用过则显示已保存，未使用过则显示未保存；当richtextbox中有内容更新时重置
            if (richTextBox1.Modified)
            {
                toolStripStatusLabel3.Text = "未保存";
            }
            else
            {
                toolStripStatusLabel3.Text = "已保存";
            }
        }

//将richtextbox背景设置为红色
        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }



        private void 黄色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

//关闭程序
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



//退出程序
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }


    }
}



