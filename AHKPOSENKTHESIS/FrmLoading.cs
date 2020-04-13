using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AHKPOSENKTHESIS
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

      
        private void FrmLoading_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 50;
            if (panel2.Width >= 329)
            {
                timer1.Stop();
                FrmMain1 Ad = new FrmMain1();
                Ad.lblUsername.Text = FrmLogin.ClickPassName;
                Ad.lblAccount.Text = FrmLogin.ClickPassAccount;
                Ad.Show();
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
