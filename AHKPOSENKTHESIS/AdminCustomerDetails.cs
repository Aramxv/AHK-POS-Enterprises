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
    public partial class AdminCustomerDetails : Form
    {
        public AdminCustomerDetails()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
