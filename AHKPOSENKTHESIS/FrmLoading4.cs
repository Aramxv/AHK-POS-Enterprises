using System;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmLoading4 : Form
    {
        public FrmLoading4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 50;
            if (panel2.Width >= 329)
            {
                timer1.Stop();
                FrmMain1 admin = new FrmMain1();
                admin.lblUsername.Text = FrmMain2.BackToAdminName;
                admin.lblAccount.Text = FrmMain2.BackToAdminAccount;
                admin.Show();

                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Width += 87;
            if (panel2.Width >= 329)
            {
                panel4.Width = 25;
            }
        }
    }
}
