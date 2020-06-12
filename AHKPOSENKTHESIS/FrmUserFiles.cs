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
    public partial class FrmUserFiles : Form
    {
        public FrmUserFiles()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //AdminAddAccount use = new AdminAddAccount(this);

            ////Make the Save Button Visible
            //use.BtnSave.Visible = true;

            ////Still the Update Button will not be visible 
            //use.BtnUpdate.Visible = false;

            ////Relocate the Save button next to Cancel Button
            //use.BtnSave.Location = new System.Drawing.Point(289, 619);
            //use.ShowDialog();
        }
        
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            FrmLogTrail G = new FrmLogTrail();
            G.ShowDialog();
            G.LoadTrails();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmUserFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
