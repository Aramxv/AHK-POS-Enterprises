using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmQuantity : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        string titlesataas = "Quantity";

        FrmCreateNewInvoice F2;

        private String transno;
        private String customer;
        private String prodcode;
        private String proddescrip;
        private double prodprice;
        private int qty;

        public FrmQuantity(FrmCreateNewInvoice frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            F2 = frm;

            this.KeyPreview = true;
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {

        }

        public void ProductDetails(String prodcode, String proddescrip, double prodprice, String transno, String customer, int qty)
        {
            this.prodcode = prodcode;
            this.proddescrip = proddescrip;
            this.prodprice = prodprice;
            this.transno = transno;
            this.customer = customer;
            this.qty = qty;
        }

        private void FrmQuantity_Load(object sender, EventArgs e)
        {

        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 46)
                {
                    //accept .(for cents or decimal places)
                }
                else if (e.KeyChar == 8)
                {
                    //accept backspace 
                }
                else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48 - 57 between 0-9
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
                {
                    bool found = false;
                    String id = "";
                    int invoice_qty = 0;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno = @invoiceno and prodcode = @prodcode", cn);
                    cm.Parameters.AddWithValue("@invoiceno", F2.lblInvoiceNo.Text);
                    cm.Parameters.AddWithValue("@prodcode", prodcode);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        id = dr["id"].ToString();
                        invoice_qty = int.Parse(dr["qty"].ToString());
                    }
                    else
                    {
                        found = false;
                    }
                    dr.Close();
                    cn.Close();

                    if (found == true)
                    {
                        //For Stock Validation Condition
                        if (qty < int.Parse(txtQty.Text) + invoice_qty)
                        {
                            MessageBox.Show("Unable to Proceed, Remaining Quantity of product on hand is " + qty, "Stock Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceOrder SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE id = '" + id + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        F2.LoadInvoiceOrder();
                        this.Dispose();
                    }
                    else
                    {
                        //For Stock Validation Condition
                        if (qty < int.Parse(txtQty.Text) + invoice_qty)
                        {
                            MessageBox.Show("Unable to Proceed. The Remaining Quantity of the product on hand is " + qty, "Stock Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        FrmCreateNewInvoice inv = new FrmCreateNewInvoice();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblInvoiceOrder (invoiceno, customer, address, prodcode, proddescrip, prodprice, qty, stockdate, name, payment, days, billaddress, duedate) VALUES (@invoiceno, @customer, @address, @code, @desc, @price, @qty, @date, @name, @payment, @days, @bill, @duedate)", cn);
                        cm.Parameters.AddWithValue("@invoiceno", transno);
                        cm.Parameters.AddWithValue("@customer", F2.txtCustomer.Text);
                        cm.Parameters.AddWithValue("@address", F2.txtAddress.Text);
                        cm.Parameters.AddWithValue("@code", prodcode);
                        cm.Parameters.AddWithValue("@desc", proddescrip);
                        cm.Parameters.AddWithValue("@price", prodprice);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@name", F2.lblUsername.Text);
                        cm.Parameters.AddWithValue("@date", F2.bunifuDatepicker1.Value);
                        cm.Parameters.AddWithValue("@payment", F2.cbxPayment.Text); ;
                        cm.Parameters.AddWithValue("@days", F2.Dmdays.Text);
                        cm.Parameters.AddWithValue("@bill", F2.txtBilling.Text);
                        cm.Parameters.AddWithValue("@duedate", F2.DueDateCalendar.Value.ToString("yyyyMMdd"));
                        cm.ExecuteNonQuery();
                        cn.Close();

                        F2.LoadInvoiceOrder();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            //    MessageBox.Show("Product Quantity is now insufficient.", "Stock Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
