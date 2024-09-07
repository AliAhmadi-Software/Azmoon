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
    public partial class FrmResultAzmoon : Form
    {
        public FrmResultAzmoon()
        {
            InitializeComponent();
        }

        private void FrmResultAzmoon_Load(object sender, EventArgs e)
        {
            LblCorrect.Text = "تعداد پاسخ های درست شما :" + FrmAzmoon.Correct.ToString();
            LblWrong.Text = "تعداد پاسخ های غلط شما :" + FrmAzmoon.wrong.ToString();
            LblEmpty.Text = "تعداد سوالات بی پاسخ شما :" + FrmAzmoon.Empty.ToString();
            FrmAzmoon.Correct = 0;
            FrmAzmoon.wrong = 0;
            FrmAzmoon.Empty = 0;
        }
    }
}
