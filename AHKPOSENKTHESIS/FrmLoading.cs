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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 24;
            if (panel2.Width >= 769)
            {
                timer1.Stop();
                AdminAdministrator admin = new AdminAdministrator();
                admin.lblUsername.Text = Login.ClickPassName;
                admin.lblAccount.Text = Login.ClickPassAccount;
                admin.Show();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Width += 87;
            if (panel2.Width >= 769)
            {
                panel4.Width = 25;
            }
        }


        // icons8.com/preloaders/en/circular - for circular spinners 
        // unsplash.com/ - for the image 

    }
}
