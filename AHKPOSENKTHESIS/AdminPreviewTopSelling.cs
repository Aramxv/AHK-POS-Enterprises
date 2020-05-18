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
    public partial class AdminPreviewTopSelling : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        AdminReportsTopSelling rep;

        public AdminPreviewTopSelling(AdminReportsTopSelling port)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rep = port;
        }

        private void FrmTopSellingProductsPrintPreview_Load(object sender, EventArgs e)
        {

        }

        public void LoadTopSellingProducts()
        {
            try
            {
                ReportDataSource rptTSP;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report3.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                if (rep.cmbTerms.Text == "Quantity")
                {
                   da.SelectCommand = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + rep.bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + rep.bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by qty desc", cn);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + rep.bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + rep.bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by total desc", cn);
                }
                da.Fill(ds.Tables["dbTopSellingProducts"]);
                cn.Close();

                rptTSP = new ReportDataSource("DataSet1", ds.Tables["dbTopSellingProducts"]);
                reportViewer1.LocalReport.DataSources.Add(rptTSP);
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
