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
    public partial class FrmInventoryPreview : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        FrmReports rep;

        public FrmInventoryPreview(FrmReports port)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rep = port;
        }

        private void FrmInventoryPreview_Load(object sender, EventArgs e)
        {

        }

        public void LoadInventory()
        {
            try
            {
                ReportDataSource rptInv;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report6.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();


                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM tblProduct  order by proddescrip", cn);
                da.Fill(ds.Tables["dbInventory"]);
                cn.Close();

                rptInv = new ReportDataSource("DataSet1", ds.Tables["dbInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptInv);
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
