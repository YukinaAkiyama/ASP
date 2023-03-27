using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// 双色球抽奖程序

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private CheckBox[] redCheckBoxes;
        private CheckBox[] blueCheckBoxes;
        private Label serlabel;

        // 添加代表红球和蓝球的checkbox
        public Form1()
        {
            InitializeComponent();
            redCheckBoxes = new CheckBox[33];
            blueCheckBoxes = new CheckBox[16];

            // 添加红球label
            Label redLabel = new Label();
            redLabel.Text = "红球";
            redLabel.Location = new Point(20, 20);
            this.Controls.Add(redLabel);


            // 生成红球checkbox
            for (int i = 0; i < 33; i++)
            {
                redCheckBoxes[i] = new CheckBox();
                redCheckBoxes[i].Text = (i + 1).ToString();
                redCheckBoxes[i].Location = new Point(20 + (i % 11) * 50, 40 + (i / 11) * 30);
                redCheckBoxes[i].Size = new Size(50, 30);
                redCheckBoxes[i].CheckedChanged += new EventHandler((sender, e) =>
                {
                    int count = 0;
                    foreach (CheckBox checkBox in redCheckBoxes)
                    {
                        if (checkBox.Checked)
                        {
                            count++;
                        }
                    }
                    if (count == 6)
                    {
                        foreach (CheckBox checkBox in redCheckBoxes)
                        {
                            if (!checkBox.Checked)
                            {
                                checkBox.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        foreach (CheckBox checkBox in redCheckBoxes)
                        {
                            checkBox.Enabled = true;
                        }
                    }
                });
                this.Controls.Add(redCheckBoxes[i]);
            }

            // 添加蓝球label
            Label blueLabel = new Label();
            blueLabel.Text = "蓝球";
            blueLabel.Location = new Point(20, 150);
            this.Controls.Add(blueLabel);


            // 生成蓝球checkbox
            for (int i = 0; i < 16; i++)
            {
                blueCheckBoxes[i] = new CheckBox();
                blueCheckBoxes[i].Text = (i + 1).ToString();
                blueCheckBoxes[i].Location = new Point(20 + (i % 11) * 50, 170 + (i / 11) * 30);
                blueCheckBoxes[i].Size = new Size(50, 30);
                blueCheckBoxes[i].CheckedChanged += new EventHandler((sender, e) =>
                {
                    foreach (CheckBox checkBox in blueCheckBoxes)
                    {
                        if (checkBox != sender)
                        {
                            checkBox.Enabled = !((CheckBox)sender).Checked;
                        }
                    }
                });
                this.Controls.Add(blueCheckBoxes[i]);
            }


            serlabel = new Label();
            serlabel.Location = new Point(20, 240);
            serlabel.Size = new Size(460, 60);
            this.Controls.Add(serlabel);

        }

        // 计算是否中奖
        private void button1_Click(object sender, EventArgs e)
        {
            int[] redBalls = new int[6];
            int blueBall = 0;
            int[] selectedRedBalls = new int[6];
            int selectedBlueBall = 0;
            int redCount = 0;
            int blueCount = 0;

            // 获取用户选择的红球号码
            for (int i = 0; i < 33; i++)
            {
                if (redCheckBoxes[i].Checked)
                {
                    selectedRedBalls[redCount] = i + 1;
                    redCount++;
                }
            }

            // 获取用户选择的蓝球号码
            for (int i = 0; i < 16; i++)
            {
                if (blueCheckBoxes[i].Checked)
                {
                    selectedBlueBall = i + 1;
                    blueCount++;
                }
            }

            // 如果用户选择的红球和蓝球数量不正确，提示用户重新选择
            if (redCount != 6 || blueCount != 1)
            {
                MessageBox.Show("请选择6个红球和1个蓝球");
                return;
            }

            // 随机生成中奖号码
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int redBall = random.Next(1, 34);
                while (redBalls.Contains(redBall))
                {
                    redBall = random.Next(1, 34);
                }
                redBalls[i] = redBall;
            }
            blueBall = random.Next(1, 17);

            serlabel.Text = "本期中奖号码为：" + string.Join(",", redBalls) + "（红球）" + blueBall + "（蓝球）";

            // 判断是否中奖
            int redMatchCount = selectedRedBalls.Intersect(redBalls).Count();
            bool blueMatch = selectedBlueBall == blueBall;

            serlabel.Text += "\n您选择的号码为：" + string.Join(",", selectedRedBalls) + "（红球）" + selectedBlueBall + "（蓝球）";

            if (redMatchCount == 6 && blueMatch)
            {
                serlabel.Text += "\n红球全部匹配，蓝球匹配";
            }
            else if (redMatchCount == 6)
            {
                serlabel.Text += "\n红球全部匹配，蓝球不匹配";
            }
            else if (redMatchCount == 5 && blueMatch)
            {
                serlabel.Text += "\n红球5个匹配，蓝球匹配";
            }
            else if (redMatchCount == 5 || (redMatchCount == 4 && blueMatch))
            {
                serlabel.Text += "\n红球4个匹配，蓝球匹配或不匹配";
            }
            else if (redMatchCount == 4 || (redMatchCount == 3 && blueMatch))
            {
                serlabel.Text += "\n红球3个匹配，蓝球匹配或不匹配";
            }
            else
            {
                serlabel.Text += "\n红球匹配个数不足3个";
            }

            if (redMatchCount == 6 && blueMatch)
            {
                serlabel.Text += "\n恭喜您中了一等奖！";
            }
            else if (redMatchCount == 6)
            {
                serlabel.Text += "\n恭喜您中了二等奖！";
            }
            else if (redMatchCount == 5 && blueMatch)
            {
                serlabel.Text += "\n恭喜您中了三等奖！";
            }
            else if (redMatchCount == 5 || (redMatchCount == 4 && blueMatch))
            {
                serlabel.Text += "\n恭喜您中了四等奖！";
            }
            else if (redMatchCount == 4 || (redMatchCount == 3 && blueMatch))
            {
                serlabel.Text += "\n恭喜您中了五等奖！";
            }
            else
            {
                serlabel.Text += "\n很遗憾，您没有中奖。";
            }
        }

        // 自动选球功能
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> redBalls = new List<int>();
            List<int> blueBalls = new List<int>();
            while (redBalls.Count < 6)
            {
                int redBall = random.Next(1, 34);
                if (!redBalls.Contains(redBall))
                {
                    redBalls.Add(redBall);
                }
            }
            while (blueBalls.Count < 1)
            {
                int blueBall = random.Next(1, 17);
                if (!blueBalls.Contains(blueBall))
                {
                    blueBalls.Add(blueBall);
                }
            }
            foreach (CheckBox checkBox in redCheckBoxes)
            {
                if (redBalls.Contains(int.Parse(checkBox.Text)))
                {
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.Checked = false;
                }
            }
            foreach (CheckBox checkBox in blueCheckBoxes)
            {
                if (checkBox.Checked) checkBox.Checked = false;
            }
            foreach (CheckBox checkBox in blueCheckBoxes)
            {
                if (blueBalls.Contains(int.Parse(checkBox.Text)))
                {
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.Checked = false;
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
