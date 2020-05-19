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
    public partial class AdminReportsTrackSales : UserControl
    {
        // Declare sqlconnetion Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String SalesStartDate;
        String SalesEndDate;

        public AdminReportsTrackSales()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the date to current date
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;

            // Store a value of datetimepicker to a variable
            SalesStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            SalesEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            // Print the stored value of the variable
            bunifuCustomLabel1.Text = SalesStartDate;
            bunifuCustomLabel2.Text = SalesEndDate;
        }

        private void AdminReportsTrackSales_Load(object sender, EventArgs e)
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

        private void AdminReportsTrackSales_Click(object sender, EventArgs e)
        {
            UnCollapeSettings();
        }

        public void DisplayTrackSalesReport()
        {
            try
            {
                int i = 0;
                double _salestotal = 0;
                double _discounttotal = 0;
                double _vattotal = 0;
                double _vatabletotal = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                if (cmbTerms.Text == "All")
                {
                    cm = new SqlCommand("SELECT customer, address, payment, sum(vat) as total_vat, sum(vatable) as total_vatable, sum(discount) as total_discount, sum(salestotal) as total FROM tblInvoiceRecords WHERE datecreated between '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' group by customer, address, payment, datecreated order by datecreated desc", cn);

                }
                else if (cmbTerms.Text == "Cash")
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
                    _discounttotal += double.Parse(dr["total_discount"].ToString());
                    _vattotal += double.Parse(dr["total_vat"].ToString());
                    _vatabletotal += double.Parse(dr["total_vatable"].ToString());
                    dataGridView1.Rows.Add(i, dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), double.Parse(dr["total_vat"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_vatable"].ToString()).ToString("#,##0.00"), double.Parse(dr["total_discount"].ToString()).ToString("#,##0.00"), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotalSales.Text = "₱ " + _salestotal.ToString("#,##0.00") + " Total Sales";
                lblTotalDiscount.Text = "₱ " +_discounttotal.ToString("#,##0.00") + " Total Discount";
                lblVATSales.Text = "₱ " + _vattotal.ToString("#,##0.00") + " VAT Sales";
                lblVatableSales.Text = "₱ " + _vatabletotal.ToString("#,##0.00") + " Vatable Sales";
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Show Records
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select a Payment Terms to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Popup Notification for critical products
            Alert.Show("Generating Track Sales Performance into a Report.", Alert.AlertType.success);

            DisplayTrackSalesReport();
        }

        private void BtnPrintRecords_Click(object sender, EventArgs e)
        {
            if (cmbTerms.Text == String.Empty)
            {
                MessageBox.Show("Please Select a Payment Terms to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AdminPreviewTrackSales tra = new AdminPreviewTrackSales(this);
            // Popup Notification for critical products
            Alert.Show("Track Sales Performance Report is now ready for printing.", Alert.AlertType.success);
            tra.LoadTrackSales();
            tra.ShowDialog();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers";
        }

     
    }
}
