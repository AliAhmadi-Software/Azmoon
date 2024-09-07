using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Azmoon_System
{
    public partial class Frmlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        public static  int MyFlag = 0;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void RdbStude_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtPasword.Enabled = false;
        }

        private void RdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPasword.Enabled = true;
            txtUserName.Focus();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (RdbStude.Checked == true)
            {
                FrmMain fmain = new FrmMain();
                fmain.LblUser.Text = "کاربر معمولی";
                MyFlag = 1;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MyFlag = 0;
                if (string.IsNullOrWhiteSpace(txtUserName.Text) && string.IsNullOrWhiteSpace(txtPasword.Text))
                {
                    MessageBox.Show("نام کاربری و رمز خود را وارد نمایید");
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SearchForLogin", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    da.SelectCommand.Parameters.AddWithValue("@password", txtPasword.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("نام کاربری یا کلمه عبور صحیح نیست ");
                        txtPasword.ResetText();
                        txtUserName.ResetText();
                        txtUserName.Focus();
                    }
                    else
                    {
                        FrmMain fmain = new FrmMain();
                        fmain.LblUser.Text = txtUserName.Text;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
