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
    public partial class AdminStockAdjustment : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        // variable for character counting in remarks section
        int remarkstextcount = 0;


        int _qty;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public AdminStockAdjustment()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

    
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInventory"))
            {
                AdminInventory inv = new AdminInventory();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowInventoryProducts();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInventory"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void AdminStockAdjustment_Load(object sender, EventArgs e)
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

        public void ShowStockAdjustmentInInventory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //Get a random number
        public void SomeRandomReferenceNo()
        {
            Random rad = new Random();
            txtReferenceNo.Text = rad.Next().ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowStockAdjustmentInInventory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Adjust")
            {
                lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProductCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + ", " + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + ", " + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
        }

        public void SqlStatement(string _sql)
        {
            cn.Open();
            cm = new SqlCommand(_sql, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void Clear()
        {
            txtReferenceNo.Text = "";
            txtProductCode.Text = "";
            txtDescription.Text = ""; 
            txtQuantity.Clear();
            cmbCommand.SelectedIndex = -1;
            txtRemarks.Clear();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Inventory Products Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Inventory Products Shown";
        }

        private void BtnSaveAdjustment_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation for empty fields
                if (txtProductCode.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(418, 116);
                    return;
                }
                if (txtQuantity.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(418, 60);
                    return;
                }
                    if (cmbCommand.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(418, 101);
                    return;
                }
                if (txtRemarks.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(418, 167);
                    return;
                }
                //Validate the quantity input 
                if (int.Parse(txtQuantity.Text) > _qty)
                {
                    MessageBox.Show("Stock on Hand Quantity should be greater than Adjustment Quantity", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbCommand.Text == "Remove from Inventory")
                {
                    SqlStatement("UPDATE tblProduct SET prodqty = (prodqty - " + int.Parse(txtQuantity.Text) + ") WHERE id like '" + lblID.Text + "'");
                }
                else if (cmbCommand.Text == "Add to Inventory")
                {
                    SqlStatement("UPDATE tblProduct SET prodqty = (prodqty + " + int.Parse(txtQuantity.Text) + ") WHERE id like '" + lblID.Text + "'");
                }

                string StockDate = DateTime.Now.ToString("dd-MMM-yyyy");

                SqlStatement("INSERT INTO tblStockAdjustment (referenceno, prodcode, proddescrip, prodqty, action, remarks, stockdate, stockby) VALUES ('" + txtReferenceNo.Text + "', '" + txtProductCode.Text + "', '" + txtDescription.Text + "', '" + txtQuantity.Text + "', '" + cmbCommand.Text + "', '" + txtRemarks.Text + "', '" + StockDate + "', '" + txtAdjustBy.Text + "')");

                MessageBox.Show("Stock Adjustment Process Completely", "Stock Adjustment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStockAdjustmentInInventory();
                AdminInventory inv = new AdminInventory();
                inv.ShowInventoryProducts();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminStockAdjustment_Click(object sender, EventArgs e)
        {
            WarningIndicator.Visible = false;
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            AdminStockAdjustDatePicker adjpicker = new AdminStockAdjustDatePicker();
            adjpicker.ShowDialog();
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
            remarkstextcount = txtRemarks.Text.Length;               // simply gettin the current length value of remarks textbox element
            txtremcount.Text = remarkstextcount.ToString() + "/120"; // and convert the integer (int) to string for output
        }

        public void ClearStockIn()
        {
            txtProductCode.Text = "";
            txtDescription.Text = "";
            txtQuantity.Clear();
            cmbCommand.SelectedIndex = -1;
            txtRemarks.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel Stocking-In?", "Cancel Stock-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearStockIn();
                if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInventory"))
                {
                    AdminInventory inv = new AdminInventory();
                    inv.Dock = DockStyle.Fill;
                    AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                    inv.ShowInventoryProducts();
                }
                AdminAdministrator.Instance.PnlContainer.Controls["AdminInventory"].BringToFront();
                AdminAdministrator.Instance.BackButton.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void WarningIndicator_Click(object sender, EventArgs e)
        {

        }
    }
}
