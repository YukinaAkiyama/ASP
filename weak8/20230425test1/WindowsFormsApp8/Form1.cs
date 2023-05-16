using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string FileName;
        public static Form1 form1 = null;
        public Form1(string FileName)
        {
            InitializeComponent();
            form1 = this;
            this.FileName = FileName;
            richTextBox1.LoadFile(FileName, RichTextBoxStreamType.RichText);
            toolStripStatusLabel2.Text = "文件名：" + FileName;
            richTextBox1_TextChanged(new object(), new EventArgs());
        }

        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF文件|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileName = sfd.FileName;
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
            }
            richTextBox1.Clear();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RTF文件|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
            }
            toolStripStatusLabel2.Text = "文件名：" + FileName;
            richTextBox1_TextChanged(sender, EventArgs.Empty);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(FileName, RichTextBoxStreamType.RichText);
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF文件|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            保存ToolStripMenuItem_Click(sender, e);
            FileName = "";
            richTextBox1.Clear();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
            else
            {
                粘贴ToolStripMenuItem.Enabled = false;
            }
        }


        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchfrom = new SearchForm();
            searchfrom.Show();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceForm replacefrom = new ReplaceForm();
            replacefrom.Show();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();


            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }

        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            打开ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            保存ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            另存为ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            复制ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            剪切ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            粘贴ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            查找ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            替换ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            关闭ToolStripMenuItem_Click(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "总字数：" + richTextBox1.Text.Length;
        }


    }
}
