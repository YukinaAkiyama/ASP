using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections;
using System.IO;

namespace notepad
{
    public partial class Child_form : Form
    {
        public Child_form()
        {
            InitializeComponent();
        }




        private void XINJIAN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("文本文档(*.txt | *.txt");
            //判断打开还是取消
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取打开路径
                string path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                //读取数据流
                string text = sr.ReadToEnd();
                textBox1.Text = text;
                this.Text = path;
                toolStripMenuItem1.Text = "";
                sr.Close();
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string fontname = ZITI.Text;
            float fontsize = float.Parse(ZIHAO.Text);
            textBox1.Font = new Font(fontname, fontsize);

        }

        private void Child_form_Load(object sender, EventArgs e)
        {
            //窗体加载时，加载字体
            InstalledFontCollection myfpnts = new InstalledFontCollection();
            //获取InstalledFontCollection对象数据
            FontFamily[] ff = myfpnts.Families;
            //声明一个ArrayList变量
            ArrayList list = new ArrayList();
            //获取系统数组的列表集合的长度
            int count = ff.Length;
            for (int i = 0; i < count; i++)
            {
                string fontname = ff[i].Name;
                ZITI.Items.Add(fontname);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = "*";

        }

        private void Jiacu_Click(object sender, EventArgs e)
        {
            //点击按钮加粗，再次点击取消

            if (textBox1.Font.Bold == false)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            }


        }

        private void Qinxie_Click(object sender, EventArgs e)
        {
            if (textBox1.Font.Italic == false)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            }
        }

        private void ZIHAO_Click(object sender, EventArgs e)
        {
            string fontname = ZITI.Text;
            float fontsize = float.Parse(ZIHAO.Text);
            textBox1.Font = new Font(fontname, fontsize);
        }

        private void BAOCUN_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = "";
            if (textBox1.Text.Trim() != "")
            {
                //保存
                if (this.Text == "")
                {
                    saveFileDialog1.Filter = ("文本文档（*.txt|*.txt");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //保存文件到指定位置
                        //获取文件及路径
                        string path = saveFileDialog1.FileName;
                        //保存到路径
                        StreamWriter sw = new StreamWriter(path, false);
                        sw.WriteLine(textBox1.Text.Trim());
                        this.Text = path;
                        sw.Flush();
                        sw.Close();

                    }

                }
                else
                {
                    string path = this.Text;
                    //保存到路径
                    StreamWriter sw = new StreamWriter(path, false);
                    sw.WriteLine(textBox1.Text.Trim());
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("空文档不能保存", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Child_form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void XINJIANQ_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            toolStripMenuItem1.Text = "";
            this.Text = "";
        }

        private void Child_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolStripMenuItem1.Text == "*")
            {
                DialogResult dr = MessageBox.Show("文档尚未保存，确认要继续退出吗？",
                    "信息询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Dispose();

                }
                else
                {
                    e.Cancel = true;

                }
            }
        }

        private void GUANYU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("好好好");
        }

        private void GENGXIN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("回来吧我的C#\n" +
                "我最骄傲的信仰\n" + 
                "历历在目的VS\n"+
                "眼泪莫名在流淌\n"+
                "");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "系统当前时间：" +DateTime.Now.ToString();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
