using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace AHKPOSENKTHESIS
{
    public partial class Frm2EditInvoices : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        // Declare a variable as buffer to pass value in discount form
        String id;
        String price;

        String InvoiceDate;

        public int addqty;
        public Frm2EditInvoices()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

            InvoiceDate = bunifuDatepicker1.Value.ToString("MMM-dd-yyyy");

            bunifuCustomLabel1.Text = InvoiceDate;

            DueDateAutomation();
        }

        public void DueDateAutomation()
        {
            if (cbxPayment.Text == "Cash")
            {
                bunifuDatepicker1.Value = DateTime.Now.AddDays(5);
                lblDueDate.Clear();
                lblDueDate.Text = bunifuDatepicker1.Value.ToString("MMM-dd-yyyy");
            }
            else
            {
                bunifuDatepicker1.Value = DateTime.Now.AddDays(30);
                lblDueDate.Clear();
                lblDueDate.Text = bunifuDatepicker1.Value.ToString("MMM-dd-yyyy");
            }
        }

        public void UpdateInvoiceRecords()
        {
            //Update the tblInvoiceRecords Columns Set SalesTotal, Discount, VAT, Vatable, Total and dateupdated.
            cn.Open();
            cm = new SqlCommand("UPDATE tblInvoiceRecords SET salestotal =@sales, discount = @discount, vat =@vat, vatable =@vatable, total = @total WHERE invoiceno = '" + lblInvoiceNo.Text + "'", cn);
            cm.Parameters.AddWithValue("@sales", double.Parse(lblSalesTotal.Text));
            cm.Parameters.AddWithValue("@discount", double.Parse(lblDiscount.Text));
            cm.Parameters.AddWithValue("@vat", double.Parse(lblVAT.Text));
            cm.Parameters.AddWithValue("@vatable", double.Parse(lblVatable.Text));
            cm.Parameters.AddWithValue("total", double.Parse(lblTotalAmount.Text));
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void GetOrderTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSalesTotal.Text);
            double vatable = sales / dbcon.GetVatable(); // Peek Definition is in DatabaseConnection.cs
            double vat = vatable * dbcon.GetVat(); // Peek Definition is in DatabaseConnection.cs


            lblVAT.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblTotalAmount.Text = sales.ToString("#,##0.00");
        }

        public void AddQuantityProcess()
        {
            FrmEditInvoicesQuantity qt = new FrmEditInvoicesQuantity(this);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                addqty = int.Parse(qt.txtQty.Text);

                dataGridView1.Rows[i].Cells[2].Value = addqty;
            }
        }

        // This function is to display the selected product in datagridview of FrmLookup.cs
        public void LoadInvoiceOrder()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                cn.Open();
                cm = new SqlCommand("SELECT i.id, i.prodcode, i.proddescrip, p.proddescrip, i.prodprice, i.qty, i.discount, i.total FROM tblInvoiceOrder as i INNER JOIN tblProduct as p on i.prodcode = p.prodcode WHERE invoiceno like '" + lblInvoiceNo.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    discount += Double.Parse(dr["discount"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), addqty, dr["qty"].ToString(), dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["prodprice"].ToString(), dr["discount"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    hasrecord = true;
                }
                dr.Close();
                cn.Close();
                lblSalesTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                GetOrderTotal();
                //if the datagrid has rows or data, the following buttons is clickable 
                if (hasrecord == true)
                {
                    BtnDiscount.Enabled = true;
                    BtnRecord.Enabled = true;
                    BtnPrint.Enabled = true;
                }
                //if the datagrid has rows or data, the following buttons is unclickable u
                else
                {
                    BtnDiscount.Enabled = true;
                    BtnRecord.Enabled = true;
                    BtnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Prompt a  messagebox to notify the user for a warning

            }
        }

        // Clears the textboxes when the editing of invoice is done 
        private void Clear()
        {
            txtCustomer.Clear();
            txtAddress.Clear();
        }


        private void Frm2EditInvoices_Load(object sender, EventArgs e)
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

            //To compute the ordered products total
            GetOrderTotal();
            DueDateAutomation();
        }

        // Payment Terms > Payment Terms Combo Box
        private void cbxPayment_TextChanged(object sender, EventArgs e)
        {
            if (cbxPayment.Text == "Cheque")
            {
                lblDueDate.Clear(); // clear the lable text first
                Dmdays.Enabled = true;
                Dmdays.Text = "30";
                txtStatus.Text = "Pending"; // return Pending 
                DueDateAutomation();
            }
            else
            {
                lblDueDate.Clear(); // clear the lable text first
                Dmdays.Enabled = false; 
                Dmdays.Text = "0";
                txtStatus.Text = "Paid"; // return Paid
                DueDateAutomation();
            }
        }

        //This will disable option of typing inside the combobox
        private void cbxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //For controlling the text box Billing Address, if the checkbox is true or checked the Billing textbox will be disabled (you cannot type anyhting)
        //else text box is normal, you can change the billing address from shipping address
        private void CheckSame_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSame.CheckState == CheckState.Checked)
            {
                txtBilling.Enabled = false;
                txtBilling.Text = txtAddress.Text;
            }
            else
            {
                txtBilling.Enabled = true;
            }
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    //AUTOCOMPLETE TEXTBOX BASED ON CUSTOMER NAME
                    cn.Open();
                    cm = new SqlCommand("SELECT customername FROM tblCustomer WHERE customername LIKE @name", cn);
                    cm.Parameters.Add(new SqlParameter("@name", "%" + txtCustomer.Text + "%"));
                    cm.ExecuteNonQuery();
                    dr = cm.ExecuteReader();

                    AutoCompleteStringCollection com = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        com.Add(dr.GetString(0));
                    }
                    txtCustomer.AutoCompleteCustomSource = com;
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        private void waterMark1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (waterMark1.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    //AUTOCOMPLETE TEXTBOX BASED ON PRODUCT DESCRIPTION
                    cn.Open();
                    cm = new SqlCommand("SELECT proddescrip FROM tblProduct WHERE proddescrip LIKE @name", cn);
                    cm.Parameters.Add(new SqlParameter("@name", "%" + waterMark1.Text + "%"));
                    cm.ExecuteNonQuery();
                    dr = cm.ExecuteReader();

                    AutoCompleteStringCollection com = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        com.Add(dr.GetString(0));
                    }
                    waterMark1.AutoCompleteCustomSource = com;
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblProduct WHERE proddescrip like '" + waterMark1.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        FrmEditInvoicesQuantity Quantity = new FrmEditInvoicesQuantity(this);
                        Quantity.ProductDetails(dr["prodcode"].ToString(), dr["proddescrip"].ToString(), double.Parse(dr["prodprice"].ToString()), lblInvoiceNo.Text, txtCustomer.Text, int.Parse(dr["prodqty"].ToString()), addqty);
                        Quantity.ShowDialog();
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        private void cbxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Get the values and pass it on discount item form
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index; // Store the value into variable
            id = dataGridView1[1, i].Value.ToString(); // Store the value to a variable (buffer concept); id values passed is equal to specified selected row
            price = dataGridView1[7, i].Value.ToString(); // Store the value to a variable; value will be equal to specified row selected and cell [Amount]
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceOrder WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    // Prompt a side popup notification 
                    Alert.Show("Item Removed", Alert.AlertType.success);
                    LoadInvoiceOrder();
                }
            }
        }

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            if (lblInvoiceNo.Text == "00000000000")
            {
                return;
            }
            FrmEditInvoiceLookUp look = new FrmEditInvoiceLookUp(this);
            look.LoadShitData();
            look.ShowDialog();
            look.BringToFront();
        }

        // Open the dialog form for discounting an item
        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Sorry! There are no Product needs to be Discounted.", "Discount Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                FrmEditInvoiceDiscount dog = new FrmEditInvoiceDiscount(this);
                dog.lblID.Text = id;
                dog.txtPrice.Text = price;
                dog.ShowDialog();
            }
        }

        // Save the invoice and store it in invoice list
        // Show the print preview of the invoice receipt
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Customer name and Address to Continue!", "Printing Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        // SQL<tblInvoiceRecords> Update the customer information if somehow the user edit out any value
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceRecords SET customer =@customer, address= @address, payment =@payment, days = @days, duedate = @duedate, billaddress = @billaddress, status =@status WHERE id like '" + lblID.Text + "' and invoiceno like '" + lblInvoiceNo.Text + "'", cn);
                        cm.Parameters.AddWithValue("customer", txtCustomer.Text);
                        cm.Parameters.AddWithValue("address", txtAddress.Text);
                        cm.Parameters.AddWithValue("payment", cbxPayment.Text);
                        cm.Parameters.AddWithValue("days", Dmdays.Text);
                        cm.Parameters.AddWithValue("duedate", DueDateCalendar.Value.ToString("yyyyMMdd"));
                        cm.Parameters.AddWithValue("billaddress", txtBilling.Text);
                        cm.Parameters.AddWithValue("status", txtStatus.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // SQL<tblProduct> Update the quantity of the onhand product;  
                        // SQL<tblProduct> Subtract the quantity of ordered product in datagrid 
                        // For the sake of the inventory purposes
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET prodqty = prodqty - '" + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "' WHERE prodcode = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // SQL<tblInvoiceOrder> Update the status to 'Sold' after the recording procesed
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceOrder SET status = 'Sold' WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    // Shows the Print preview of the Invoice before Printing
                    FrmInvoiceEditPrintPreview prev = new FrmInvoiceEditPrintPreview(this);
                    prev.ShowDialog();

                    UpdateInvoiceRecords();
                    LoadInvoiceOrder();
                    UpdateTheCustomerInfoInInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        // Save the invoice and store it in invoice list
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Customer name and Address to Continue!", "Saving Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        // SQL<tblInvoiceRecords> Update the customer information if somehow the user edit out any value
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceRecords SET customer =@customer, address= @address, payment =@payment, days = @days, duedate = @duedate, billaddress = @billaddress, status =@status WHERE id like '" + lblID.Text + "' and invoiceno like '" + lblInvoiceNo.Text + "'", cn);
                        cm.Parameters.AddWithValue("customer", txtCustomer.Text);
                        cm.Parameters.AddWithValue("address", txtAddress.Text);
                        cm.Parameters.AddWithValue("payment", cbxPayment.Text);
                        cm.Parameters.AddWithValue("days", Dmdays.Text);
                        cm.Parameters.AddWithValue("duedate", DueDateCalendar.Value);
                        cm.Parameters.AddWithValue("billaddress", txtBilling.Text);
                        cm.Parameters.AddWithValue("status", txtStatus.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // SQL<tblProduct> Update the quantity of the onhand product;  
                        // SQL<tblProduct> Subtract the quantity of ordered product in datagrid 
                        // For the sake of the inventory purposes
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET prodqty = prodqty - '" + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "' WHERE prodcode = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // SQL<tblInvoiceOrder> Update the status to 'Sold' after the recording procesed
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceOrder SET status = 'Sold' WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    // This will reload the DataGrid upon closing this form
                    RefreshInvoiceRecords();
                    UpdateInvoiceRecords();
                    LoadInvoiceOrder();
                    UpdateTheCustomerInfoInInvoiceOrder();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        public void RefreshInvoiceRecords()
        {
            Frm2SavedInvoices coms = new Frm2SavedInvoices();

            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-purchase-order-30.png");

            int i = 0;
            coms.dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblInvoiceRecords WHERE customer like '%" + coms.txtSearch.Text + "%' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                coms.dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), double.Parse(dr[4].ToString()).ToString("#,##0.00"), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void UpdateTheCustomerInfoInInvoiceOrder()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tblInvoiceOrder SET customer = @customer, address = @address, billaddress = @billaddress WHERE invoiceno like '" + lblInvoiceNo.Text + "'", cn);
            cm.Parameters.AddWithValue("customer", txtCustomer.Text);
            cm.Parameters.AddWithValue("address", txtAddress.Text);
            cm.Parameters.AddWithValue("billaddress", txtBilling.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        // Customer Information > Same as Billing Address
        private void ChkSameBill_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSameBill.CheckState == CheckState.Checked) // Checked State or 1 or Active
            {
                txtBilling.Enabled = false;
                txtBilling.Text = txtAddress.Text; // Copy the values from Customer's shipping address textbox
            }
            else
            {
                txtBilling.Enabled = true; // Billing will be enabled and ready to typed any text values
            }
        }
    }
}





