using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230331test2
{
    public partial class Form2 : Form
    {
        string[] name;
        string[] scores;
        // 创建一个 OpenFileDialog 对象
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();
            textBox2.Text = "博学而笃志\n切问而近思\n仁在其中矣";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //调用openFileDialog1，读取选中的csv文件，将第一列存放到name中，第二列存放到scores中，并在textbox1中显示第一列第一项
        private void button1_Click(object sender, EventArgs e)
        {
            // 设置文件类型
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            // 如果选中了文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 读取文件内容
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                // 初始化 name 和 scores 数组
                name = new string[lines.Length];
                scores = new string[lines.Length];

                // 将第一列存放到 name 中，第二列存放到 scores 中
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    name[i] = fields[0];
                    scores[i] = fields[1];
                }

                // 在 textbox1 中显示第一列第一项
                textBox1.Text = name[0];
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //在textbox1中开始随机显示数组member_name中内容，间隔为0.05秒
        private  void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //停止计时，并显示当前内容于textbox1
        private void button3_Click(object sender, EventArgs e)
        {
            // 停止计时器
            timer1.Stop();
         }

        //获取textbox1中name数组下标，将scores该下标的值加10，并在csv文件中做出相应更改
        private void button4_Click(object sender, EventArgs e)
        {
            // 获取当前选中的 name 数组下标
            int index = Array.IndexOf(name, textBox1.Text);

            // 如果找到了对应的下标
            if (index != -1)
            {
                // 将 scores 该下标的值加 10
                scores[index] = (int.Parse(scores[index]) + 10).ToString();

                // 将更改后的内容以utf-8格式写入 csv 文件
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        writer.WriteLine(name[i] + "," + scores[i]);
                    }
                }
            }
            //显示当前分数
            textBox3.Text = name[index] + "  当前分数为：" + scores[index];
        }

        //获取textbox1中name数组下标，将scores该下标的值加5，并在csv文件中做出相应更改
        private void button5_Click(object sender, EventArgs e)
        {
            // 获取当前选中的 name 数组下标
            int index = Array.IndexOf(name, textBox1.Text);

            // 如果找到了对应的下标
            if (index != -1)
            {
                // 将 scores 该下标的值加 10
                scores[index] = (int.Parse(scores[index]) + 5).ToString();

                // 将更改后的内容以utf-8格式写入 csv 文件
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        writer.WriteLine(name[i] + "," + scores[i]);
                    }
                }
            }
            //显示当前分数
            textBox3.Text = name[index] + "  当前分数为：" + scores[index];
        }

        //获取textbox1中name数组下标，将scores该下标的值减10，并在csv文件中做出相应更改
        private void button6_Click(object sender, EventArgs e)
        {
            // 获取当前选中的 name 数组下标
            int index = Array.IndexOf(name, textBox1.Text);

            // 如果找到了对应的下标
            if (index != -1)
            {
                // 将 scores 该下标的值加 10
                scores[index] = (int.Parse(scores[index]) - 10).ToString();

                // 将更改后的内容以utf-8格式写入 csv 文件
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        writer.WriteLine(name[i] + "," + scores[i]);
                    }
                }
            }
            //显示当前分数
            textBox3.Text = name[index] + "  当前分数为：" + scores[index];
        }

        //获取textbox1中name数组下标，将scores该下标的值减5，并在csv文件中做出相应更改
        private void button7_Click(object sender, EventArgs e)
        {
            // 获取当前选中的 name 数组下标
            int index = Array.IndexOf(name, textBox1.Text);

            // 如果找到了对应的下标
            if (index != -1)
            {
                // 将 scores 该下标的值加 10
                scores[index] = (int.Parse(scores[index]) -5).ToString();

                // 将更改后的内容以utf-8格式写入 csv 文件
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        writer.WriteLine(name[i] + "," + scores[i]);
                    }
                }
            }
            //显示当前分数
            textBox3.Text = name[index] + "  当前分数为：" + scores[index];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = name[random.Next(name.Length)].ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
