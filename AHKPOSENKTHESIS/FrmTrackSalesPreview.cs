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
    public partial class FrmTrackSalesPreview : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        FrmReports rep;

        public FrmTrackSalesPreview(FrmReports port)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rep = port;
        }

        private void FrmTrackSalesPreview_Load(object sender, EventArgs e)
        {

        }

        public void LoadTrackSales()
        {
            try
            {
                ReportDataSource rptTSS;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report7.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                if (rep.cmbTerms.Text == "Cash")
                {
                    da.SelectCommand = new SqlCommand("SELECT customer, address, payment, sum(vat) as total_vat, sum(vatable) as total_vatable, sum(discount) as total_discount, sum(salestotal) as total FROM tblInvoiceRecords WHERE datecreated between '" + rep.bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + rep.bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' and payment like '" + rep.cmbTerms.Text + "' group by customer, address, payment, datecreated order by datecreated desc", cn);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("SELECT customer, address, payment, sum(vat) as total_vat, sum(vatable) as total_vatable, sum(discount) as total_discount, sum(salestotal) as total FROM tblInvoiceRecords WHERE datecreated between '" + rep.bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + rep.bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' and payment like '" + rep.cmbTerms.Text + "' group by customer, address, payment, datecreated order by datecreated desc", cn);
                }
                da.Fill(ds.Tables["dbTrackSales"]);
                cn.Close();

                rptTSS = new ReportDataSource("DataSet1", ds.Tables["dbTrackSales"]);
                reportViewer1.LocalReport.DataSources.Add(rptTSS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
