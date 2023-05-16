using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230322test1
{
    public partial class Form1 : Form
    {
        int ArrLength;
        int ArrLength2;
        int GridRows;
        int GridColumns;


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void 写入数据_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[,] mystr = {
                { "张三", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "李四", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "王五", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "陈睿", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "丁真", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "蔡徐坤", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "孙笑川", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "谷爱凌", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() },
                { "张祺", random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString(), random.Next(0,100).ToString() }
            };
            ArrLength = mystr.GetLength(0);
            ArrLength2 = mystr.GetLength(1);
            for (int i = 0; i < ArrLength; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = mystr[i, 0];
                this.dataGridView1.Rows[index].Cells[1].Value = mystr[i, 1];
                this.dataGridView1.Rows[index].Cells[2].Value = mystr[i, 2];
                this.dataGridView1.Rows[index].Cells[3].Value = mystr[i, 3];
                this.dataGridView1.Rows[index].Cells[4].Value = mystr[i, 4];

            }
            GridRows = int.Parse(dataGridView1.Rows.Count.ToString());
            GridColumns = int.Parse(dataGridView1.Columns.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows[GridRows-1].Cells[0].Value = "课程班平均分";
            int i;
            int j;
            int TotalScore = 0;
            double ArgScore;
            for (i = 1; i < (GridColumns-1); i++)
            {
                for (j = 0; j < (GridRows-1); j++)
                {
                    String Score = dataGridView1.Rows[j].Cells[i].Value.ToString();
                    TotalScore += int.Parse(Score);
                }
                ArgScore = TotalScore / (GridRows-1);
                this.dataGridView1.Rows[GridRows-1].Cells[i].Value = ArgScore;
                TotalScore = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            int TotalScore = 0;
            double ArgScore;
            for (i = 0; i < GridRows-1; i++)
            {
                for(j = 1; j < GridColumns-1; j++)
                {
                    String Score = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    TotalScore += int.Parse(Score);
                }
                ArgScore = TotalScore / (j-1);
                this.dataGridView1.Rows[i].Cells[j].Value = ArgScore;
                TotalScore = 0;
            }
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);

        }
    }
}
