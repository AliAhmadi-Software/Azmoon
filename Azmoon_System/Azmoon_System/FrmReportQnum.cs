using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Azmoon_System
{
    public partial class FrmReportQnum : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        string MyDate;
        DataTable DtQnum;
        DataSet ds;
        public FrmReportQnum()
        {
            InitializeComponent();
            //
            DateTime today = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            MyDate = pc.GetYear(today).ToString("0000/") + pc.GetMonth(today).ToString("00/") + pc.GetDayOfMonth(today).ToString();
        }

        private void RdbAllQnum_CheckedChanged(object sender, EventArgs e)
        {
            CmbGroup.Enabled = false;
        }

        private void RdbOneQnum_CheckedChanged(object sender, EventArgs e)
        {
            CmbGroup.Enabled = true;
        }

        private void FrmReportQnum_Load(object sender, EventArgs e)
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
            DataTable DtDate = new DataTable();
            DtDate.Columns.Add("Date");
            DtDate.Rows.Add();
            DtDate.Rows[0]["Date"] = MyDate;
            //*******************************************//
            if (RdbAllQnum.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("ReportAllQNum", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DtQnum = new DataTable();
                da.Fill(DtQnum);
                //
                ds = new DataSet();
                ds.Merge(DtDate);
                ds.Tables[0].TableName = "DtDate";
                ds.Merge(DtQnum);
                ds.Tables[1].TableName = "DtQnum";
                //
                StiReportQnum.Load("StiReportQnum.mrt");
                StiReportQnum.RegData(ds);
                StiReportQnum.Show();
            }
            else if (RdbOneQnum.Checked == true)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("ReportOneGroupQnum", con);
                da2.SelectCommand.CommandType = CommandType.StoredProcedure;
                da2.SelectCommand.Parameters.AddWithValue("@groupid", CmbGroup.SelectedValue);
                DtQnum = new DataTable();
                da2.Fill(DtQnum);
                //
                if (DtQnum.Rows.Count == 0)
                {
                    MessageBox.Show("هیچ سوالی برای این گروه آموزشی ثبت نشده است");
                }
                else
                {
                    ds = new DataSet();
                    ds.Merge(DtDate);
                    ds.Tables[0].TableName = "DtDate";
                    ds.Merge(DtQnum);
                    ds.Tables[1].TableName = "DtQnum";
                    //
                    StiReportQnum.Load("StiReportQnum.mrt");
                    StiReportQnum.RegData(ds);
                    StiReportQnum.Show();
                }
            }
        }
    }
}
