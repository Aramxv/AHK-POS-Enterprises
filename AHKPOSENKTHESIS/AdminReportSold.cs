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

namespace AHKPOSENKTHESIS
{
    public partial class AdminReportSold : UserControl
    {
        // Declare sqlconnection Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String SoldStartDate;
        String SoldEndDate;

        public AdminReportSold()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the date to current date
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;

            // Store a value of datetimepicker to a variable
            SoldStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            SoldEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            // Print the stored value of the variable
            bunifuCustomLabel1.Text = SoldStartDate;
            bunifuCustomLabel2.Text = SoldEndDate;
        }

        private void AdminReportSold_Load(object sender, EventArgs e)
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

        private void AdminReportSold_Click(object sender, EventArgs e)
        {
            UnCollapeSettings();
        }

        //Load the Sold Products with filter such as Date
        public void ShowSoldProductsRecords()
        {
            try
            {
                int i = 0;
                double _total = 0;
                double _discount = 0;
                double _qty = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT c.prodcode, p.proddescrip, c.prodprice, sum(c.qty) as total_qty, sum(c.discount) as total_discount, sum(c.total) as total_total from tblInvoiceOrder as c inner join tblProduct as p on c.prodcode = p.prodcode where status like 'Sold' and stockdate between '" + bunifuDatepicker1.Value.ToString("yyyyMMdd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyyMMdd") + "' group by c.prodcode, p.proddescrip, c.prodprice", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    _total += double.Parse(dr["total_total"].ToString());
                    _discount += double.Parse(dr["total_discount"].ToString());
                    _qty += double.Parse(dr["total_qty"].ToString());
                    dataGridView1.Rows.Add(i, dr["prodcode"].ToString(), dr["proddescrip"].ToString(), double.Parse(dr["prodprice"].ToString()).ToString("#,##0.00"), dr["total_qty"].ToString(), double.Parse(dr["total_discount"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotalSales.Text = _total.ToString("₱#,##0.00") + " Total Sales";
                lblTotalDiscount.Text = _discount.ToString("₱#,##0.00") + " Total Discount";
                lblQuantityTotal.Text = _qty.ToString("#,###") + " Total Quantity Sold";
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Sold Products Count";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Sold Products Count";
    }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void BtnShowRecords_Click(object sender, EventArgs e)
        {
            // Popup Notification for critical products
            Alert.Show("Generating All Sold Products Report.", Alert.AlertType.success);

            ShowSoldProductsRecords();
        }

        private void BtnPrintRecords_Click(object sender, EventArgs e)
        {
            // Popup Notification for critical products
            Alert.Show("Generating All Sold Products Report.", Alert.AlertType.success);

            AdminPreviewSoldProducts sold = new AdminPreviewSoldProducts(this);
            sold.PreviewSoldReport();
            sold.ShowDialog();
        }
    }
}
