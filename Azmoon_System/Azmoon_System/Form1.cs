using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Azmoon_System
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //
            DateTime Today =  DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            LblDate.Text = pc.GetYear(Today).ToString("0000/") + pc.GetMonth(Today).ToString("00/") + pc.GetDayOfMonth(Today).ToString("00");
            //
            string myday = DateTime.Now.DayOfWeek.ToString();
            if (myday == DayOfWeek.Saturday.ToString())
                LblDay.Text = "شنبه";
            else if(myday==DayOfWeek.Sunday.ToString())
                LblDay.Text = "یکشنبه";
            else if (myday == DayOfWeek.Monday.ToString())
                LblDay.Text = "دو شنبه";
            else if (myday == DayOfWeek.Tuesday.ToString())
                LblDay.Text = "سه شنبه";
            else if (myday == DayOfWeek.Wednesday.ToString())
                LblDay.Text = " چهار شنبه";
            else if (myday == DayOfWeek.Thursday.ToString())
                LblDay.Text = " پنج شنبه";
            else if (myday == DayOfWeek.Friday.ToString())
                LblDay.Text = "جمعه";
            //
            timer1.Start();
        }

        private void M00_Click(object sender, EventArgs e)
        {
            FrmGroup fgroup = new FrmGroup();
            fgroup.ShowDialog();
        }

        private void M01_Click(object sender, EventArgs e)
        {
            FrmQuestion fgroup = new FrmQuestion();
            fgroup.ShowDialog();
        }

        private void M1_Click(object sender, EventArgs e)
        {
            FrmAdmin fadmin = new FrmAdmin();
            fadmin.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Frmlogo flogo = new Frmlogo();
            flogo.ShowDialog();
            Frmlogin flogin = new Frmlogin();
            flogin.ShowDialog();
            if (flogin.DialogResult != System.Windows.Forms.DialogResult.OK)
                Application.ExitThread();
            if (Frmlogin.MyFlag == 1)
            {
                menuStrip1.Items["M0"].Enabled = false;
                menuStrip1.Items["M1"].Enabled = false;
                menuStrip1.Items["M3"].Enabled = false;
                menuStrip1.Items["M4"].Enabled = false;
                menuStrip1.Items["M5"].Enabled = false;
            }
        }

        private void M2_Click(object sender, EventArgs e)
        {
            FrmAzmoon fazmoon = new FrmAzmoon();
            fazmoon.ShowDialog();
        }

        private void M02_Click(object sender, EventArgs e)
        {
            FrmQuestionTime fqtime = new FrmQuestionTime();
            fqtime.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.Hour.ToString("00 : ") + dt.Minute.ToString("00 : ") + dt.Second.ToString("00");
        }

        private void M3_Click(object sender, EventArgs e)
        {
            FrmBackup fbackup = new FrmBackup();
            fbackup.ShowDialog();
        }

        private void M40_Click(object sender, EventArgs e)
        {
            FrmReporteQuestion frmreporte = new FrmReporteQuestion();
            frmreporte.ShowDialog();
        }

        private void M41_Click(object sender, EventArgs e)
        {
            FrmReportQnum frqn = new FrmReportQnum();
            frqn.ShowDialog();
        }

        private void M5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"help.chm");
            //select one page of help WinCHM
            //Help.ShowHelp(this,"help.chm",HelpNavigator.Topic,"url.htm");
            //آدرس هر صفحه راهنما درون نرم افزار راهنما بالای هر صفحه در قسمت آدرس آن موجود است
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //کاربر با فشردن کلید مورد نظر فایل راهنما را باز می کند
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "help.chm");
            }
        }

        private void M6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا قصد خروج از نرم افزار را دارید؟", "خروج", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
