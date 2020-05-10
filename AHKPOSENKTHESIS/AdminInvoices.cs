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
    public partial class AdminInvoices : UserControl
    { 
        // Declare Connection
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        String InvoiceStartDate;
        String InvoiceEndDate;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public AdminInvoices()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the value of two date picker to datetime.now
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;


            InvoiceStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            InvoiceEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            bunifuCustomLabel1.Text = InvoiceStartDate;
            bunifuCustomLabel2.Text = InvoiceEndDate;
        }

        public void ShowAllInvoices()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblInvoiceRecords WHERE customer like '%" + txtSearch.Text + "%' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
                //  dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        public void DraftInvoiceIndicator()
        {
            // Create a loop
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[16].Value.ToString() == "Draft")
                {
                    // Change the picture of the cell that is in critical quantity count 
                    Image draftimg = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_draft.png");

                    // Add a row set the value
                    dataGridView1.Rows[i].Cells[1].Value = draftimg;
                }
            }
        }

        public void PopulateCustomerNameCombobox()
        {
            cmbCustomer.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT customername from tblCustomer", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbCustomer.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void ShownEntriesOption()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbShown.Text == "25")
            {
                cm = new SqlCommand("SELECT top 25 * FROM tblInvoiceRecords order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "50")
            {
                cm = new SqlCommand("SELECT top 50 * FROM tblInvoiceRecords order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "75")
            {
                cm = new SqlCommand("SELECT top 75 * FROM tblInvoiceRecords order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "All")
            {
                cm = new SqlCommand("SELECT * FROM tblInvoiceRecords order by invoiceno desc", cn);

            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
                //dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        public void SortByPaymentTerms()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbSort.Text == "All")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords order by datecreated desc", cn);
            }
            else if (cmbSort.Text == "Cash")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbSort.Text + "' order by invoiceno desc", cn);
            }
            else if (cmbSort.Text == "Cheque")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbSort.Text + "' order by invoiceno desc", cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
            }
            DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        public void ShowInvoicesOfSelectedCustomer()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE customer like '" + cmbCustomer.Text + "' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++; 
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
            }
            DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        public void FilterByDate()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\invoice_approved.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE datecreated between '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString(), dr["status"].ToString(), dr["remarks"].ToString(), dr["prvcomment"].ToString());
            }
            DraftInvoiceIndicator();
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customer's Invoice Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customer's Invoice Shown";
        }

        private void AdminInvoices_Load(object sender, EventArgs e)
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCustomer"))
            {
                AdminCustomer cust = new AdminCustomer();
                cust.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(cust);

                cust.ShowCustomersInformation();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCustomer"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnRoutes_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminRoutes"))
            {
                AdminRoutes route = new AdminRoutes();
                route.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(route);

                route.ShowRoutes();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminRoutes"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnCancelledInvoices_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCancelInvoice"))
            {
                AdminCancelInvoice can = new AdminCancelInvoice();
                can.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(can);

                can.ShowAllCancelInvoice();
                can.PopulateCustomerNameCombobox();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCancelInvoice"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                // Show the Update Invoice usercontrol 
                // Compute automatically the amount of the ordered products
                if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminUpdateInvoice"))
                {
                    AdminUpdateInvoice update = new AdminUpdateInvoice();
                    update.Dock = DockStyle.Fill;
                    AdminAdministrator.Instance.PnlContainer.Controls.Add(update);

                    update.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    update.lblInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    update.txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    update.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    update.cbxPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    update.Dmdays.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    update.txtBilling.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                    update.lblSalesTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    update.lblDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    update.lblVAT.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    update.lblVatable.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    update.lblTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    update.txtRemarks.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                    update.txtPrvComment.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                    update.dataGridView1.Rows.Clear();
                    update.DueDateAutomation();

                    int i = 0;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        update.dataGridView1.Rows.Add(i, dr[0].ToString(), dr[7].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString());
                    }
                    cn.Close();
                    update.GetOrderTotal();
                }
                AdminAdministrator.Instance.PnlContainer.Controls["AdminUpdateInvoice"].BringToFront();
                AdminAdministrator.Instance.BackButton.Visible = false;
                AdminAdministrator.Instance.BackToInvoiceButton.Visible = true;
                AdminAdministrator.Instance.BackToInvoiceButton.Location = new System.Drawing.Point(8, 9);
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Invoice?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    ShowAllInvoices();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceRecords WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Invoice Successfully Deleted.", "Deleting Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllInvoices();
                }
            }
            else if (colName == "Cancel")
            {
                if (MessageBox.Show("Are you sure you want to Cancel this Invoice? Once this done, You can never get the Invoice back!", "Cancelling Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCancelInvoiceVerifier"))
                    {
                        AdminCancelInvoiceVerifier cancel = new AdminCancelInvoiceVerifier(this);
                        cancel.Dock = DockStyle.Fill;
                        AdminAdministrator.Instance.PnlContainer.Controls.Add(cancel);

                        cancel.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        cancel.lblInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        cancel.txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        cancel.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        cancel.cbxPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                        cancel.Dmdays.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                        cancel.lblSalesTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        cancel.lblDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                        cancel.lblVAT.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                        cancel.lblVatable.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                        cancel.lblTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                        cancel.dataGridView1.Rows.Clear();

                        int i = 0;
                        cn.Open();
                        cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            i++;
                            cancel.dataGridView1.Rows.Add(i, dr[0].ToString(), dr[7].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString());
                        }
                        cn.Close();
                        //Compute automatically the amount of the ordered products
                        cancel.txtUsername.Text = AdminAdministrator.PassCanName;
                        cancel.GetOrderTotal();
                        cancel.Show();
                    }
                    AdminAdministrator.Instance.PnlContainer.Controls["AdminCancelInvoiceVerifier"].BringToFront();
                    AdminAdministrator.Instance.BackButton.Visible = false;
                    AdminAdministrator.Instance.BackToInvoiceButton.Visible = true;
                    AdminAdministrator.Instance.BackToInvoiceButton.Location = new System.Drawing.Point(8, 9);
                }
            }
        }

        private void cmbShown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShownEntriesOption();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortByPaymentTerms();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInvoicesOfSelectedCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowAllInvoices();
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            cmbShown.Text = "All";
            cmbSort.Text = "All";
            cmbCustomer.SelectedIndex = -1;

            ShowAllInvoices();
        }

        private void BtnFilterByDate_Click(object sender, EventArgs e)
        {
            if (PnlFilter.Visible == false)
            {
                PnlFilter.Visible = true;
            }
            else
            {
                PnlFilter.Visible = false;
            }
        }

        private void AdminInvoices_Click(object sender, EventArgs e)
        {
            if (PnlFilter.Visible == true)
            {
                PnlFilter.Visible = false;
            }
            else
            {
                PnlFilter.Visible = false;
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            FilterByDate();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnOverdueInvoices_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminOverdueInvoices"))
            {
                AdminOverdueInvoices over = new AdminOverdueInvoices();
                over.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(over);

                over.DisplayOverdueInvoice();
                over.PopulateCustomerNameCombobox();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminOverdueInvoices"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnPaidInvoices_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminApprovedInvoices"))
            {
                AdminApprovedInvoices app = new AdminApprovedInvoices();
                app.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(app);

                app.ShowAllApprovedInvoices();
                app.PopulateCustomerNameCombobox();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminApprovedInvoices"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }
    }
}
