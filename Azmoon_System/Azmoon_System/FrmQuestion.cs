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
    public partial class FrmQuestion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        int IDQuestion = 0;
        public void ClearTextBox()
        {
            CmbGroup.SelectedIndex = 0;
            txtQuestion.ResetText();
            txtCase1.ResetText();
            txtCase2.ResetText();
            txtCase3.ResetText();
            txtCase4.ResetText();
            CmbAnswer.SelectedIndex = 0;
            CmbGroup.Focus();
        }
        public void FillGrid()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SelectAllQuestionByGroup", con);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            da2.SelectCommand.Parameters.AddWithValue("@groupid", CmbGroup.SelectedValue);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewX1.DataSource = dt2;
        }
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void txtCase4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbGroup.DataSource = dt;
            CmbGroup.DisplayMember = "GroupName";
            CmbGroup.ValueMember = "GroupId";
            //
            CmbAnswer.SelectedIndex = 0;
            //
            //FillGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CmbGroup.Text))
                errorProvider1.SetError(CmbGroup, "گروه امتحانی بایستی انتخاب شود");
            else if (string.IsNullOrWhiteSpace(txtQuestion.Text))
                errorProvider1.SetError(txtQuestion, "متن سوال بایستی وارد شود");
            else if (string.IsNullOrWhiteSpace(txtCase1.Text))
                errorProvider1.SetError(txtCase1, "متن گزینه1 بایستی وارد شود");
            else if (string.IsNullOrWhiteSpace(txtCase2.Text))
                errorProvider1.SetError(txtCase2, "متن گزینه2 بایستی وارد شود");
            else if (string.IsNullOrWhiteSpace(txtCase3.Text))
                errorProvider1.SetError(txtCase3, "متن گزینه3 بایستی وارد شود");
            else if (string.IsNullOrWhiteSpace(txtCase4.Text))
                errorProvider1.SetError(txtCase4, "متن گزینه4 بایستی وارد شود");
            else if (string.IsNullOrWhiteSpace(CmbAnswer.Text))
                errorProvider1.SetError(CmbAnswer, " جواب صحیح بایستی انتخاب شود");
            else
            {
                SqlCommand cmd = new SqlCommand("AddQuestion",con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupid",CmbGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@questiontext",txtQuestion.Text);
                cmd.Parameters.AddWithValue("@case1",txtCase1.Text);
                cmd.Parameters.AddWithValue("@case2",txtCase2.Text);
                cmd.Parameters.AddWithValue("@case3",txtCase3.Text);
                cmd.Parameters.AddWithValue("@case4",txtCase4.Text);
                cmd.Parameters.AddWithValue("@answer",CmbAnswer.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ثبت سوال با موفقیت انجام شد");
                ClearTextBox();
            }
        }

        private void CmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SelectAllQuestionByGroup", con);
            da2.SelectCommand.CommandType = CommandType.StoredProcedure;
            da2.SelectCommand.Parameters.AddWithValue("@groupid", ((DataRowView)CmbGroup.SelectedItem)["GroupID"]);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewX1.DataSource = dt2;
        }

        private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            txtQuestion.Text = dataGridViewX1.CurrentRow.Cells["questiontxt"].Value.ToString();
            txtCase1.Text = dataGridViewX1.CurrentRow.Cells["case1"].Value.ToString();
            txtCase2.Text = dataGridViewX1.CurrentRow.Cells["case2"].Value.ToString();
            txtCase3.Text = dataGridViewX1.CurrentRow.Cells["case3"].Value.ToString();
            txtCase4.Text = dataGridViewX1.CurrentRow.Cells["case4"].Value.ToString();
            CmbAnswer.SelectedIndex = Convert.ToInt32(dataGridViewX1.CurrentRow.Cells["answer"].Value)-1;
            IDQuestion = Convert.ToInt32(dataGridViewX1.CurrentRow.Cells["questionid"].Value);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeleteQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("questionid", IDQuestion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("سوال شما با موفقیت حذف شد");
            FillGrid();
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            ClearTextBox();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EditQuestion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@questionid", IDQuestion);
            cmd.Parameters.AddWithValue("@groupid", CmbGroup.SelectedValue);
            cmd.Parameters.AddWithValue("@questiontext", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@case1", txtCase1.Text);
            cmd.Parameters.AddWithValue("@case2", txtCase2.Text);
            cmd.Parameters.AddWithValue("@case3", txtCase3.Text);
            cmd.Parameters.AddWithValue("@case4", txtCase4.Text);
            cmd.Parameters.AddWithValue("@answer", CmbAnswer.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تصحیح سوال با موفقیت انجام شد");
            FillGrid();
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            ClearTextBox();
        }
    }
}
