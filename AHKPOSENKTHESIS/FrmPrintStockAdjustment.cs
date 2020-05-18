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
    public partial class FrmPrintStockAdjustment : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        AdminStockAdjustDatePicker adj;

        public FrmPrintStockAdjustment(AdminStockAdjustDatePicker just)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            adj = just;
        }

        public void LoadStockAdjustReport()
        {
            try
            {
                ReportDataSource rptSADJ;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report9.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                if (adj.CbxAdjustBy.Text == "All")
                {
                    cn.Open();
                    da.SelectCommand = new SqlCommand("SELECT * FROM ViewStockAdjustment WHERE cast(stockdate as date) between '" + adj.bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + adj.bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' order by stockdate desc", cn);
                    da.Fill(ds.Tables["dbStockAdjustment"]);
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    da.SelectCommand = new SqlCommand("SELECT * FROM ViewStockAdjustment WHERE cast(stockdate as date) between '" + adj.bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + adj.bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and stockby like '" + adj.CbxAdjustBy.Text + "' order by stockdate desc", cn);
                    da.Fill(ds.Tables["dbStockAdjustment"]);
                    cn.Close();
                }

                rptSADJ = new ReportDataSource("DataSet1", ds.Tables["dbStockAdjustment"]);
                reportViewer1.LocalReport.DataSources.Add(rptSADJ);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPrintStockAdjustment_Load(object sender, EventArgs e)
        {

        }
    }
}
