using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Azmoon_System
{
    public partial class FrmBackup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;Asynchronous Processing=true");
        SqlCommand cmd;
        bool flag = false;
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.Substring(0, 1) == "C")
                {
                    MessageBox.Show("بهتر است پشتیبان گیری در درایو\n" + " C \n" + "نباشد");
                }
                if (folderBrowserDialog1.SelectedPath.Length > 350)
                {
                    MessageBox.Show("مسیر انتخاب شده طولانی تر از حد مجاز است");
                }
                else
                {
                    TxtSelectPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSelectPath.Text) && string.IsNullOrWhiteSpace(TxtBackupName.Text))
            {
                MessageBox.Show("مسیر فایل پشتیبان گیری و یا نام فایل پشتیبان وارد نشده است");
            }
            else if(File.Exists(TxtSelectPath.Text + "\\" + TxtBackupName.Text.Trim() + ".bak"))
            {
                MessageBox.Show("در مسیر انتخاب شده قبلا فایلی به این نام انتخاب شده است");
            }
            else
            {
                flag = true;
                BtnBackup.Enabled = false;
                GrpSelectAction.Enabled = false;
                cmd = new SqlCommand("MyBackup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@path", TxtSelectPath.Text + "\\" + TxtBackupName.Text.Trim() + ".bak");
                con.Open();
                AsyncCallback CallBackDelegate = HandleCallBack;
                cmd.BeginExecuteNonQuery(CallBackDelegate, cmd);
            }
        }
        private void HandleCallBack(IAsyncResult result)
        {
            try
            {
                cmd = (SqlCommand)result.AsyncState;
                cmd.EndExecuteNonQuery(result);
                MessageBox.Show("عملیات پشتیبان گیری با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show("عملیات پشتیبان گیری توسط کاربر متوقف شد");
            }
            con.Close();
            flag = false;
            this.BeginInvoke((MethodInvoker)delegate()
            {
                GrpSelectAction.Enabled = true;
                BtnBackup.Enabled = true;
            });
        }

        private void BtnCancelBackup_Click(object sender, EventArgs e)
        {
            cmd.Cancel();
        }

        private void RdbBackup_CheckedChanged(object sender, EventArgs e)
        {
            GrpReastor.Enabled = false;
            GrpBackup.Enabled = true;
        }

        private void RdbRestore_CheckedChanged(object sender, EventArgs e)
        {
            GrpReastor.Enabled = true;
            GrpBackup.Enabled = false;
        }

        private void FrmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RdbBackup.Checked == true)
            {
                if (flag == true)
                {
                    e.Cancel = true;
                    MessageBox.Show("سیستم در حال پشتیبان گیری اطلاعات است لطفا ابتدا عملیات را متوقف کنید");
                }
            }
            else if (RdbRestore.Checked == true)
            {
                if (flag == true)
                {
                    e.Cancel = true;
                    MessageBox.Show("شما در حال بازیابی اطلاعات هستید اکیذا توصیه میکنیم تا پایان عملیات پروژه را نبندید","هشدار");
                }
            }
        }

        private void BtnSelectBackup_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bak)|*.bak";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSelectBackup.Text = openFileDialog1.FileName;
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSelectBackup.Text))
                MessageBox.Show("فایل پشتیبان جهت  بازیابی را انتخاب نمایید");
            else
            {
                flag = true;
                GrpSelectAction.Enabled = false;
                BtnRestore.Enabled = false;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cmd = new SqlCommand("MyRestore", con);
            cmd.CommandTimeout = 120;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pathfile", TxtBackupName.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("عملیات بازیابی اطلاعات با موفقیت انجام شد برنامه بعد از این پیغام مجددا راه اندازی میشود");
                //Application.Exit();
                Application.Restart();
            }
            else
            {
               // MessageBox.Show(e.Error.Message);
                MessageBox.Show("در بازیابی اطلاعات خطایی رخ داده است");
                flag = false;
            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            GrpReastor.Enabled = false;
        }


    }
}
