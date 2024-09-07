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
    public partial class FrmAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        public void ClearFrm()
        {
            FrmAdmin_Load(null, null);
            txtUserName.ResetText();
            txtPass1.ResetText();
            txtPass2.ResetText();
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            txtUserName.Enabled = true;
            txtUserName.Focus();
        }
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "نام کاربری بایستی وارد شود");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPass1.Text))
            {
                errorProvider1.SetError(txtPass1, "رمز عبور بایستی وارد نمایید");
                txtPass1.Focus();
            }            
            else if (string.IsNullOrWhiteSpace(txtPass2.Text))
            {
                errorProvider1.SetError(txtPass2, "تکرار رمز عبور را وارد نمایید");
                txtPass2.Focus();
            }              
            else if (txtPass1.Text.Trim() != txtPass2.Text.Trim())
            {
                MessageBox.Show("تکرار رمز عبور با رمز عبور بایستی برابر باشد");
                txtPass1.ResetText();
                txtPass2.ResetText();
                txtPass1.Focus();
            }      
            else
            {
                SqlCommand cmd = new SqlCommand("AddAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@pasword", txtPass1.Text.Trim());
                cmd.Parameters.Add("@result", SqlDbType.Int);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                if (res == 1)
                {
                    MessageBox.Show("نام کاربری قبلا در سیستم ثبت شده است");
                }
                else
                {
                    MessageBox.Show("کاربر مدیر با موفقیت در سیستم ثبت شد");
                    SqlDataAdapter da = new SqlDataAdapter("SelectAllAdmin", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewX1.DataSource = dt;
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUserName, "");
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPass1, "");
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPass2, "");
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllAdmin", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewX1.DataSource = dt;
        }

        private void txtPass1_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPass1, "");
        }

        private void txtUserName_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUserName, "");
        }

        private void txtPass2_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPass2, "");
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "مقداری وارد نشده است");
                txtUserName.Focus();
            }*/
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeleteAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("حذف مدیر با موفقیت انجام شد");
            ClearFrm();
        }

        private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            txtUserName.Text = dataGridViewX1.CurrentRow.Cells["username"].Value.ToString();
            txtPass1.Text = dataGridViewX1.CurrentRow.Cells["pasword"].Value.ToString();
            txtPass2.Text = dataGridViewX1.CurrentRow.Cells["pasword"].Value.ToString();
            txtUserName.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "نام کاربری بایستی وارد شود");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPass1.Text))
            {
                errorProvider1.SetError(txtPass1, "رمز عبور بایستی وارد نمایید");
                txtPass1.Focus();
            }            
            else if (string.IsNullOrWhiteSpace(txtPass2.Text))
            {
                errorProvider1.SetError(txtPass2, "تکرار رمز عبور را وارد نمایید");
                txtPass2.Focus();
            }
            else if (txtPass1.Text.Trim() != txtPass2.Text.Trim())
            {
                MessageBox.Show("تکرار رمز عبور با رمز عبور بایستی برابر باشد");
                txtPass1.ResetText();
                txtPass2.ResetText();
                txtPass1.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("EditAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@pasword", txtPass1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش مدیر با موفقیت انجام شد");
                ClearFrm();
            }
        }
    }
}
