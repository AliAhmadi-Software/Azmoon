using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Azmoon_System
{
    public partial class Frmlogo : Form
    {
        public Frmlogo()
        {
            InitializeComponent();
            //
            timer1.Start();
        }
        string S = "به نرم افزار آزمون گیری چهار گزینه ای خوش آمدید\n" + "از اینکه نرم افزار ما را انتخاب کردید از شما متشکریم";
        int MyTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.02;
            }
            //
            MyTime++;
            LblCenter.Text = S.Substring(0,MyTime);
            if (MyTime == S.Length)
            {
                timer1.Stop();
                this.Close();
            }
        }
        private void Frmlogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                timer1.Stop();
            }
        }

        private void Frmlogo_Load(object sender, EventArgs e)
        {
            resolution_changer.Form1 f = new resolution_changer.Form1();
            f.Lbl_n1.Text = "894561";
            f.Lbl_n2.Text = "3";
            f.ShowDialog();
            if (this.DialogResult == DialogResult.OK)
            {
                
            }
            else
            {
                MessageBox.Show("از این که ما را انتخاب کرده اید متشکریم", "خدا نگهدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
