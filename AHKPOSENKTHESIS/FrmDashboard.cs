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
//Chart Display
using System.Windows.Forms.DataVisualization.Charting;

namespace AHKPOSENKTHESIS
{
    public partial class FrmDashboard : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        public FrmDashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            GetChartData();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
           
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
            series1.ChartType = SeriesChartType.Area;

            series1.Name = "SALES";

            var chart = chart1;
            chart.Series[series1.Name].XValueMember = "year";
            chart.Series[series1.Name].YValueMembers = "total";
            chart.Series[0].IsValueShownAsLabel = true;
            cn.Close();
        }

        public void DisplayTheTopSellingProducts()
        {

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
