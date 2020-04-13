using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmInvoiceList : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        public FrmInvoiceList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            LoadInvoiceRecords();
            LoadCancelInvoice();
            DisplayOverdueInvoice();

            //Set the Date Time Picker Value according to system's date and time
            dateTimePicker1.Value = DateTime.Now;
        }
        public void LoadInvoiceRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();

            if (cmbShown.Text == "25")
            {
                cm = new SqlCommand("SELECT top 25 * FROM tblInvoiceRecords");
            }
            else if (cmbShown.Text == "50")
            {
                cm = new SqlCommand("SELECT top 50 * FROM tblInvoiceRecords");
            }

            cm = new SqlCommand("SELECT * FROM tblInvoiceRecords WHERE customer like '%" + txtSearch.Text + "%' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString());
                //  dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadAllInvoices()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                if (cmbFilter.Text == "All Invoices")
                {
                    cm = new SqlCommand("SELECT * from tblInvoiceRecords order by datecreated desc", cn);
                }
                else if (cmbFilter.Text == "Cash")
                {
                    cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbFilter.Text + "' order by datecreated desc", cn);
                }
                else if (cmbFilter.Text == "Cheque")
                {
                    cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbFilter.Text + "' order by datecreated desc", cn);
                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadCancelInvoice()
        {
            try
            {
                int i = 0;
                dataGridView2.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * from tblCancelInvoice order by canceldate desc", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["canceldate"].ToString(), dr["cancelby"].ToString(), dr["reason"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayOverdueInvoice()
        {
            try
            {
                int i = 0;
                dataGridView4.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblinvoicerecords where payment like 'Cheque' and duedate <= '" + dateTimePicker1.Value.ToString("yyyyMMdd") + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView4.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmInvoiceList_Load(object sender, EventArgs e)
        {
            //All Invoice Datagridview
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Cancelled Invoice Datagridview
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Paid Invoice Datagridview
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Payment Overdue Invoices Datagridview
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            // In Advance Settings add items in the cmbCustomer combo box with the saved customer's name
            PopulateComboboxWithCustomersName();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Frm2EditInvoices edit = new Frm2EditInvoices();

                edit.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                edit.lblInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                edit.txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                edit.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit.cbxPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                edit.Dmdays.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                edit.txtBilling.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                edit.lblSalesTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                edit.lblDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                edit.lblVAT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                edit.lblVatable.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                edit.lblTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                edit.dataGridView1.Rows.Clear();
                edit.DueDateAutomation();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    edit.dataGridView1.Rows.Add(i, dr[0].ToString(), dr[7].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString());
                }
                cn.Close();
                //Compute automatically the amount of the ordered products
                Frm2EditInvoices invoice = new Frm2EditInvoices();
                invoice.GetOrderTotal();
                edit.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Invoice?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadInvoiceRecords();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceRecords WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Invoice Successfully Deleted.", "Deleting Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceRecords();
                }
            }
            else if (colName == "Cancel")
            {
                if (MessageBox.Show("Are you sure you want to Cancel this Invoice? Once this done, You can never get the Invoice back!", "Cancelling Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmCancelInvoice cancel = new FrmCancelInvoice(this);

                    cancel.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cancel.lblInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cancel.txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cancel.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cancel.cbxPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    cancel.Dmdays.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    cancel.txtBilling.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    cancel.lblSalesTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cancel.lblDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cancel.lblVAT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cancel.lblVatable.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cancel.lblTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    cancel.dataGridView1.Rows.Clear();

                    int i = 0;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        cancel.dataGridView1.Rows.Add(i, dr[0].ToString(), dr[7].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString());
                    }
                    cn.Close();
                    //Compute automatically the amount of the ordered products
                    cancel.txtUsername.Text = FrmMain1.PassCanName;
                    cancel.GetOrderTotal();
                    cancel.Show();
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoadInvoices_Click(object sender, EventArgs e)
        {
            LoadAllInvoices();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInvoiceRecords();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteCancel")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Invoice?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCancelInvoice WHERE id like '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Invoice Successfully Deleted.", "Deleting Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCancelInvoice();
                }
            }
        }

        //Show Advance Settings Button
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                // Change the label to Hide Advance Settings
                lblAdvanceSettings.Text = "Hide Advance Settings";
            }
            else
            {
                panel1.Visible = false;
                // Change the label to Show Advance Settings
                lblAdvanceSettings.Text = "Show Advance Settings";
            }
        }

        public void ShownEntries()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbShown.Text == "25")
            {
                cm = new SqlCommand("SELECT top 25 * FROM tblInvoiceRecords", cn);
            }
            else if (cmbShown.Text == "50")
            {
                cm = new SqlCommand("SELECT top 50 * FROM tblInvoiceRecords", cn);
            }
            else if (cmbShown.Text == "75")
            {
                cm = new SqlCommand("SELECT top 75 * FROM tblInvoiceRecords", cn);
            }
            else
            {
                cm = new SqlCommand("SELECT * FROM tblInvoiceRecords", cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString());
                //dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void SortByPaymentTerms()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            if (cmbSort.Text == "All Invoices")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords order by datecreated desc", cn);
            }
            else if (cmbSort.Text == "Cash")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbSort.Text + "' order by datecreated desc", cn);
            }
            else if (cmbSort.Text == "Cheque")
            {
                cm = new SqlCommand("SELECT * from tblInvoiceRecords WHERE payment like '" + cmbSort.Text + "' order by datecreated desc", cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["invoiceno"].ToString(), dr["customer"].ToString(), dr["address"].ToString(), dr["salestotal"].ToString(), dr["discount"].ToString(), dr["vat"].ToString(), dr["vatable"].ToString(), dr["total"].ToString(), dr["payment"].ToString(), dr["days"].ToString(), dr["billaddress"].ToString(), dr["datecreated"].ToString(), dr["duedate"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cmbShown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbShown_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void ResetSettings()
        {
            cmbShown.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void cmbSort_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ShownEntries();
            SortByPaymentTerms();
        }

        public void PopulateComboboxWithCustomersName()
        {
            cmbCustomer.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT customername FROM tblCustomer", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbCustomer.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
