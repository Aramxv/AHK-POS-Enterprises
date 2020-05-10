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
    public partial class AdminCustomerInvoices : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        AdminCustomer customer;

        public AdminCustomerInvoices(AdminCustomer per)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            customer = per;

            ShowInvoiceByCustomer();
        }

        public void ShowInvoiceByCustomer()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            double _salesTotal = 0;
            double _totalDiscount = 0;
            double _totalVat = 0;
            double totalVatable = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, invoiceno, customer, address, sum(salestotal) as sales_total, sum(discount) as total_discount, sum(vat) as total_vat, sum(vatable) as total_vatable,  sum(total) as total_total, payment, days, billaddress, datecreated, duedate, status, remarks, prvcomment  FROM tblInvoiceRecords WHERE customer like '" + customer.label2.Text + "' and address like '" + customer.label4.Text + "' group by id, invoiceno, customer, address, payment, days, billaddress, duedate, status, remarks, prvcomment, datecreated order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                _salesTotal += double.Parse(dr["sales_total"].ToString());
                _totalDiscount += double.Parse(dr["total_discount"].ToString());
                _totalVat += double.Parse(dr["total_vat"].ToString());
                totalVatable += double.Parse(dr["total_vatable"].ToString());
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["sales_total"].ToString(), dr["total_discount"].ToString(), dr["total_vat"].ToString(), dr["total_vatable"].ToString(), dr["total_total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());  
            }
            lblTotal.Text = "₱ "+ _salesTotal.ToString("#,##0.00") +" Sales Total";
            lblTotalDiscount.Text = "₱ " + _totalDiscount.ToString("#,##0.00") + " Discount Total";
            lblTotalVat.Text = "₱ " + _totalVat.ToString("#,##0.00") + " VAT Total";
            lblTotalVatable.Text = "₱ " + totalVatable.ToString("#,##0.00") + " Vatable Total";
            //DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            AdminAdministrator.Instance.PnlContainer.Controls.Clear();
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCustomer"))
            {
                AdminCustomer customer = new AdminCustomer();
                customer.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(customer);

                customer.ShowCustomersInformation();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCustomer"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void AdminCustomerInvoices_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers Invoice Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers Invoice Shown";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Invoice?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    ShowInvoiceByCustomer();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceRecords WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Invoice Successfully Deleted.", "Deleting Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowInvoiceByCustomer();
                }
            }
        }
    }
}
