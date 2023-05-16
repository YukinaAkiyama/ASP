using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230329test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//使textbox1中只能输入整形
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int result))
            {
                textBox1.Text = "";
            }
        }


//获取textbox1中输入的整形n，依据这个整形，在datagridview1中以“评委n”格式，在第一列写入n行
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                dataGridView1.Rows.Clear();
                for (int i = 1; i <= n; i++)
                {
                    dataGridView1.Rows.Add($"评委{i}");
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
//获取datagridview1中的数据，去掉一个最高分去掉一个最低分，在textbox2中输出剩下的评委对应分数，以及最终平均分
        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;
            int[] scores = new int[n-1];
            for (int i = 0; i < (n-1); i++)
            {
                scores[i] = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            Array.Sort(scores);
            int sum = 0;
            for (int i = 1; i < n - 1; i++)
            {
                sum += scores[i];
            }
            double avg = (double)sum / (n - 2);
            textBox2.Text = "";
            for (int i = 0; i < (n-1); i++)
            {
                if (i != 0)
                {
                    textBox2.Text += "\r\n";
                }
                textBox2.Text += $"评委{i + 1}的分数：{scores[i]}";
            }
            textBox2.Text += $"\r\n\r\n最终平均分：{avg:F2}";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
