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
    public partial class AdminSupplier : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public static string PassStockUsername;

        public AdminSupplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void ShowSuppliers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblSupplier WHERE supplier like '%" + txtSearch.Text + "%' order by supplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            cn.Close();
        }

        private void AdminSupplier_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Suppliers Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Suppliers Shown";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AdminAddSupplier sup = new AdminAddSupplier(this);
                sup.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                sup.txtSupplierName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                sup.txtSupplierAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                sup.txtSupplierPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                sup.txtSupplierTelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                sup.BtnUpdate.Focus();
                sup.BtnSave.Enabled = false;
                sup.BtnUpdate.Enabled = true;
                sup.lbl1.Text = "Update Supplier";
                sup.BtnSave.Visible = false;
                sup.BtnUpdate.Visible = true;
                sup.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Supplier", "Deleting Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblSupplier WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully Deleted", "Supplier Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSuppliers();
                }
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            AdminAddSupplier sup = new AdminAddSupplier(this);
            sup.BtnSave.Visible = true;
            sup.BtnSave.Location = new System.Drawing.Point(112, 413);
            sup.BtnUpdate.Visible = false;
            sup.BtnUpdate.Enabled = false;
            sup.BtnSave.Enabled = true;
            sup.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSuppliers();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ShowSuppliers();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInventory"))
            {
                AdminInventory inv = new AdminInventory();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowInventoryProducts();

                AdminAdministrator admin = new AdminAdministrator();
                PassStockUsername = admin.lblUsername.Text;
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInventory"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminStockIn"))
            {
                AdminStockIn stin = new AdminStockIn();
                stin.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(stin);

                stin.txtStockby.Text = AdminAdministrator.PassStockInName;
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminStockIn"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnStockOut_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminStockOut"))
            {
                AdminStockOut stockout = new AdminStockOut();
                stockout.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(stockout);

                stockout.ShowOutofStockInventory();

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminStockOut"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }
    }
}
