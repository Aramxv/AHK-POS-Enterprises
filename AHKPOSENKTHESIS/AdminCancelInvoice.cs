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
    public partial class AdminCancelInvoice : UserControl
    {
        // Declare Connection
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String CancelStartDate;
        String CancelEndDate;
        public AdminCancelInvoice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the value of two date picker to datetime.now
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;


            CancelStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            CancelEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            bunifuCustomLabel1.Text = CancelStartDate;
            bunifuCustomLabel2.Text = CancelEndDate;

            ShowAllCancelInvoice();
        }

        public void ShowAllCancelInvoice()
        {
            try
            {
                // get the path of the image
                Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cancel_subscription_24px.png");

                int i = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from tblCancelInvoice WHERE customer like '%" + txtSearch.Text + "%' order by canceldate desc", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString(), dr["canceldate"].ToString());

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Ooops Something came up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShownEntriesOption()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cancel_subscription_24px.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbShown.Text == "25")
            {
                cm = new SqlCommand("SELECT top 25 * FROM tblCancelInvoice order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "50")
            {
                cm = new SqlCommand("SELECT top 50 * FROM tblCancelInvoice order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "75")
            {
                cm = new SqlCommand("SELECT top 75 * FROM tblCancelInvoice order by invoiceno desc", cn);
            }
            else if (cmbShown.Text == "All")
            {
                cm = new SqlCommand("SELECT * FROM tblCancelInvoice order by invoiceno desc", cn);

            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString(), dr["canceldate"].ToString());

            }
            dr.Close();
            cn.Close();
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

        public void ShowInvoicesOfSelectedCustomer()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cancel_subscription_24px.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from tblCancelInvoice WHERE customer like '" + cmbCustomer.Text + "' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString(), dr["canceldate"].ToString());

            }
            dr.Close();
            cn.Close();
        }

        public void SortByPaymentTerms()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cancel_subscription_24px.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbSort.Text == "All")
            {
                cm = new SqlCommand("SELECT * from tblCancelInvoice order by canceldate desc", cn);
            }
            else if (cmbSort.Text == "Cash")
            {
                cm = new SqlCommand("SELECT * from tblCancelInvoice WHERE payment like '" + cmbSort.Text + "' order by invoiceno desc", cn);
            }
            else if (cmbSort.Text == "Cheque")
            {
                cm = new SqlCommand("SELECT * from tblCancelInvoice WHERE payment like '" + cmbSort.Text + "' order by invoiceno desc", cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString(), dr["canceldate"].ToString());

            }
            dr.Close();
            cn.Close();
        }

        public void FilterByDate()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cancel_subscription_24px.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * from tblCancelInvoice WHERE canceldate between '" + bunifuDatepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + bunifuDatepicker2.Value.ToString("yyyy-MM-dd") + "' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString(), dr["canceldate"].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void AdminCancelInvoice_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Cancelled Invoice Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Cancelled Invoice Shown";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowAllCancelInvoice();
        }

        private void cmbShown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShownEntriesOption();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInvoicesOfSelectedCustomer();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortByPaymentTerms();
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            cmbShown.Text = "All";
            cmbSort.Text = "All";
            cmbCustomer.SelectedIndex = -1;

            ShowAllCancelInvoice();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            FilterByDate();
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

        private void AdminCancelInvoice_Click(object sender, EventArgs e)
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

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInvoices"))
            {
                AdminInvoices inv = new AdminInvoices();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowAllInvoices();
                inv.PopulateCustomerNameCombobox();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInvoices"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
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

        private void BtnCancelledInvoices_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
