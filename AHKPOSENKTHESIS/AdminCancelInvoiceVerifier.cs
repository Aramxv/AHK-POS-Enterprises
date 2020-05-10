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
    public partial class AdminCancelInvoiceVerifier : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        AdminInvoices inv;

        int Reasoncount = 0;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String InvoiceDate;
        String SalesDate;

        public AdminCancelInvoiceVerifier(AdminInvoices voice)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;

            // Pass the value of date picker to invoice date label
            InvoiceDate = bunifuDatepicker1.Value.ToString("MMM-dd-yyyy");
            bunifuCustomLabel1.Text = InvoiceDate;

            // Pass the value of date picker to sales date label
            SalesDate = bunifuDatepicker2.Value.ToString("MMM-dd-yyyy");
            bunifuCustomLabel2.Text = SalesDate;

            inv = voice;
        }

        private void AdminCancelInvoiceVerifier_Load(object sender, EventArgs e)
        {
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

            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 5, 0, 5);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }

        public void InsertionOfCancelledInvoice()
        {
            try
            {
                //Insert Information of the cancelled invoice in tblCancellInvoice
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblCancelInvoice (invoiceno, customer, address, payment, days, vat, vatable, discount, total, canceldate, cancelby, reason) VALUES (@invoiceno, @customer, @address, @payment, @days, @vat, @vatable, @discount, @total, @canceldate, @cancelby, @reason)", cn);
                cm.Parameters.AddWithValue("@invoiceno", lblInvoiceNo.Text);
                cm.Parameters.AddWithValue("@customer", txtCustomer.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                cm.Parameters.AddWithValue("@payment", cbxPayment.Text);
                cm.Parameters.AddWithValue("@days", int.Parse(Dmdays.Text));
                cm.Parameters.AddWithValue("@vat", lblVAT.Text);
                cm.Parameters.AddWithValue("@vatable", lblVatable.Text);
                cm.Parameters.AddWithValue("@discount", lblDiscount.Text);
                cm.Parameters.AddWithValue("@total", lblTotalAmount.Text);
                cm.Parameters.AddWithValue("@canceldate", bunifuDatepicker1.Value.ToString("ddMMMyyyy"));
                cm.Parameters.AddWithValue("@cancelby", txtUsername.Text);
                cm.Parameters.AddWithValue("@reason", txtReason.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Invoice Cancelled Successfully.", "Cancelled Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MoveInvoiceInCancelledInvoice()
        {
            cn.Open();
            cm = new SqlCommand("DELETE FROM tblInvoiceRecords WHERE id like '" + lblID.Text + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }


        public void GetOrderTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblSalesTotal.Text);
            double vatable = sales / dbcon.GetVatable();
            double vat = vatable * dbcon.GetVat();


            lblVAT.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblTotalAmount.Text = sales.ToString("#,##0.00");
        }

        private void BtnCancelNow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (MessageBox.Show("Areyou sure you want to Cancel this Invoice?", "Cancelling Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (txtReason.Text == String.Empty)
                        {
                            MessageBox.Show("Please provide a reason for cancelling this invoice for future references. Thank you!", "Cancelling Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtReason.Focus();
                            return;
                        }
                        else
                        {
                            if (cmbInventory.selectedValue == "Yes")
                            {
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    //Get the products quantity back to the inventory
                                    cn.Open();
                                    cm = new SqlCommand("UPDATE tblProduct SET prodqty = prodqty + '" + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "' WHERE prodcode like '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'", cn);
                                    cm.ExecuteNonQuery();
                                    cn.Close();

                                    //Update the status to 'cancelled' after the cancelling invoice processed
                                    cn.Open();
                                    cm = new SqlCommand("UPDATE tblInvoiceOrder SET status = 'Cancelled' WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                                    cm.ExecuteNonQuery();
                                    cn.Close();

                                }
                                InsertionOfCancelledInvoice();
                                MoveInvoiceInCancelledInvoice();
                                this.Dispose();
                            }
                            else
                            {
                                InsertionOfCancelledInvoice();
                                this.Dispose();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CharacterTextboxRemarksCount()
        {
            Reasoncount = txtReason.Text.Length;               // simply gettin the current length value of remarks textbox element
            lblReasonCount.Text = Reasoncount.ToString() + "/120"; // and convert the integer (int) to string for output
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            CharacterTextboxRemarksCount();
        }

        private void lblInvoiceNo_Click(object sender, EventArgs e)
        {

        }
    }
}
