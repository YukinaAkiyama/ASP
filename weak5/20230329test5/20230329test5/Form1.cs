using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230329test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

//如果combobox1中选到了“计算机学院”，则在combobox2添加以下内容“计算机科学与技术”、“智能科学”、“软件工程”
//如果combobox1中选到了“计算机学院”以外的项，则在combobox2中添加“未开放”
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "计算机学院")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("计算机科学与技术");
                comboBox2.Items.Add("智能科学");
                comboBox2.Items.Add("软件工程");
                comboBox2.Items.Add("电子商务");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("未开放");
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }
        
//如果combobox2中选到了“计算机科学与技术”，则在listbox1中添加以下内容“C语言程序设计”、“Python程序设计”、“计算机网络”、“数据结构”、“算法设计”、“计算机组成原理”
//如果combobox2中选到了“智能科学”，则在listbox1中添加以下内容“C语言程序设计”、“Python程序设计”、“操作系统”、“数据结构”、“JavaEE”、“线性代数”
//如果combobox2中选到了“软件工程”，则在listbox1中添加以下内容“C语言程序设计”、“Python程序设计”、“操作系统”、“数据挖掘”、“算法设计”、“计算机组成原理”
//如果combobox2中选到了“电子商务”，则在listbox1中添加以下内容“未开放”，并禁用button1、button2、button3、button4
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            if (comboBox2.SelectedItem.ToString() == "计算机科学与技术")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("C语言程序设计");
                listBox1.Items.Add("Python程序设计");
                listBox1.Items.Add("计算机网络");
                listBox1.Items.Add("数据结构");
                listBox1.Items.Add("算法设计");
                listBox1.Items.Add("计算机组成原理");
                listBox1.Items.Add("高等数学");

            }
            else if (comboBox2.SelectedItem.ToString() == "智能科学")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("C语言程序设计");
                listBox1.Items.Add("Python程序设计");
                listBox1.Items.Add("操作系统");
                listBox1.Items.Add("数据结构");
                listBox1.Items.Add("JavaEE");
                listBox1.Items.Add("线性代数");
                listBox1.Items.Add("JavaScript");
            }
            else if (comboBox2.SelectedItem.ToString() == "软件工程")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("C语言程序设计");
                listBox1.Items.Add("Python程序设计");
                listBox1.Items.Add("操作系统");
                listBox1.Items.Add("数据挖掘");
                listBox1.Items.Add("算法设计");
                listBox1.Items.Add("计算机组成原理");
                listBox1.Items.Add("计算机导论");
            }
            else if (comboBox2.SelectedItem.ToString() == "电子商务")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("未开放");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

//将listbox1中选中的一项移动到listbox2，如果选择了多项则提示，并重置listbox1中的选择
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if (listBox1.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一项进行移动！");
                listBox1.ClearSelected();
            }
        }

        
//将listbox2中选中的一项移动到listbox1，如果选择了多项则提示，并重置listbox2中的选择
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else if (listBox2.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一项进行移动！");
                listBox2.ClearSelected();
            }
        }

        
//将listbox1中选中的所有项移动到listbox2
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        
//将listbox2中选中的所有项移动到listbox1
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
            }
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }
    }
}
