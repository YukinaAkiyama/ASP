namespace notepad
{
    partial class Child_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Child_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wenjian = new System.Windows.Forms.ToolStripMenuItem();
            this.XINJIANQ = new System.Windows.Forms.ToolStripMenuItem();
            this.DAKAI = new System.Windows.Forms.ToolStripMenuItem();
            this.BAOCUN = new System.Windows.Forms.ToolStripMenuItem();
            this.BianJi = new System.Windows.Forms.ToolStripMenuItem();
            this.Jiacu = new System.Windows.Forms.ToolStripMenuItem();
            this.Qinxie = new System.Windows.Forms.ToolStripMenuItem();
            this.CHAKNA = new System.Windows.Forms.ToolStripMenuItem();
            this.ZITI = new System.Windows.Forms.ToolStripComboBox();
            this.ZIHAO = new System.Windows.Forms.ToolStripComboBox();
            this.BANGZHU = new System.Windows.Forms.ToolStripMenuItem();
            this.GUANYU = new System.Windows.Forms.ToolStripMenuItem();
            this.GENGXIN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wenjian,
            this.BianJi,
            this.CHAKNA,
            this.BANGZHU,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wenjian
            // 
            this.wenjian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XINJIANQ,
            this.DAKAI,
            this.BAOCUN});
            this.wenjian.Image = global::notepad.Properties.Resources.folder_vertical_open;
            this.wenjian.Name = "wenjian";
            this.wenjian.Size = new System.Drawing.Size(73, 24);
            this.wenjian.Text = "文件";
            // 
            // XINJIANQ
            // 
            this.XINJIANQ.Image = global::notepad.Properties.Resources.folder_vertical_open;
            this.XINJIANQ.Name = "XINJIANQ";
            this.XINJIANQ.Size = new System.Drawing.Size(224, 26);
            this.XINJIANQ.Text = "新建";
            this.XINJIANQ.Click += new System.EventHandler(this.XINJIANQ_Click);
            // 
            // DAKAI
            // 
            this.DAKAI.Image = global::notepad.Properties.Resources.folder_vertical_open;
            this.DAKAI.Name = "DAKAI";
            this.DAKAI.Size = new System.Drawing.Size(224, 26);
            this.DAKAI.Text = "打开";
            this.DAKAI.Click += new System.EventHandler(this.XINJIAN_Click);
            // 
            // BAOCUN
            // 
            this.BAOCUN.Image = global::notepad.Properties.Resources.disk;
            this.BAOCUN.Name = "BAOCUN";
            this.BAOCUN.Size = new System.Drawing.Size(224, 26);
            this.BAOCUN.Text = "保存";
            this.BAOCUN.Click += new System.EventHandler(this.BAOCUN_Click);
            // 
            // BianJi
            // 
            this.BianJi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Jiacu,
            this.Qinxie,
            this.查找ToolStripMenuItem,
            this.替换ToolStripMenuItem});
            this.BianJi.Name = "BianJi";
            this.BianJi.Size = new System.Drawing.Size(53, 24);
            this.BianJi.Text = "编辑";
            // 
            // Jiacu
            // 
            this.Jiacu.Image = global::notepad.Properties.Resources.text_bold;
            this.Jiacu.Name = "Jiacu";
            this.Jiacu.Size = new System.Drawing.Size(224, 26);
            this.Jiacu.Text = "加粗";
            this.Jiacu.Click += new System.EventHandler(this.Jiacu_Click);
            // 
            // Qinxie
            // 
            this.Qinxie.Image = global::notepad.Properties.Resources.text_italic;
            this.Qinxie.Name = "Qinxie";
            this.Qinxie.Size = new System.Drawing.Size(224, 26);
            this.Qinxie.Text = "倾斜";
            this.Qinxie.Click += new System.EventHandler(this.Qinxie_Click);
            // 
            // CHAKNA
            // 
            this.CHAKNA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZITI,
            this.ZIHAO});
            this.CHAKNA.Name = "CHAKNA";
            this.CHAKNA.Size = new System.Drawing.Size(53, 24);
            this.CHAKNA.Text = "查看";
            // 
            // ZITI
            // 
            this.ZITI.Name = "ZITI";
            this.ZITI.Size = new System.Drawing.Size(121, 28);
            this.ZITI.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // ZIHAO
            // 
            this.ZIHAO.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "64",
            "128",
            "256"});
            this.ZIHAO.Name = "ZIHAO";
            this.ZIHAO.Size = new System.Drawing.Size(121, 28);
            this.ZIHAO.Text = "10";
            this.ZIHAO.Click += new System.EventHandler(this.ZIHAO_Click);
            // 
            // BANGZHU
            // 
            this.BANGZHU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GUANYU,
            this.GENGXIN});
            this.BANGZHU.Name = "BANGZHU";
            this.BANGZHU.Size = new System.Drawing.Size(53, 24);
            this.BANGZHU.Text = "帮助";
            // 
            // GUANYU
            // 
            this.GUANYU.Name = "GUANYU";
            this.GUANYU.Size = new System.Drawing.Size(224, 26);
            this.GUANYU.Text = "关于记事本";
            this.GUANYU.Click += new System.EventHandler(this.GUANYU_Click);
            // 
            // GENGXIN
            // 
            this.GENGXIN.Name = "GENGXIN";
            this.GENGXIN.Size = new System.Drawing.Size(224, 26);
            this.GENGXIN.Text = "更新内容";
            this.GENGXIN.Click += new System.EventHandler(this.GENGXIN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            this.toolStripMenuItem1.Visible = false;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(752, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel1.Text = "系统当前时间：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(752, 392);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.替换ToolStripMenuItem.Text = "替换";
            // 
            // Child_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Child_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Child_form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Child_form_FormClosed);
            this.Load += new System.EventHandler(this.Child_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wenjian;
        private System.Windows.Forms.ToolStripMenuItem BianJi;
        private System.Windows.Forms.ToolStripMenuItem Jiacu;
        private System.Windows.Forms.ToolStripMenuItem Qinxie;
        private System.Windows.Forms.ToolStripMenuItem CHAKNA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem DAKAI;
        private System.Windows.Forms.ToolStripMenuItem BAOCUN;
        private System.Windows.Forms.ToolStripMenuItem BANGZHU;
        private System.Windows.Forms.ToolStripMenuItem GUANYU;
        private System.Windows.Forms.ToolStripComboBox ZITI;
        private System.Windows.Forms.ToolStripComboBox ZIHAO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem XINJIANQ;
        private System.Windows.Forms.ToolStripMenuItem GENGXIN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
    }
}