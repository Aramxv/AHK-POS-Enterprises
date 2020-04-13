using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace AHKPOSENKTHESIS
{
    public partial class FrmCreateNewInvoice : Form
    {
        // Declare sql variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        int qty;

        // Declare a variable as buffer to pass value in discount form
        String id;
        String price;

        // Declare a variable for updating the order status
        String Pending = "Pending";
        String Paid = "Paid";


        public FrmCreateNewInvoice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

            bunifuDatepicker1.Value = DateTime.Now;

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

        // Generate transaction number based on the last transaction number i++
        public void GetInvoiceNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string invoiceno;
                int count;

                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 invoiceno FROM tblInvoiceRecords WHERE invoiceno like '" + sdate + "%' order by id desc", cn); //print in descending order
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    invoiceno = dr[0].ToString();
                    count = int.Parse(invoiceno.Substring(8, 4));
                    lblInvoiceNo.Text = sdate + (count + 1);

                    // The transaction number will change its font color once its ready or enabled
                    lblInvoiceNo.ForeColor = Color.FromArgb(2, 119, 231);
                }
                else
                {
                    invoiceno = sdate + "1001";
                    lblInvoiceNo.Text = invoiceno;

                    // The transaction number will change its font color once its ready or enabled
                    lblInvoiceNo.ForeColor = Color.FromArgb(2, 119, 231);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadInvoiceRecord()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblInvoiceRecords (invoiceno, customer, address, salestotal, discount, vat, vatable, total, payment, days, billaddress, datecreated, duedate, status) VALUES (@invoice, @customer, @address, @sales, @discount, @vat, @vatable, @total, @payment, @days, @billaddress, @date, @duedate, @status)", cn);
                cm.Parameters.AddWithValue("@invoice", lblInvoiceNo.Text);
                cm.Parameters.AddWithValue("@customer", txtCustomer.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                cm.Parameters.AddWithValue("@sales", lblSalesTotal.Text);
                cm.Parameters.AddWithValue("@discount", lblDiscount.Text);
                cm.Parameters.AddWithValue("@vat", lblVAT.Text);
                cm.Parameters.AddWithValue("@vatable", lblVatable.Text);
                cm.Parameters.AddWithValue("@total", lblTotalAmount.Text);
                cm.Parameters.AddWithValue("@payment", cbxPayment.Text);
                cm.Parameters.AddWithValue("@days", Dmdays.Text);
                cm.Parameters.AddWithValue("@billaddress", txtBilling.Text);
                cm.Parameters.AddWithValue("@date", bunifuDatepicker1.Value);
                cm.Parameters.AddWithValue("@duedate", DueDateCalendar.Value);
                cm.Parameters.AddWithValue("@status", txtStatus.Text);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetOrderTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
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
                dataGridView1.Rows.Clear();

                int i = 0;
                double total = 0;
                double discount = 0;
                Boolean hasrecord = false;

                cn.Open();
                cm = new SqlCommand("SELECT i.id, i.prodcode, i.proddescrip, p.proddescrip, i.prodprice, i.qty, i.discount, i.total FROM tblInvoiceOrder as i INNER JOIN tblProduct as p on i.prodcode = p.prodcode WHERE invoiceno like '" + lblInvoiceNo.Text + "' and status like 'Pending'", cn);
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

                // If the datagrid has rows or data, the following buttons will be clickable
                if (hasrecord == true)
                {
                    BtnDiscount.Enabled = true;
                    BtnRecord.Enabled = true;
                    BtnPrint.Enabled = true;
                }
                else
                {
                    // If the datagrid is null or has no rows or data, still the buttons will be disabled
                    BtnDiscount.Enabled = true;
                    BtnRecord.Enabled = true;
                    BtnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear the texboxes values
        private void Clear()
        {
            txtCustomer.Clear();
            txtAddress.Clear();
            txtBilling.Clear();
            ChkSameBill.Checked = false;
            CheckSameAdd.Checked = false;
            cbxPayment.Text = "Cash";
            Dmdays.Text = "0";
        }

        public void UpdateInvoiceRecords()
        {
            // Update the tblInvoicerecords columns set SalesTotal, Discount, VAT, Vatable, Total and Dateupdated.
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

        // Function for enabling the BOX image in the form
        public void EnableProductSelect()
        {
            label9.Enabled = true;
            BtnSelectProduct.Enabled = true;
        }

        private void CustomerFocus()
        {
            txtCustomer.Focus();
            waterMark1.Enabled = true;
        }

        public void Enabletextboxes()
        {
            txtCustomer.Enabled = true;
            txtAddress.Enabled = true;
        }

        public void EnableContinue()
        {
            bunifuDatepicker1.Enabled = true;
            bunifuCustomLabel1.Enabled = true;
            BtnCreateInvoice.Enabled = true;
            CheckSameAdd.Checked = true;
            ChkSameBill.Enabled = true;
            CheckSameAdd.Enabled = true;
            txtStatus.Enabled = true;
        }

        public void PassTheUsername()
        {
            FrmMain2 main2 = new FrmMain2();
            lblPasslblName.Text = main2.lblUsername.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            // Edit Columns > DataGridViewImageColumn > Unbound Column Properties > Design > Name
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Remove this Item?", "Creating New Invoice", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
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

        // Get the values and pass it on discount item form
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index; // Store the value into variable
            id = dataGridView1[1, i].Value.ToString(); // Store the value to a variable (buffer concept); id values passed is equal to specified selected row
            price = dataGridView1[7, i].Value.ToString(); // Store the value to a variable; value will be equal to specified row selected and cell [Amount]
        }

        private void FrmCreateNewInvoice_Load(object sender, EventArgs e)
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

            // This line of code here is attaching the text of lblUsername in the static string of FrmMain2
            lblUsername.Text = FrmMain2.PasslblName;
        }

        // Autocomplete textbox code 
        // With Error like private memory cannot be processed
        // Incase you need it set the textbox autocomplete properties to bind to this code
        // This will suggest a text value same value you type in the textbox if the value is already exist on the database
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            // SQL<tblCustomer> Autocomplete textbox fill with customer's name
            cn.Open();
            cm = new SqlCommand("SELECT customername FROM tblCustomer WHERE customername LIKE @name", cn);
            cm.Parameters.Add(new SqlParameter("@name", "%" + txtCustomer.Text + "%"));
            dr = cm.ExecuteReader();

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                auto.Add(dr.GetString(0));
            }
            txtCustomer.AutoCompleteCustomSource = auto;
            dr.Close();
            cn.Close();
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

        // Payment Terms > Payment Terms Combo Box
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

        // This will disable option of typing inside the combobox
        private void cbxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Print the value of the datetimepicker
        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("MMM-dd-yyyy");
        }

        private void FrmCreateNewInvoice_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        // Select button for selecting or looking for product list
        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            if (lblInvoiceNo.Text == "00000000000")
            {
                return;
            }
            FrmLookUp look = new FrmLookUp(this);
            look.LoadShitData();
            look.ShowDialog();
        }

        // Create New Invoice and Enable the textboxes in Customer Infomation
        private void BtnNewInvoice_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return;
            }
            else
            {
                Alert.Show("New Invoice is on Process", Alert.AlertType.info);
                GetInvoiceNo();
                Enabletextboxes();
                DueDateAutomation();
                EnableContinue();
                PassTheUsername();
                Clear();
            }
        }

        /*
           Insert the Customer name and address immediately to the database 
           but before that, 
           Validate the Customer name and address, if it is already exist to prevent duplication of data 
        */
        private void BtnCreateInvoice_Click_1(object sender, EventArgs e)
        {
            if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
            {
                MessageBox.Show("Please Fill the Customer's Name and Address to Create A New Invoice.", "Creating New Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("SELECT customername, address FROM tblCustomer where customername = @name and address = @address", cn);
                cm.Parameters.AddWithValue("@name", txtCustomer.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                da = new SqlDataAdapter(cm);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Alert.Show("Customer Exist", Alert.AlertType.success); // Show side popup notification
                    cn.Close();
                    GetInvoiceNo();
                    LoadInvoiceRecord();
                    EnableProductSelect();
                    CustomerFocus();
                }
                cn.Close();
            }
            if (dt.Rows.Count <= 0)
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblCustomer (customername, address, billaddress, payment) VALUES (@customername, @address, @bill, @payment)", cn);
                cm.Parameters.AddWithValue("@customername", txtCustomer.Text);
                cm.Parameters.AddWithValue("@address", txtAddress.Text);
                cm.Parameters.AddWithValue("@bill", txtBilling.Text);
                cm.Parameters.AddWithValue("@payment", cbxPayment.Text);
                cm.ExecuteNonQuery();

                // Pop-up a side notification
                Alert.Show("Customer Retrieved", Alert.AlertType.success); // Show side popup notification
                cn.Close();

                GetInvoiceNo();
                LoadInvoiceRecord();
                EnableProductSelect();
                CustomerFocus();
            }
            else
            {
                return;
            }
        }

        private void lblSalesTotal_MouseHover(object sender, EventArgs e)
        {
            
        }


        // Save the invoice and store it in invoice list
        private void BtnRecord_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text == String.Empty || txtAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the Customer's Name and Address to Create a New Invoice.", "Saving Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    UpdateInvoiceRecords();
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
        private void BtnPrint_Click_1(object sender, EventArgs e)
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
                    FrmInvoicePreview inv = new FrmInvoicePreview(this);
                    inv.ShowDialog();
                    UpdateInvoiceRecords();
                    LoadInvoiceOrder();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open the dialog form for discounting an item
        private void BtnDiscount_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Sorry! There are no Product needs to be Discounted.", "Discount Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                FrmDiscount dog = new FrmDiscount(this);
                dog.lblID.Text = id;
                dog.txtPrice.Text = price;
                dog.ShowDialog();
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
                        FrmQuantity Quantity = new FrmQuantity(this);
                        Quantity.ProductDetails(dr["prodcode"].ToString(), dr["proddescrip"].ToString(), double.Parse(dr["prodprice"].ToString()), lblInvoiceNo.Text, txtCustomer.Text, int.Parse(dr["prodqty"].ToString()));
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
    }
}
