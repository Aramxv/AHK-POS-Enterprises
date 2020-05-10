using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmInvoiceEditPrintPreview : Form
    {
        AdminUpdateInvoice edit;

        public FrmInvoiceEditPrintPreview(AdminUpdateInvoice idit)
        {
            InitializeComponent();
            edit = idit;
        }

        private void FrmInvoiceEditPrintPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AHKENTPOSDATABASEDataSet.OrderbyInvoiceNo' table. You can move, or remove it, as needed.
            this.OrderbyInvoiceNoTableAdapter.Fill(this.AHKENTPOSDATABASEDataSet.OrderbyInvoiceNo, edit.lblInvoiceNo.Text);

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;


            this.reportViewer1.RefreshReport();
        }
    }
}
