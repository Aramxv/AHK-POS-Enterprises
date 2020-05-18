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
    public partial class AdminUpdateInvoice : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        // Declare a variable for storing a value to pass value in discount form
        String id;
        String price;

        // Variable for storing the datepicker value to be able to send to date label
        String InvoiceDate;
        String SalesDate;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        // variable for character counting in remarks and private comment section
        int remcharcount = 0;
        int prvcharcount = 0;

        public AdminUpdateInvoice()
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

            DueDateAutomation();
        }

        public void DueDateAutomation()
        {
            if (cbxPayment.Text == "Cash")
            {
                DueDateCalendar.Value = DateTime.Now.AddDays(5);
                lblDueDate.Clear();
                lblDueDate.Text = DueDateCalendar.Value.ToString("MMM-dd-yyyy");
            }
            else
            {
                DueDateCalendar.Value = DateTime.Now.AddDays(30);
                lblDueDate.Clear();
                lblDueDate.Text = DueDateCalendar.Value.ToString("MMM-dd-yyyy");
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
                cm = new SqlCommand("SELECT i.id, i.prodcode, i.proddescrip, i.prodprice, i.qty, i.discount, i.total FROM tblInvoiceOrder as i INNER JOIN tblProduct as p on i.prodcode = p.prodcode WHERE invoiceno like '" + lblInvoiceNo.Text + "' order by proddescrip", cn);
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
                    BtnSaveInvoice.Enabled = true;
                    BtnPrintPreview.Enabled = true;
                }
                //if the datagrid has rows or data, the following buttons is unclickable u
                else
                {
                    BtnDiscount.Enabled = true;
                    BtnSaveInvoice.Enabled = true;
                    BtnPrintPreview.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Prompt a  messagebox to notify the user for a warning

            }
        }


        private void RemarksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminUpdateInvoice_Load(object sender, EventArgs e)
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

            // To compute the ordered products total
            GetOrderTotal();
            // Automatically add days to due date datepicker
            DueDateAutomation();
            // Populate Customer name in the Customer combobox
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
            AdminInvoices invoice = new AdminInvoices();

            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            invoice.dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblInvoiceRecords WHERE customer like '%" + invoice.txtSearch.Text + "%' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                invoice.dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
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

        public void AddDiscountToProducts()
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
        public void PopulateCustomerNameCombobox()
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

        public void RelocateAndShowBillingPanel()
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
            BillingPanel.Location = new System.Drawing.Point(678, 107);
        }

        public void RelocateAndShowPaymentPanel()
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
            PaymentPanel.Location = new System.Drawing.Point(678, 107);
        }

        public void RelocateAndShowRemarksPanel()
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
            RemarksPanel.Location = new System.Drawing.Point(678, 107);
        }

        public void CharacterTextboxRemarksCount()
        {
            remcharcount = txtRemarks.Text.Length;               // simply gettin the current length value of remarks textbox element
            lblRemCount.Text = remcharcount.ToString() + "/100"; // and convert the integer (int) to string for output
        }

        public void CharacterTextboxPrivateCommentCount()
        {
            prvcharcount = txtPrvComment.Text.Length;             // simply getting the current length value of private comment textbox element
            lblPrvCount.Text = prvcharcount.ToString() + "100";   // and convert the integer (int) to string for output
        }

        public void IfSameAddressChecked()
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

        public void IfSameBillingAddressChecked()
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

        public void ValidateSelectProduct()
        {
            if (lblInvoiceNo.Text == "00000000000")
            {
                return;
            }
            FrmEditInvoiceLookUp look = new FrmEditInvoiceLookUp(this);
            look.LoadShitData();
            look.ShowDialog();
        }

        // Billing Address > Same as Shipping Address
        private void CheckSameAdd_CheckedChanged(object sender, EventArgs e)
        {
            IfSameAddressChecked();
        }

        // Customer Information > Same as Billing Address
        private void ChkSameBill_CheckedChanged(object sender, EventArgs e)
        {
            IfSameBillingAddressChecked();
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

        private void cbxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
            CharacterTextboxRemarksCount();
        }

        private void txtPrvComment_TextChanged(object sender, EventArgs e)
        {
            CharacterTextboxPrivateCommentCount();
        }

        private void BtnBilling_Click(object sender, EventArgs e)
        {
            RelocateAndShowBillingPanel();
        }


        private void BtnPayment_Click(object sender, EventArgs e)
        {
            RelocateAndShowPaymentPanel();
        }

        private void BtnRemarks_Click(object sender, EventArgs e)
        {
            RelocateAndShowRemarksPanel();
        }

        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            AddDiscountToProducts();
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products";
        }

        private void txtCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCustomerNameCombobox();
        }

        private void AdminUpdateInvoice_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            ValidateSelectProduct();
        }

        private void BtnPrintPreview_Click_1(object sender, EventArgs e)
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
                    // Pop-up a side notification
                    Alert.Show("Saved Successfully", Alert.AlertType.success);

                    // Shows the Print preview of the Invoice before Printing
                    FrmInvoiceEditPrintPreview prev = new FrmInvoiceEditPrintPreview(this);
                    prev.ShowDialog();
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                    UpdateTheCustomerInfoInInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Oops Something came up", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        private void BtnSaveInvoice_Click_1(object sender, EventArgs e)
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
                    // Pop-up a side notification
                    Alert.Show("Saved Successfully", Alert.AlertType.success);

                    // This will reload the DataGrid upon closing this form
                    RefreshInvoiceRecords();
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                    UpdateTheCustomerInfoInInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Oops Something came up", MessageBoxButtons.OK, MessageBoxIcon.Error); // Prompt a  messagebox to notify the user for an error
            }
        }

        private void BtnSaveAsDraft_Click_1(object sender, EventArgs e)
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
                    // Popup a side notification 
                    Alert.Show("Saved as Draft Successfully", Alert.AlertType.success);
                    UpdateDataInInvoiceRecords();
                    LoadInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Oops Something came up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
