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
    public partial class AdminCustomer : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public int rowindex = 0;

        public AdminCustomer()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            NotAnActiveCustomer();
        }

        public void ShowCustomersInformation()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-customer-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCustomer WHERE customername like '%" + txtSearch.Text + "%' order by customername", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            cn.Close();
            NotAnActiveCustomer();
        }

        public void NotAnActiveCustomer()
        {
            string NotActive = "No";
            try
            {
                // Set a condition where if the cell customer's status value is NO, change the avatar to red or it means that the customer is not active
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[10].Value.ToString() == NotActive)
                        {
                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-customer-24_XXX.png");

                            // Add a row set and set the value;
                            dataGridView1.Rows[i].Cells[1].Value = imglink;
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Customers Shown";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowCustomersInformation();
        }

        private void BtnAddCustomers_Click(object sender, EventArgs e)
        {
            AdminAddCustomer cust = new AdminAddCustomer(this);
            cust.PopulateRouteCombobox();
            cust.BtnSave.Visible = true;
            cust.BtnSave.Location = new System.Drawing.Point(118, 641);
            cust.BtnUpdate.Visible = false;
            cust.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AdminAddCustomer c = new AdminAddCustomer(this);

                c.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                c.txtCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                c.txtOwnerName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                c.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                c.txtRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                c.txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                c.txtTelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                c.txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                c.cbxActive.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                //Hide the Save Button
                c.BtnSave.Visible = false;

                //Show Only the Update Button
                c.BtnUpdate.Visible = true;
                c.lbl1.Text = "Update Customer Information";
                c.PopulateRouteCombobox();
                c.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete the Customer Information?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCustomer WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer Information has been successfully Deleted", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowCustomersInformation();
                }
            }
        }

        private void AdminCustomer_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Transfer the data into a buffer when clicked(right)
                this.ID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.label2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.label3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.label4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.label5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.label6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.label7.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.label8.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                this.label9.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //File a switch case statement
            switch (e.ClickedItem.Name.ToString())
            {
                case "edi":

                    // Update the customer information, Opens the Update customer form

                    contextMenuStrip1.Hide();
                    AdminAddCustomer c = new AdminAddCustomer(this);

                    c.lblID.Text = ID.Text;
                    c.txtCustomerName.Text = label2.Text;
                    c.txtOwnerName.Text = label3.Text;
                    c.txtAddress.Text = label4.Text;
                    c.txtRoute.Text = label5.Text;
                    c.txtPhone.Text = label6.Text;
                    c.txtTelephone.Text = label7.Text;
                    c.txtEmail.Text = label8.Text;
                    c.cbxActive.Text = label9.Text;

                    //Hide the Save Button
                    c.BtnSave.Visible = false;

                    //Show Only the Update Button
                    c.BtnUpdate.Visible = true;
                    c.lbl1.Text = "Update Customer Information";
                    c.Show();

                    break;

                case "del":

                    // Delete the customer, Show a prompt first

                    contextMenuStrip1.Hide();
                    if (MessageBox.Show("Are you sure you want to Delete the Customer Information?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblCustomer WHERE id like '" + ID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Customer Information has been successfully Deleted", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowCustomersInformation();
                    }

                    break;

                case "invo":

                    // See the Customers ordered invoice 

                    contextMenuStrip1.Hide();

                    if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCustomerInvoices"))
                    {
                        AdminCustomerInvoices customer = new AdminCustomerInvoices(this);
                        customer.Dock = DockStyle.Fill;
                        AdminAdministrator.Instance.PnlContainer.Controls.Add(customer);

                        customer.ShowInvoiceByCustomer();
                    }
                    AdminAdministrator.Instance.PnlContainer.Controls["AdminCustomerInvoices"].BringToFront();
                    AdminAdministrator.Instance.BackButton.Visible = true;

                    break;

                case "deta":
                    
                    // See the Customer details/information in a card form 

                    contextMenuStrip1.Hide();

                    AdminCustomerDetails cd = new AdminCustomerDetails();

                    cd.lblID.Text = ID.Text;
                    cd.lblCustomer.Text = label2.Text;
                    cd.lblAddress.Text = label4.Text;
                    cd.lblRoute.Text = label5.Text;
                    cd.lblPhone.Text = label6.Text;
                    cd.lblTelephone.Text = label7.Text;
                    cd.lblEmail.Text = label8.Text;
                    cd.lblStatus.Text = label9.Text;
                    cd.Show();

                    break;
            }
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
     
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ShowCustomersInformation();
        }
    }
}
