using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AHKPOSENKTHESIS
{
    public partial class FrmReports : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;


        String SalesStartDate;
        String SalesEndDate;

        public FrmReports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            //Set the datetime pickers Value to the system default time and date
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;


            SalesStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            SalesEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            bunifuCustomLabel1.Text = SalesStartDate;
            bunifuCustomLabel2.Text = SalesEndDate;


            LoadSoldProducts();
            LoadStockInBy();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            //Top Selling Products Datagridview
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Sold Products Datagridview
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Stock In History Datagridview
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Track Sales Datagridivew
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Critical Products Datagridview
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView5.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView5.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView5.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView5.BackgroundColor = Color.White;
            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Inventory Report Datagridview
            dataGridView6.BorderStyle = BorderStyle.None;
            dataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView6.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView6.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView6.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView6.BackgroundColor = Color.White;
            dataGridView6.EnableHeadersVisualStyles = false;
            dataGridView6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        //Typing in Combo box will be disabled
        private void CbxCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Load the Sold Products with filter such as Date and status and Name of the Invoicer 
        public void LoadSoldProducts()
        {
            try
            {
                int i = 0;
                double _total = 0;
                dataGridView2.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT c.prodcode, p.proddescrip, c.prodprice, sum(c.qty) as total_qty, sum(c.discount) as total_discount, sum(c.total) as total_total from tblInvoiceOrder as c inner join tblProduct as p on c.prodcode = p.prodcode where status like 'Sold' and stockdate between '" + dt1.Value.ToString("yyyyMMdd") + "' and '" + dt2.Value.ToString("yyyyMMdd") + "' group by c.prodcode, p.proddescrip, c.prodprice", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    _total += double.Parse(dr["total_total"].ToString());
                    dataGridView2.Rows.Add(i, dr["prodcode"].ToString(), dr["proddescrip"].ToString(), double.Parse(dr["prodprice"].ToString()).ToString("#,##0.00"), dr["total_qty"].ToString(), double.Parse(dr["total_discount"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotalSoldAmount.Text = _total.ToString("₱#,##0.00");
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Load the top 10 selling products with filters such as Date and status and group by product code and product description order by quantity in descending order
        public void LoadTopSelling()
        {
            try
            {
                int i = 0;
                cn.Open();
                dataGridView1.Rows.Clear();
                if (cmbSortTop.Text == "Quantity")
                {
                    cm = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + date1.Value.ToString("yyyyMMdd") + "' and '" + date2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by qty desc", cn);
                }
                else if (cmbSortTop.Text == "Total Amount")
                {
                    cm = new SqlCommand("SELECT top 10 prodcode, proddescrip, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + date1.Value.ToString("yyyyMMdd") + "' and '" + date2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by prodcode, proddescrip order by total desc", cn);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("₱#,##0.00"));
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayChartTopSelling()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            cn.Open();
            if (cmbSortTop.Text == "Quantity")
            {
                da = new SqlDataAdapter("SELECT top 10 proddescrip, isnull(sum(qty),0) as qty  FROM ViewSoldItems WHERE stockdate between '" + date1.Value.ToString("yyyyMMdd") + "' and '" + date2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by proddescrip order by qty desc", cn);
            }
            else if (cmbSortTop.Text == "Total Amount")
            {
                da = new SqlDataAdapter("SELECT top 10 proddescrip, isnull(sum(total),0) as total FROM ViewSoldItems WHERE stockdate between '" + date1.Value.ToString("yyyyMMdd") + "' and '" + date2.Value.ToString("yyyyMMdd") + "' and status like 'Sold' group by proddescrip order by total desc", cn);
            }
            DataSet ds = new DataSet();
            da.Fill(ds, "TOPSELLING");
            TopSellingChart.DataSource = ds.Tables["TOPSELLING"];
            Series series = TopSellingChart.Series[0];
            series.ChartType = SeriesChartType.Area;

            series.Name = "TOP SELLING";
            var chart = TopSellingChart;

            TopSellingChart.Visible = true;
            

            // set series Xvalue base on value of Sorting 
            chart.Series[0].XValueMember = "proddescrip";
            chart.Series[0].IsXValueIndexed = true;
            chart.Series[0].LabelAngle = 45;
            chart.Series[0].YValuesPerPoint = 10;





            if (cmbSortTop.Text == "Total Amount") { chart.Series[0].YValueMembers = "total"; }
            if (cmbSortTop.Text == "Quantity") { chart.Series[0].YValueMembers = "qty"; }

            // set series label format
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = false;
            if (cmbSortTop.Text == "Total Amount") { chart.Series[0].LabelFormat = "{₱#,##0.00}"; }
            if (cmbSortTop.Text == "Quantity") { chart.Series[0].LabelFormat = "{#,##0}"; }

            // titles
            chart.Titles[0].TextStyle = TextStyle.Default;
            if (cmbSortTop.Text == "Total Amount") { chart.Titles[0].Text = "Top Selling Products Based on Total Amount"; }
            if (cmbSortTop.Text == "Quantity") { chart.Titles[0].Text = "Top Selling Products Based on Quantity"; }

            cn.Close();
        }

        public void LoadCritical()
        {
            try
            {
                int i = 0;
                dataGridView5.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM ViewCritical order by proddescrip", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView5.Rows.Add(i, dr["id"].ToString(), dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["category"].ToString(), dr["prodqty"].ToString(), dr["warningqty"].ToString(), dr["prodstatus"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadStockInBy()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * from tblUsers WHERE account like 'System Administrator'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    CbxStockBy.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadStockInHistory()
        {
            try
            {
                int i = 0;
                dataGridView3.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM ViewStockIn WHERE cast(stockdate as date) between '" + stockdate1.Value.ToString("yyyyMMdd") + "' and '" + stockdate2.Value.ToString("yyyyMMdd") + "' and status like 'Done' and stockinby like '" + CbxStockBy.Text + "' order by stockdate desc", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadInventory()
        {
            try
            {
                int i = 0;
                dataGridView6.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblProduct order by proddescrip", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView6.Rows.Add(i, dr["id"].ToString(), dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["category"].ToString(), dr["prodprice"].ToString(), dr["prodqty"].ToString(), dr["warningqty"].ToString(), dr["prodstatus"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Load Button of Sold Products tab
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadSoldProducts();
        }
        //Automatically loads the Sold products, Date time picker event of Sold Products tab
        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldProducts();
        }
        //Print Preview Button of Sold Products tab
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FrmSoldProductsPrintPreview rep = new FrmSoldProductsPrintPreview(this);
            rep.LoadSoldReport();
            rep.ShowDialog();
        }
        //Load Button of Top 10 Selling Products
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbSortTop.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Sort Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadTopSelling();
            DisplayChartTopSelling();
        }
        //Print Preview Button of Top 10 Selling Products
        private void BtnPrintTopSelling_Click(object sender, EventArgs e)
        {
            if (cmbSortTop.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Sort Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmTopSellingProductsPrintPreview top = new FrmTopSellingProductsPrintPreview(this);
            top.LoadTopSellingProducts();
            top.ShowDialog();
        }
        //Automatically Loads the Top 10 selling products when the value is changed
        private void date1_ValueChanged(object sender, EventArgs e)
        {
            //  LoadTopSelling();
        }
        //Load Button of Stock In tab
        private void BtnLoadStockIn_Click(object sender, EventArgs e)
        {
            if (CbxStockBy.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Stock-In By Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadStockInHistory();
        }
        //Automatically Loads the Stock in History when picked a date
        private void stockdate1_ValueChanged(object sender, EventArgs e)
        {
            //  LoadStockInHistory();
        }
        //Print Preview Button of Stock In History
        private void BtnPrintStockIn_Click(object sender, EventArgs e)
        {
            if (CbxStockBy.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Stock-In By Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmStockInPrintPreview stock = new FrmStockInPrintPreview(this);
            stock.LoadStockInReport();
            stock.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");
        }

        public void ShowAdvancedOptions()
        {
            label2.Visible = true;
            bunifuDatepicker1.Visible = true;
            bunifuDatepicker2.Visible = true;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel2.Visible = true;

        }

        public void HideAdvancedOptions()
        {
            label2.Visible = false;
            bunifuDatepicker1.Visible = false;
            bunifuDatepicker2.Visible = false;
            bunifuCustomLabel1.Visible = false;
            bunifuCustomLabel2.Visible = false;

        }

        private void BtnLoadCritical_Click(object sender, EventArgs e)
        {
            LoadCritical();
        }

        private void BtnLoadInventory_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void BtnPrintCritical_Click(object sender, EventArgs e)
        {
            FrmCriticalPreview crit = new FrmCriticalPreview(this);
            crit.LoadCritical();
            crit.Show();

        }

        private void BtnPrintInventory_Click(object sender, EventArgs e)
        {
            FrmInventoryPreview inv = new FrmInventoryPreview(this);
            inv.LoadInventory();
            inv.Show();
        }

        private void cmbSortTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbxStockBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoadTrackSales_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Payment Terms Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadTrackSales();
        }

        private void BtnPrintTrackSales_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Payment Terms Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmTrackSalesPreview tra = new FrmTrackSalesPreview(this);
            tra.LoadTrackSales();
            tra.ShowDialog();
        }

        public void LoadTrackSales()
        {
            try
            {
                int i = 0;
                double _salestotal = 0;
                dataGridView4.Rows.Clear();
                cn.Open();
                if (cmbTerms.Text == "Cash")
                {
                    cm = new SqlCommand("SELECT customer, address, payment, sum(vat) as total_vat, sum(vatable) as total_vatable, sum(discount) as total_discount, sum(salestotal) as total FROM tblInvoiceRecords WHERE datecreated between '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' and payment like '" + cmbTerms.Text + "' group by customer, address, payment, datecreated order by datecreated desc", cn);
                }
                else
                {
                    cm = new SqlCommand("SELECT customer, address, payment, sum(vat) as total_vat, sum(vatable) as total_vatable, sum(discount) as total_discount, sum(salestotal) as total FROM tblInvoiceRecords WHERE datecreated between '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' and payment like '" + cmbTerms.Text + "' group by customer, address, payment, datecreated order by datecreated desc", cn);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    _salestotal += double.Parse(dr["total"].ToString());
                    dataGridView4.Rows.Add(i, dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), double.Parse(dr["total_vat"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_vatable"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_discount"].ToString()).ToString("#,##0.00"), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotalSales.Text = _salestotal.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
