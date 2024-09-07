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
    public partial class FrmReporteQuestion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        DataTable DtAllQ;
        public FrmReporteQuestion()
        {
            InitializeComponent();
        }

        private void RdbAllQuestion_CheckedChanged(object sender, EventArgs e)
        {
            CmbGroup.Enabled = false;
        }

        private void RdbOneGroup_CheckedChanged(object sender, EventArgs e)
        {
            CmbGroup.Enabled = true;
        }

        private void FrmReporteQuestion_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbGroup.DataSource = dt;
            CmbGroup.DisplayMember = "GroupName";
            CmbGroup.ValueMember = "GroupID";
            CmbGroup.Enabled = false;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (RdbAllQuestion.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("ReportAllQuestion", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DtAllQ = new DataTable();
                da.Fill(DtAllQ);
                //
                StireportQ.Load("StiQuestion.mrt");
                StireportQ.RegData(DtAllQ);
                StireportQ.Show();
            }
            else if (RdbOneGroup.Checked == true)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("ReporteOneGroup", con);
                da2.SelectCommand.CommandType = CommandType.StoredProcedure;
                da2.SelectCommand.Parameters.AddWithValue("groupid", CmbGroup.SelectedValue);
                DtAllQ = new DataTable();
                da2.Fill(DtAllQ);
                if (DtAllQ.Rows.Count == 0)
                {
                    MessageBox.Show("برای این گروه امتحانی هیچ سوالی ثبت نشده است");
                }
                else
                {
                    StireportQ.Load("StiQuestion.mrt");
                    StireportQ.RegData(DtAllQ);
                    StireportQ.Show();
                }
            }
        }
    }
}
