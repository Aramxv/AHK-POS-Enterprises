using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmLoading3 : Form
    {
        public FrmLoading3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 50;
            if (panel2.Width >= 329)
            {
                timer1.Stop();
                FrmMain2 load = new FrmMain2();
                load.lblUsername.Text = FrmMain1.PassToPOSName;
                load.lblName.Text = FrmMain1.PassToPOSName;
                load.lblAccount.Text = FrmMain1.PassToPOSAccount;
                load.lblPosition.Text = FrmMain1.PassToPOSAccount;
                load.BtnBackAdminMode.Visible = true;
                load.Show();

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
