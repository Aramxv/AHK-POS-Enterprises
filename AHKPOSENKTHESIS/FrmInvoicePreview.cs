using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmInvoicePreview : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        FrmCreateNewInvoice inv;

        public FrmInvoicePreview(FrmCreateNewInvoice cre)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            inv = cre;
        }

        private void FrmInvoicePreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AHKENTPOSDATABASEDataSet.OrderbyInvoiceNo' table. You can move, or remove it, as needed.
            this.OrderbyInvoiceNoTableAdapter.Fill(this.AHKENTPOSDATABASEDataSet.OrderbyInvoiceNo, inv.lblInvoiceNo.Text);

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            
            
            this.reportViewer1.RefreshReport();
        }

    }
}
