using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230331test1
{
    public partial class Form1 : Form
    {
        string filepath = "E:\\Pictures\\肖宫\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
//读取combobox1中显示的项，读取对应的图片文件，并显示在picturebox1中
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取选中项的文件名
            string fileName = comboBox1.SelectedItem.ToString();
            //拼接文件路径
            string filePath = filepath + fileName;
            //判断文件是否存在
            if (System.IO.File.Exists(filePath))
            {
                //将图片文件加载到picturebox1中
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //读取filepath目录下所有文件，并将文件名存入combobox1
            string[] files = System.IO.Directory.GetFiles(filepath);
            foreach (string file in files)
            {
                comboBox1.Items.Add(System.IO.Path.GetFileName(file));
            }
        }

        //显示上一张图片
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index > 0)
            {
                comboBox1.SelectedIndex = index - 1;
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
        }

        //显示下一张图片
        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index < comboBox1.Items.Count - 1)
            {
                comboBox1.SelectedIndex = index + 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }


        //停止计时
        private void button4_Click(object sender, EventArgs e)
        {
            //停止计时循环
            timer1.Stop();
        }
        
        //计时器每隔3秒循环显示下一张图片
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index < comboBox1.Items.Count - 1)
            {
                comboBox1.SelectedIndex = index + 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }
        
        //点击后开始计时，每隔3秒循环显示下一张图片
        private void button3_Click(object sender, EventArgs e)
        {
            //启动计时循环
            timer1.Start();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //读取textbox1中数据，将其设置为timer1的间隔时间
        private void button5_Click(object sender, EventArgs e)
        {
            int interval;
            if (int.TryParse(textBox1.Text, out interval))
            {
                timer1.Interval = interval*1000;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
