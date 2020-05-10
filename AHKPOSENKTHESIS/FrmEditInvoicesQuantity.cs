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

namespace AHKPOSENKTHESIS
{
    public partial class FrmEditInvoicesQuantity : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        string titlesataas = "Quantity";

        AdminUpdateInvoice edit;

        private String transno;
        private String customer;
        private String prodcode;
        private String proddescrip;
        private double prodprice;
        private int qty;
        private int addqty;



        public FrmEditInvoicesQuantity(AdminUpdateInvoice idit)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            edit = idit;

            this.KeyPreview = true;
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

                //Enter = 13
                if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
                {
                    bool found = false;
                    String id = "";

                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno = @invoiceno and prodcode = @prodcode", cn);
                    cm.Parameters.AddWithValue("@invoiceno", edit.lblInvoiceNo.Text);
                    cm.Parameters.AddWithValue("@prodcode", prodcode);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        id = dr["id"].ToString();
                    }
                    else
                    {
                        // if found = false, it will crate new row for new product
                        found = false;
                    }
                    dr.Close();
                    cn.Close();

                    if (found == true)
                    {
                        Frm2EditInvoices up = new Frm2EditInvoices();

                        for (int i = 0; i < up.dataGridView1.Rows.Count; i++)
                        {
                            up.dataGridView1.Rows[i].Cells[2].Value = txtQty.Text;
                        }

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceOrder SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE id = '" + id + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        edit.LoadInvoiceOrder();
                        this.Dispose();
                    }
                    else
                    {
                        FrmMain2 Main2 = new FrmMain2();
                       
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblInvoiceOrder (invoiceno, customer, address, prodcode, proddescrip, prodprice, qty, stockdate, name, payment, days, billaddress) VALUES (@invoiceno, @customer, @address, @code, @desc, @price, @qty, @date, @name, @payment, @days, @bill)", cn);
                        cm.Parameters.AddWithValue("@invoiceno", transno);
                        cm.Parameters.AddWithValue("@customer", edit.txtCustomer.Text);
                        cm.Parameters.AddWithValue("@address", edit.txtAddress.Text);
                        cm.Parameters.AddWithValue("@code", prodcode);
                        cm.Parameters.AddWithValue("@desc", proddescrip);
                        cm.Parameters.AddWithValue("@price", prodprice);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@name", Main2.lblUsername.Text);  
                        cm.Parameters.AddWithValue("@date", edit.bunifuDatepicker1.Value.ToString("ddMMMyyyy"));
                        cm.Parameters.AddWithValue("@payment", edit.cbxPayment.Text); ;
                        cm.Parameters.AddWithValue("@days", edit.Dmdays.Text);
                        cm.Parameters.AddWithValue("@bill", edit.txtBilling.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        edit.LoadInvoiceOrder();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmEditInvoicesQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
