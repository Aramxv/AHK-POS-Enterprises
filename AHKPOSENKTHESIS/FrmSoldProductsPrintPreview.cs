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
    public partial class FrmSoldProductsPrintPreview : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        FrmReports rep;

        public FrmSoldProductsPrintPreview(FrmReports port)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rep = port;
        }

        private void FrmSoldProductsPrintPreview_Load(object sender, EventArgs e)
        {

        }

        public void LoadSoldReport()
        {
            try
            {
                ReportDataSource rptSD;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT c.prodcode, p.proddescrip, c.prodprice, sum(c.qty) as total_qty, sum(c.discount) as total_discount, sum(c.total) as total_total from tblInvoiceOrder as c inner join tblProduct as p on c.prodcode = p.prodcode where status like 'Sold' and stockdate between '" + rep.dt1.Value.ToString("yyyyMMdd") + "' and '" + rep.dt2.Value.ToString("yyyyMMdd") + "' group by c.prodcode, p.proddescrip, c.prodprice", cn);
                da.Fill(ds.Tables["dbSoldReport"]);
                cn.Close();

                rptSD = new ReportDataSource("DataSet1", ds.Tables["dbSoldReport"]);
                reportViewer1.LocalReport.DataSources.Add(rptSD);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
