using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Chart Display
using System.Windows.Forms.DataVisualization.Charting;

namespace AHKPOSENKTHESIS
{
    public partial class AdminResources : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        public AdminResources()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            GetChartData();
            DisplayChartTopSelling();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        //Display the data from database to chart 1 in Area Chart Type
        public void GetChartData()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Year (stockdate) as year, ISNULL(SUM(total),0.0) as total from tblInvoiceOrder WHERE status like 'Sold' group by Year (stockdate)", cn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Sales");
            chart1.DataSource = ds.Tables["Sales"];
            Series series1 = chart1.Series["Series1"];
            series1.ChartType = SeriesChartType.Column;

            series1.Name = "Yearly Sales";

            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "year";
            chart.Series[series1.Name].YValueMembers = "total";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].LabelFormat = "₱" + "{#,##0.00}";

            cn.Close();
        }

        public void DisplayChartTopSelling()
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT top 10 proddescrip, isnull(sum(qty),0) as qty  FROM ViewSoldItems WHERE stockdate between '" + dateTimePicker1.Value.ToString("yyyyMMdd") + "' and '" + dateTimePicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by proddescrip order by qty desc", cn);
            DataSet ds = new DataSet();

            da.Fill(ds, "TOPPRODUCTS");
            chart2.DataSource = ds.Tables["TOPPRODUCTS"];
            Series series = chart2.Series[0];
            series.ChartType = SeriesChartType.SplineArea;

            series.Name = "Top Products";

            var chart = chart2;
            chart.Series[0].XValueMember = "proddescrip";
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].YValueMembers = "qty";

            // Set series label format
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[0].LabelFormat = "{#,##0}";
            cn.Close();

        }



        private void AdminResources_Load(object sender, EventArgs e)
        {
           
        }
    }
}
