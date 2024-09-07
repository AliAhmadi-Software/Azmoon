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
    public partial class FrmAzmoon : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;initial Catalog=DBAzmoon;integrated security=true;");
        DataTable dt;
        int num = 0;
        int MyTime = 0;
        int k = 0;
        ListBox mylistanswer;
        public static int Correct, wrong, Empty;
        public FrmAzmoon()
        {
            InitializeComponent();
        }
        public void UncheckedRadioBtn(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
                if (object.ReferenceEquals(ctrl.GetType(), typeof(RadioButton)))
                {
                    ((RadioButton)ctrl).Checked = false;
                }
            }
        }
        private void FrmAzmoon_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllGroup", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbGroup.DataSource = dt;
            CmbGroup.DisplayMember = "GroupName";
            CmbGroup.ValueMember = "GroupID";
            UncheckedRadioBtn(groupPanel3);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQN.Text) && string.IsNullOrWhiteSpace(CmbGroup.Text))
            {
                MessageBox.Show("تعداد سوالات یا گروه امتحانی مشخص نمی باشد");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("CheckQuestionNum", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupid", CmbGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@questionnum", txtQN.Text);
                cmd.Parameters.Add("@result", SqlDbType.Int);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                if (res == 0)
                {
                    MessageBox.Show("تعداد سوالات مد نظر شما از تعداد سوالات موجود در بانک اطلاعاتی بیشتر است");
                }
                else if (res == 1)
                {
                    BtnNext.Enabled = true;
                    BtnPrevious.Enabled = true;
                    //
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);
                    //


                    //
                    //ListBox MylistResult = new ListBox();
                    //while (MylistResult.Items.Count < Convert.ToInt32(txtQN.Text.Trim()))
                    //{
                    //    Random rand = new Random();
                    //    num = rand.Next(Convert.ToInt32(dt.Rows[0][0].ToString()), Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString()));
                    //    //
                    //    for (int i = 0; i < dt.Rows.Count; i++)
                    //    {
                    //        if (num == Convert.ToInt32(dt.Rows[i][0].ToString()))
                    //        {
                    //            if (MylistResult.Items.Count == 0)
                    //                MylistResult.Items.Add(num);
                    //            else
                    //            {
                    //                for (int j = 0; j < MylistResult.Items.Count; j++)
                    //                {
                    //                    if (num == Convert.ToInt32(MylistResult.Items[j]))
                    //                        j = MylistResult.Items.Count;
                    //                    else
                    //                    {
                    //                        if (j == MylistResult.Items.Count - 1)
                    //                            MylistResult.Items.Add(num);
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    ///*for(int i=0;i<MylistResult.Items.Count;i++)
                    //    listBox1.Items.Add(MylistResult.Items[i]);*/
                    //string s = "";
                    //for (int i = 0; i < MylistResult.Items.Count; i++)
                    //{
                    //    s += MylistResult.Items[i].ToString() + ",";
                    //}
                    ////
                    //s = s.Remove(s.Length - 1, 1);
                    ////
                    //da = new SqlDataAdapter("SelectFilterQuestion", con);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@listquestion", s);
                    //dt = new DataTable();
                    //da.Fill(dt);
                    //dataGridViewX1.DataSource = dt;
                    if (ChkTime.Checked == true)
                    {
                        lbltotalTimer.Text = (Properties.Settings.Default.QuestionTime * dt.Rows.Count).ToString();
                        timer1.Start();
                    }
                    //
                    k = 0;
                    lblQuestiontxt.Text = dt.Rows[0]["QuestionText"].ToString();
                    RdbCase1.Text = dt.Rows[0]["Case1"].ToString();
                    RdbCase2.Text = dt.Rows[0]["Case2"].ToString();
                    RdbCase3.Text = dt.Rows[0]["Case3"].ToString();
                    RdbCase4.Text = dt.Rows[0]["Case4"].ToString();
                    mylistanswer = new ListBox();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        mylistanswer.Items.Add(0);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyTime = Convert.ToInt32(lbltotalTimer.Text);
            MyTime--;
            lbltotalTimer.Text = MyTime.ToString();
            if (MyTime == 0)
            {
                timer1.Stop();
                //
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(mylistanswer.Items[i]) == Convert.ToInt32((dt.Rows[i]["answer"]).ToString()))
                    {
                        Correct++;
                    }
                    else if (Convert.ToInt32(mylistanswer.Items[i]) == 0)
                    {
                        Empty++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                FrmResultAzmoon fres = new FrmResultAzmoon();
                fres.ShowDialog();
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!RdbCase1.Checked && !RdbCase2.Checked && !RdbCase3.Checked && !RdbCase4.Checked)
            {
                mylistanswer.Items[k] = 0;
            }
            else if (RdbCase1.Checked)
            {
                mylistanswer.Items[k] = 1;
            }
            else if (RdbCase2.Checked)
            {
                mylistanswer.Items[k] = 2;
            }
            else if (RdbCase3.Checked)
            {
                mylistanswer.Items[k] = 3;
            }
            else if (RdbCase4.Checked)
            {
                mylistanswer.Items[k] = 4;
            }
            // 
            if (k == dt.Rows.Count - 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(Convert.ToInt32(mylistanswer.Items[i])==Convert.ToInt32((dt.Rows[i]["answer"]).ToString()))
                    {
                        Correct++;
                    }
                    else if(Convert.ToInt32(mylistanswer.Items[i])==0)
                    {
                        Empty++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                timer1.Stop();
                FrmResultAzmoon fres = new FrmResultAzmoon();
                fres.ShowDialog();
            }
            else
            {
                k++;
                lblQuestiontxt.Text = dt.Rows[k]["QuestionText"].ToString();
                RdbCase1.Text = dt.Rows[k]["Case1"].ToString();
                RdbCase2.Text = dt.Rows[k]["Case2"].ToString();
                RdbCase3.Text = dt.Rows[k]["Case3"].ToString();
                RdbCase4.Text = dt.Rows[k]["Case4"].ToString();
                UncheckedRadioBtn(groupPanel3);
            }
             
            
            
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                lblQuestiontxt.Text = dt.Rows[k]["QuestionText"].ToString();
                RdbCase1.Text = dt.Rows[k]["Case1"].ToString();
                RdbCase2.Text = dt.Rows[k]["Case2"].ToString();
                RdbCase3.Text = dt.Rows[k]["Case3"].ToString();
                RdbCase4.Text = dt.Rows[k]["Case4"].ToString();
            }
        }
        }
    }

