using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230412test1
{
    public partial class Form1 : Form
    {

        string [] filepathes;
        string filepath;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }


        //在label1中动态显示当前系统时间，格式为yyyy-MM-dd HH:mm:ss
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }


        //点一下picturebox1就启动计时器timer1，再点一下就暂停
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                DialogResult result = MessageBox.Show("确认暂停吗？", "确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    timer1.Stop();
                    // do something
                }
                else
                {
                    timer1.Start();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("确认开始吗？", "确认", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    timer1.Start();
                    // do something
                }
                else
                {
                    timer1.Stop();
                }
            }
        }






        //打开本地文件夹，读取一个目录，将目录保存到filepath
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog.SelectedPath;
                filepathes = System.IO.Directory.GetFiles(filepath);
            }
            if (System.IO.File.Exists(filepathes[0]))
            {
                //将图片文件加载到picturebox1中
                pictureBox1.Image = Image.FromFile(filepathes[0]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //循环显示filepathes中下一张图片
            pictureBox1.Image = Image.FromFile(filepathes[index]);
            index++;
            if (index >= filepathes.Length)
            {
                index = 0;
            }
        }

        //循环显示filepathes中图片
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(filepathes[index]);
            index++;
            if (index >= filepathes.Length)
            {
                index = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
