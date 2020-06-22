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
using System.Windows.Forms.DataVisualization.Charting;

namespace AHKPOSENKTHESIS
{
    public partial class AdminReportsTopSelling : UserControl
    {
        // Declare sqlconnection variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String TopSellingStartDate;
        String TopSellingEndDate;


        public AdminReportsTopSelling()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the date to current date
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;


            // Store a value of datetimepicker to a variable
            TopSellingStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            TopSellingEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            // Print the stored value of the variable
            bunifuCustomLabel1.Text = TopSellingStartDate;
            bunifuCustomLabel2.Text = TopSellingEndDate;
        }

        private void AdminReportsTopSelling_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 219, 223);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 54, 75);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 5, 0, 5);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }

        public void CollapseSettings()
        {
            // Create an image path 
            Image down = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_down_36px.png");

            // Create an image path 
            Image up = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_up_36px.png");


            if (panel1.Height == 50)
            {
                BtnDropDown.Image = up;
                panel1.Height = 255;
            }
            else
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;
            }
        }

        public void UnCollapeSettings()
        {
            // Create an image path 
            Image down = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_down_36px.png");

            // Create an image path 
            Image up = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_up_36px.png");


            if (panel1.Height == 255)
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;

            }
            else
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;

            }
        }

        private void BtnDropDown_Click(object sender, EventArgs e)
        {
            CollapseSettings();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CollapseSettings();
        }

        private void AdminReportsTopSelling_Click(object sender, EventArgs e)
        {
            UnCollapeSettings();
        }

        //Load the top 10 selling products with filters such as Date and status and group by product code and product description order by quantity in descending order
        public void ShowRecordsOfTopSellingProducts()
        {
            try
            {
                int i = 0;
                double _salestotal = 0;
                double _qtytotal = 0;
                cn.Open();
                dataGridView1.Rows.Clear();
                if (cmbTerms.Text == "Quantity")
                {
                    cm = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by qty desc", cn);
                }
                else if (cmbTerms.Text == "Amount")
                {
                    cm = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by total desc", cn);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    _salestotal += double.Parse(dr["total"].ToString());
                    _qtytotal += double.Parse(dr["qty"].ToString());
                    dataGridView1.Rows.Add(i, dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("₱#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotalQty.Text = _qtytotal.ToString("#,###") + " Total Quanity";
                lblTotalSales.Text = "₱ " + _salestotal.ToString("#,##0.00") + " Total Sales";
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowRecords_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select a Filter options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Popup Notification for critical products
            Alert.Show("Generating Top Selling Products into a Report.", Alert.AlertType.success);

            ShowRecordsOfTopSellingProducts();
            DisplayChartTopSelling();
        }

        private void BtnPrintRecords_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select a Filter options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AdminPreviewTopSelling tra = new AdminPreviewTopSelling(this);
            // Popup Notification for critical products
            Alert.Show("Top Selling Products Report is now ready for printing.", Alert.AlertType.success);

            tra.LoadTopSellingProducts();
            tra.ShowDialog();
        }

        public void DisplayChartTopSelling()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            cn.Open();
            if (cmbTerms.Text == "Quantity")
            {
                da = new SqlDataAdapter("SELECT top 10 proddescrip, isnull(sum(qty),0) as qty  FROM ViewSoldItems WHERE stockdate between '" + bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by proddescrip order by qty desc", cn);
            }
            else if (cmbTerms.Text == "Amount")
            {
                da = new SqlDataAdapter("SELECT top 10 proddescrip, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by proddescrip order by total desc", cn);
            }
            DataSet ds = new DataSet();
            da.Fill(ds, "TOPSELLING");
            TopSellingChart.DataSource = ds.Tables["TOPSELLING"];
            Series series = TopSellingChart.Series[0];
            series.ChartType = SeriesChartType.Area;

            series.Name = "Top Selling by " + cmbTerms.Text + "";
            var chart = TopSellingChart;

            // Set the chart visibility to the User
            TopSellingChart.Visible = true;

            // Set series Xvalue base on value of Sorting
            chart.Series[0].XValueMember = "proddescrip";
            chart.Series[0].IsXValueIndexed = true;
            chart.Series[0].LabelAngle = 45;
            chart.Series[0].YValuesPerPoint = 10;

            if (cmbTerms.Text == "Amount") { chart.Series[0].YValueMembers = "total"; }
            if (cmbTerms.Text == "Quantity") { chart.Series[0].YValueMembers = "qty"; }

            // Set series label format
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = false;
            if (cmbTerms.Text == "Total Amount") { chart.Series[0].LabelFormat = "₱" + "{#,##0.00}"; }
            if (cmbTerms.Text == "Quantity") { chart.Series[0].LabelFormat = "{#,##0}"; }

            // Titles
            chart.Titles[0].TextStyle = TextStyle.Default;
            if (cmbTerms.Text == "Total Amount") { chart.Titles[0].Text = "Top Selling Products Based on Total Amount"; }
            if (cmbTerms.Text == "Quantity") { chart.Titles[0].Text = "Top Selling Products Based on Quantity"; }

            // Close the connection
            cn.Close();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = "Top " + dataGridView1.Rows.Count.ToString() + " Products";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = "Top " + dataGridView1.Rows.Count.ToString() + " Products";
        }
    }
}
