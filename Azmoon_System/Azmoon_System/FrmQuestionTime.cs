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
    public partial class FrmQuestionTime : Form
    {
        public FrmQuestionTime()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                errorProvider1.SetError(txtTime,"زمان وارد نشده است");
                txtTime.Focus();
            }
            else
            {
                Properties.Settings.Default.QuestionTime = Convert.ToInt32(txtTime.Text.Trim());
                Properties.Settings.Default.Save();
                MessageBox.Show("تایم با موفقیت ذخیره شد");
                txtTime.ResetText();
                txtTime.Focus();
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTime, "");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
