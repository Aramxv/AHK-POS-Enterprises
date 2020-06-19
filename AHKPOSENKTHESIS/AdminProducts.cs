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
    public partial class AdminProducts : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public static string PassStockUsername;

        public int rowindex = 0;

        public AdminProducts()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void ShowAllProductsInDatabase()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
          
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        private void AdminProducts_Load(object sender, EventArgs e)
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor =  Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }
        private void BtnAddProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                AdminAddNewProducts addProduct = new AdminAddNewProducts(this);

                //if the add product button is click 
                //save button is present in the form
                addProduct.BtnSave.Visible = true;

                //change the location of save button next to cancel button
                addProduct.BtnSave.Location = new System.Drawing.Point(133, 515);

                //update button is not present in the form
                addProduct.BtnUpdate.Visible = false;
                addProduct.Show();

                // Populate the Combobox with category 
                addProduct.PopulateCategoryInCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops Something came up", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AdminAddNewProducts Frp = new AdminAddNewProducts(this);
                Frp.BtnSave.Enabled = false;
                Frp.BtnUpdate.Enabled = true;
                Frp.lbl1.Text = "Update Product";

                Frp.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Frp.txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Frp.txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Frp.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Frp.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Frp.txtQuan.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Frp.txtWarnqty.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                ShowAllProductsInDatabase();
                Frp.BtnSave.Visible = false;
                Frp.BtnUpdate.Visible = true;

                // Populate the Category Combobox
                Frp.PopulateCategoryInCombobox();
                Frp.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Product's Information?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete FROM tblProduct WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product's Information Successfully Deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllProductsInDatabase();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowAllProductsInDatabase();
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

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCategory"))
            {
                AdminCategory cat = new AdminCategory();
                cat.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(cat);

                cat.ShowCategories();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCategory"].BringToFront();
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

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminSupplier"))
            {
                AdminSupplier supp = new AdminSupplier();
                supp.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(supp);

                supp.ShowSuppliers();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminSupplier"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ShowAllProductsInDatabase();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Transfer the data into a buffer when clicked(right)
                this.ID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.label2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.label3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.label4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.label5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.label6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.label7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.label9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                

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

                    contextMenuStrip1.Hide();
                    AdminAddNewProducts c = new AdminAddNewProducts(this);

                    c.lblID.Text = ID.Text;
                    c.txtDesc.Text = label3.Text;
                    c.txtCode.Text = label2.Text;
                    c.txtCategory.Text = label5.Text;
                    c.txtPrice.Text = label4.Text;
                    c.txtQuan.Text = label6.Text;
                    c.txtWarnqty.Text = label7.Text;
                   
                    //Hide the Save Button
                    c.BtnSave.Visible = false;

                    // Populate the Category Combobox
                    c.PopulateCategoryInCombobox();

                    //Show Only the Update Button
                    c.BtnUpdate.Visible = true;
                    c.lbl1.Text = "Update Product Information";
                    c.txtQuan.Enabled = false;
                    c.Focus();
                    c.Show();

                    break;

                case "del":

                    contextMenuStrip1.Hide();
                    if (MessageBox.Show("Are you sure you want to delete the Product Information?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblProduct WHERE id like '" + ID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product Information has been successfully Deleted", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllProductsInDatabase();
                    }

                    break;

                case "deta":

                    contextMenuStrip1.Hide();

                    AdminProductDetails pd = new AdminProductDetails();

                    pd.lblWhatProduct.Text = label3.Text;
                    pd.lblWhatCategory.Text = "This product is under " + label5.Text + "  Category.";
                    pd.lblWhatID.Text = ID.Text;
                    pd.lblWhatCode.Text = label2.Text;
                    pd.lblWhatPrice.Text = "₱  " + label4.Text + " ";
                    pd.lblWhatStatus.Text = label9.Text;
                    pd.Show();

                    break;
           }
        }
    }
}
