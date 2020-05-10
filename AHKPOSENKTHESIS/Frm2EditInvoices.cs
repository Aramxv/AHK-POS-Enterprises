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

        // variable for character counting in remarks and private comment section
        int remcharcount = 0;
        int prvcharcount = 0;
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

        public void UpdateDataInInvoiceRecords()
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
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["qty"].ToString(), dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["prodprice"].ToString(), dr["discount"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
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
            LoadCustomersFromDatabaseToCustomerCombobox();
        }

     

        // This method is to bind the combobox with database 
        public void LoadCustomersFromDatabaseToCustomerCombobox()
        {
            txtCustomer.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT customername FROM tblCustomer WHERE customername like '%" + txtCustomer.Text + "%' order by customername asc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtCustomer.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
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

        
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (OptionPanel.Visible == false)
            {
                OptionPanel.Visible = true;
                OptionPanel.Location = new System.Drawing.Point(1146, 69); // set the location of option panel under option button
            }
            else
            {
                OptionPanel.Visible = false;
            }
        }

        private void BtnRecord_Click_1(object sender, EventArgs e)
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
                    UpdateDataInInvoiceRecords();
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

        private void BtnPrint_Click_1(object sender, EventArgs e)
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
                    //FrmInvoiceEditPrintPreview prev = new FrmInvoiceEditPrintPreview(this);
                    //prev.ShowDialog();

                    UpdateDataInInvoiceRecords();
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

        private void BtnSaveAsDraft_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the Customer's Name and Address to Create a New Invoice.", "Saving As Draft", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        // SQL<tblInvoiceOrder> Update the status to 'Draft' after the draft processed
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceOrder SET status = 'Draft' WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        // SQL<tblInvoiceRecords> Update the status to 'Draft  after the draft processed
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblInvoiceRecords SET status = 'Draft' WHERE invoiceno like '" + lblInvoiceNo.Text + "' and customer like '" + txtCustomer.Text + "' and address like '" + txtAddress.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    Alert.Show("Saved as Draft Successfully", Alert.AlertType.success);
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save the invoice and store it in invoice list
        // Show the print preview of the invoice receipt
        private void BtnSavePrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the Customer's Name and Address to Create a New Invoice.", "Printing Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
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
                    Alert.Show("Saved Successfully", Alert.AlertType.success);
                    //FrmInvoiceEditPrintPreview inv = new FrmInvoiceEditPrintPreview(this);
                    //inv.ShowDialog();
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the Customer's Name and Address to Create a New Invoice.", "Printing Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
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
                    Alert.Show("Saved Successfully", Alert.AlertType.success);
                    //FrmInvoiceEditPrintPreview inv = new FrmInvoiceEditPrintPreview(this);
                    //inv.ShowDialog();
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Billing Address > Same as Shipping Address
        private void CheckSameAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSameAdd.CheckState == CheckState.Checked) // Cheked State or 1 or Active
            {
                txtBilling.Enabled = false;
                txtBilling.Text = txtAddress.Text; // Copy the text values from Customer's billing address textbox
            }
            else
            {
                txtBilling.Enabled = true; // Billing will be enabled and ready to typed any text values
            }
        }

        // Customer Information > Same as Billing Address
        private void ChkSameBill_CheckedChanged_1(object sender, EventArgs e)
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

        private void cbxPayment_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbxPayment_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
            remcharcount = txtRemarks.Text.Length;               // simply gettin the current length value of remarks textbox element
            lblRemCount.Text = remcharcount.ToString() + "/100"; // and convert the integer (int) to string for output
       
        }

        private void txtPrvComment_TextChanged(object sender, EventArgs e)
        {
            prvcharcount = txtPrvComment.Text.Length;             // simply getting the current length value of private comment textbox element
            lblPrvCount.Text = prvcharcount.ToString() + "100";   // and convert the integer (int) to string for output
        
        }

        // Actions of billing button when clicked
        private void BtnBilling_Click(object sender, EventArgs e)
        {
            // change the forecolor of text to blue Argb(62, 99, 246)
            BtnBilling.ForeColor = System.Drawing.Color.FromArgb(32, 38, 255);
            BtnPayment.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);
            BtnRemarks.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);

            // light indicator
            IndicatorBilling.Visible = true;
            IndicatorPayment.Visible = false;
            IndicatorRemarks.Visible = false;

            // set billin pannel to visible 
            BillingPanel.Visible = true;
            PaymentPanel.Visible = false;
            RemarksPanel.Visible = false;

            // set the location of billing panel
            BillingPanel.Location = new System.Drawing.Point(743, 105);
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            // change the forecolor of text to blue Argb(62, 99, 246)
            BtnBilling.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);
            BtnPayment.ForeColor = System.Drawing.Color.FromArgb(32, 38, 255);
            BtnRemarks.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);

            // light indicator
            IndicatorBilling.Visible = false;
            IndicatorPayment.Visible = true;
            IndicatorRemarks.Visible = false;

            // set billin pannel to visible 
            BillingPanel.Visible = false;
            PaymentPanel.Visible = true;
            RemarksPanel.Visible = false;

            // set the location of billing panel
            PaymentPanel.Location = new System.Drawing.Point(743, 105);
        }

        private void BtnRemarks_Click(object sender, EventArgs e)
        {
            // change the forecolor of text to blue Argb(62, 99, 246)
            BtnBilling.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);
            BtnPayment.ForeColor = System.Drawing.Color.FromArgb(181, 190, 198);
            BtnRemarks.ForeColor = System.Drawing.Color.FromArgb(32, 38, 255);

            // light indicator
            IndicatorBilling.Visible = false;
            IndicatorPayment.Visible = false;
            IndicatorRemarks.Visible = true;

            // set billin pannel to visible 
            BillingPanel.Visible = false;
            PaymentPanel.Visible = false;
            RemarksPanel.Visible = true;

            // set the location of billing panel
            RemarksPanel.Location = new System.Drawing.Point(743, 105);
        }

        private void BtnDiscount_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Sorry! There are no Product needs to be Discounted.", "Discount Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                //FrmEditInvoiceDiscount dog = new FrmEditInvoiceDiscount(this);
                //dog.lblID.Text = id;
                //dog.txtPrice.Text = price;
                //dog.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            // Edit Columns > DataGridViewImageColumn > Unbound Column Properties > Design > Name
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Remove this Item?", "Creating New Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            else if (colName == "ccAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT sum(prodqty) as qty FROM tblProduct WHERE prodcode like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "' group by prodcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) < i)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblInvoiceOrder SET qty = qty + '" + int.Parse(txtQty.Text) + "' WHERE invoiceno like '" + lblInvoiceNo.Text + "' and prodcode like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadInvoiceOrder();
                }
                else
                {
                    MessageBox.Show("Remaining Quantity on hand is " + i + "!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "ccLess")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT sum(qty) as qty FROM tblInvoiceOrder WHERE prodcode like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "' and invoiceno like '" + lblInvoiceNo.Text + "' group by prodcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                // if you somehow change the condition to ( i > 0 ) the row will dissappear if the quantity is equal to 1 and you still cliked the less quantity button 
                if (i > 1)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblInvoiceOrder SET qty = qty - '" + int.Parse(txtQty.Text) + "' WHERE invoiceno like '" + lblInvoiceNo.Text + "' and prodcode like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadInvoiceOrder();
                }
                else
                {
                    MessageBox.Show("Remaining Quantity ordered is " + i + "!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index; // Store the value into variable
            id = dataGridView1[1, i].Value.ToString(); // Store the value to a variable (buffer concept); id values passed is equal to specified selected row
            price = dataGridView1[7, i].Value.ToString(); // Store the value to a variable; value will be equal to specified row selected and cell [Amount]
        }

        // Row count of DGV when a product is added ++ 
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products";
        }

        // Row count of DGV when a product is removed --
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products";
        }

        private void txtCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string billaddress;
            string shippingaddress;

            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCustomer WHERE customername =@customer", cn);
            cm.Parameters.AddWithValue("@customer", txtCustomer.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                shippingaddress = (string)dr["address"].ToString();
                txtAddress.Text = shippingaddress;

                billaddress = (string)dr["billaddress"].ToString();
                txtBilling.Text = billaddress;
            }
            cn.Close();
        }

        private void Frm2EditInvoices_Click(object sender, EventArgs e)
        {
            if (OptionPanel.Visible == true)
            {
                OptionPanel.Visible = false;
            }
            else
            {
                OptionPanel.Visible = false;
            }
        }

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            if (lblInvoiceNo.Text == "00000000000")
            {
                return;
            }
            //FrmEditInvoiceLookUp look = new FrmEditInvoiceLookUp(this);
            //look.LoadShitData();
            //look.ShowDialog();
        }

        // not done yet 
        // configure the buttons to update and not to save data
        // the sub module of this form is not yet updated (design)
    }
}





