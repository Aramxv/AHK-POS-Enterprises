﻿using System;
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
    public partial class FrmStockInPrintPreview : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        FrmReports rep;

        public FrmStockInPrintPreview(FrmReports port)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            rep = port;
        }

        private void FrmStockInPrintPreview_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadStockInReport()
        {
            try
            {
                ReportDataSource rptSIH;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report4.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT * FROM ViewStockIn WHERE cast(stockdate as date) between '" + rep.stockdate1.Value.ToString("yyyyMMdd") + "' and '" + rep.stockdate2.Value.ToString("yyyyMMdd") + "' and status like 'Done' and stockinby like '" + rep.CbxStockBy.Text + "' order by stockdate desc", cn);
                da.Fill(ds.Tables["dbStockInHistory"]);
                cn.Close();

                rptSIH = new ReportDataSource("DataSet1", ds.Tables["dbStockInHistory"]);
                reportViewer1.LocalReport.DataSources.Add(rptSIH);
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
