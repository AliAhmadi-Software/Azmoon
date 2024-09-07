namespace Azmoon_System
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.M0 = new System.Windows.Forms.ToolStripMenuItem();
            this.M00 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.M01 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.M02 = new System.Windows.Forms.ToolStripMenuItem();
            this.M1 = new System.Windows.Forms.ToolStripMenuItem();
            this.M2 = new System.Windows.Forms.ToolStripMenuItem();
            this.M3 = new System.Windows.Forms.ToolStripMenuItem();
            this.M4 = new System.Windows.Forms.ToolStripMenuItem();
            this.M40 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.M41 = new System.Windows.Forms.ToolStripMenuItem();
            this.M5 = new System.Windows.Forms.ToolStripMenuItem();
            this.M6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M0,
            this.M1,
            this.M2,
            this.M3,
            this.M4,
            this.M5,
            this.M6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // M0
            // 
            this.M0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M00,
            this.toolStripMenuItem1,
            this.M01,
            this.toolStripMenuItem2,
            this.M02});
            this.M0.Name = "M0";
            this.M0.Size = new System.Drawing.Size(75, 20);
            this.M0.Text = "عملیات پایه";
            // 
            // M00
            // 
            this.M00.Name = "M00";
            this.M00.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.M00.Size = new System.Drawing.Size(229, 22);
            this.M00.Text = "گروه امتحانی";
            this.M00.Click += new System.EventHandler(this.M00_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // M01
            // 
            this.M01.Name = "M01";
            this.M01.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.M01.Size = new System.Drawing.Size(229, 22);
            this.M01.Text = "مدیریت سوالات";
            this.M01.Click += new System.EventHandler(this.M01_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // M02
            // 
            this.M02.Name = "M02";
            this.M02.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.M02.Size = new System.Drawing.Size(229, 22);
            this.M02.Text = "تعیین زمان برای سوالات";
            this.M02.Click += new System.EventHandler(this.M02_Click);
            // 
            // M1
            // 
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(57, 20);
            this.M1.Text = "مدیریت";
            this.M1.Click += new System.EventHandler(this.M1_Click);
            // 
            // M2
            // 
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(84, 20);
            this.M2.Text = "برگزاری آزمون";
            this.M2.Click += new System.EventHandler(this.M2_Click);
            // 
            // M3
            // 
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(172, 20);
            this.M3.Text = "پشتیبان گیری و بازیابی اطلاعات";
            this.M3.Click += new System.EventHandler(this.M3_Click);
            // 
            // M4
            // 
            this.M4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M40,
            this.toolStripMenuItem3,
            this.M41});
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(60, 20);
            this.M4.Text = "گزارشات";
            // 
            // M40
            // 
            this.M40.Name = "M40";
            this.M40.Size = new System.Drawing.Size(143, 22);
            this.M40.Text = "لیست سوالات";
            this.M40.Click += new System.EventHandler(this.M40_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 6);
            // 
            // M41
            // 
            this.M41.Name = "M41";
            this.M41.Size = new System.Drawing.Size(143, 22);
            this.M41.Text = "تعداد سوالات";
            this.M41.Click += new System.EventHandler(this.M41_Click);
            // 
            // M5
            // 
            this.M5.Name = "M5";
            this.M5.Size = new System.Drawing.Size(48, 20);
            this.M5.Text = "راهنما";
            this.M5.Click += new System.EventHandler(this.M5_Click);
            // 
            // M6
            // 
            this.M6.Name = "M6";
            this.M6.Size = new System.Drawing.Size(44, 20);
            this.M6.Text = "خروج";
            this.M6.Click += new System.EventHandler(this.M6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblDay);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(476, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 388);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.BackColor = System.Drawing.Color.Transparent;
            this.LblDay.Font = new System.Drawing.Font("0 Badr Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblDay.ForeColor = System.Drawing.Color.Red;
            this.LblDay.Location = new System.Drawing.Point(141, 10);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(0, 27);
            this.LblDay.TabIndex = 2;
            this.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblDate.ForeColor = System.Drawing.Color.Red;
            this.LblDate.Location = new System.Drawing.Point(23, 18);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 19);
            this.LblDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("0 Davat", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(201, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "امروز :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azmoon_System.Properties.Resources.آزمون;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("0 Davat", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(186, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "کاربر فعال :";
            this.label3.Visible = false;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.ForeColor = System.Drawing.Color.Red;
            this.LblUser.Location = new System.Drawing.Point(141, 356);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(31, 14);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "------";
            this.LblUser.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار آزمون گیر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem M0;
        private System.Windows.Forms.ToolStripMenuItem M00;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem M01;
        private System.Windows.Forms.ToolStripMenuItem M1;
        private System.Windows.Forms.ToolStripMenuItem M2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem M02;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem M3;
        private System.Windows.Forms.ToolStripMenuItem M4;
        private System.Windows.Forms.ToolStripMenuItem M40;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem M41;
        private System.Windows.Forms.ToolStripMenuItem M5;
        private System.Windows.Forms.ToolStripMenuItem M6;
        public System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label3;
    }
}

