using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp8
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
        }

        private void CarGame_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((GetKeyState(0x57) & 0x8000) != 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }

            if ((GetKeyState(0x53) & 0x8000) != 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }

            if ((GetKeyState(0x41) & 0x8000) != 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }

            if ((GetKeyState(0x44) & 0x8000) != 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }

            // 碰撞检测
            if (pictureBox1.Location.Y < 0 || pictureBox1.Location.Y > this.Size.Height - pictureBox1.Height || pictureBox1.Location.X < 0 || pictureBox1.Location.X > this.Size.Width - pictureBox1.Width)
            {
                timer1.Enabled = false;
                MessageBox.Show("碰到了墙壁!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                timer1.Enabled = true;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
        public static extern short GetKeyState(int keyCode);

        private void CarGame_Load(object sender, EventArgs e)
        {

        }
    }
}
