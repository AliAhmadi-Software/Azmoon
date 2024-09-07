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
    public partial class FrmGroup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        int IDGroup = 0;
        public FrmGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGroup.Text))
            {
                errorProvider1.SetError(txtGroup, "گروه آموزشی نمیتواند خالی باشد ");
                txtGroup.Focus();
            }
            else
            {
                errorProvider1.SetError(txtGroup, "");
                SqlCommand cmd = new SqlCommand("AddGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupname", txtGroup.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("گروه آموزشی با موفقیت ثبت شد");
                FrmGroup_Load(null, null);
                txtGroup.Text = "";
                txtGroup.Focus();
            }
        }

        private void FrmGroup_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewX1.DataSource = dt;
        }

        private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Enabled = false;
            buttonX2.Enabled = true;
            txtGroup.Text = dataGridViewX1.CurrentRow.Cells["groupname"].Value.ToString();
            IDGroup = Convert.ToInt32(dataGridViewX1.CurrentRow.Cells["groupid"].Value);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EditGroup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", IDGroup);
            cmd.Parameters.AddWithValue("groupname", txtGroup.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ویرایش گروه آموزشی با موفقیت انجام شد");
            FrmGroup_Load(null, null);
            btnAdd.Enabled = true;
            buttonX2.Enabled = false;
            txtGroup.ResetText();
            txtGroup.Focus();
        }
    }
}
