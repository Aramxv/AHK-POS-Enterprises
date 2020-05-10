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
    public partial class AdminCategory : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public static string PassStockUsername;

        public int rowindex = 0;
        public AdminCategory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void ShowCategories()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCategory WHERE category like '%" + txtSearch.Text + "%' order by category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            cn.Close();
        }

     
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            AdminAddCategory cat = new AdminAddCategory(this);
            cat.BtnSave.Visible = true;
            cat.BtnSave.Location = new System.Drawing.Point(106, 167);
            cat.BtnUpdate.Visible = false;
            cat.ShowDialog();
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Group")
            {
                this.lblCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminGroupByCategory"))
                {
                    AdminGroupByCategory categorized = new AdminGroupByCategory(this);
                    categorized.Dock = DockStyle.Fill;
                    AdminAdministrator.Instance.PnlContainer.Controls.Add(categorized);

                    categorized.ShowCategorizedProducts();
                    categorized.BtnCategorizedBy.Text = "Categorized by " + lblCategory.Text + "";
                }
                AdminAdministrator.Instance.PnlContainer.Controls["AdminGroupByCategory"].BringToFront();
                AdminAdministrator.Instance.BackButton.Visible = true;
            }
            if (colName == "Edit")
            {
                AdminAddCategory frm = new AdminAddCategory(this);
                frm.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.BtnSave.Visible = false;
                frm.BtnUpdate.Visible = true;
                frm.lbl1.Text = "Update Category";
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Category?", "Deleting Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete FROM tblCategory WHERE cid like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully Deleted.", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowCategories();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Categories Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Categories Shown";
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminProducts"))
            {
                AdminProducts pro = new AdminProducts();
                pro.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(pro);


                pro.ShowAllProductsInDatabase();

                AdminAdministrator admin = new AdminAdministrator();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminProducts"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }


        private void BtnCategory_Click(object sender, EventArgs e)
        {

        }

        private void deta_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //File a switch case statement
            switch (e.ClickedItem.Name.ToString())
            {
                case "edi":

                    contextMenuStrip1.Hide();
                    AdminAddCategory c = new AdminAddCategory(this);

                    c.lblID.Text = lblID.Text;
                    c.txtCategory.Text = lblCategory.Text;

                    //Hide the Save Button
                    c.BtnSave.Visible = false;

                    //Show Only the Update Button
                    c.BtnUpdate.Visible = true;
                    c.lbl1.Text = "Update Category";
                    c.Show();

                    break;

                case "del":

                    contextMenuStrip1.Hide();
                    if (MessageBox.Show("Are you sure you want to Delete this Category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblCategory WHERE cid like '" + lblID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Category has been Successfully Deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowCategories();
                    }

                    break;

                case "deta":

                    contextMenuStrip1.Hide();

                    if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminGroupByCategory"))
                    {
                        AdminGroupByCategory categorized = new AdminGroupByCategory(this);
                        categorized.Dock = DockStyle.Fill;
                        AdminAdministrator.Instance.PnlContainer.Controls.Add(categorized);

                        categorized.ShowCategorizedProducts();
                        categorized.BtnCategorizedBy.Text = "Categorized by " + lblCategory.Text + "";
                    }
                    AdminAdministrator.Instance.PnlContainer.Controls["AdminGroupByCategory"].BringToFront();
                    AdminAdministrator.Instance.BackButton.Visible = true;

                    break;
            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Transfer the data into a buffer when clicked(right)
                this.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.lblCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
            else
            {
                lblCategory.Text = "";
            }
        }
    }
}

