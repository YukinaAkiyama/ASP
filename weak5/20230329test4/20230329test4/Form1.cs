using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230329test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //在listbox1中查找与textbox1中相同的项，并选中
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            int index = listBox1.FindString(search);
            if (index != -1)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("未找到匹配项");
            }
        }
        
        //在listbox1中选中的项下方添加textbox2中的内容
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex + 1, textBox2.Text);
            }
            else
            {
                MessageBox.Show("请先选择要添加的位置");
            }
        }



        /*让listbox1单列显示*/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = false;
        }

        /*让listbox1双列显示*/

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
        }

        //删除listbox1中选中的项
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("请先选择要删除的项");
            }
        }
        
        //清除listbox1中所有内容
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
