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
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt,*.rtf)|*.txt;*.rtf|Pictrue Files (*.png,*.jgp)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog.FilterIndex == 1)
                {
                    Form2 form1 = new Form2(openFileDialog.FileName);
                    form1.MdiParent = this;
                    form1.Show();
                }
                else
                {
                    Pic form5 = new Pic(openFileDialog.FileName);
                    form5.MdiParent = this;
                    form5.Show();
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
