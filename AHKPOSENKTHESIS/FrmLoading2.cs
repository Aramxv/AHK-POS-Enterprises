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
    public partial class FrmLoading2 : Form
    {
        public FrmLoading2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 50;
            if (panel2.Width >= 329)
            {
                timer1.Stop();
                FrmMain2 inv = new FrmMain2();
                inv.lblUsername.Text = Login.InvPassName;
                inv.lblName.Text = Login.InvPassName;
                inv.lblAccount.Text = Login.InvPassAccount;
                inv.lblPosition.Text = Login.InvPassAccount;
                inv.Show();
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
