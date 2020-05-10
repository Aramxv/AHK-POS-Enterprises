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
    public partial class AdminStockIn : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public AdminStockIn()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());

            SomeRandomReferenceNo();

            dateTimePicker1.Value = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowSelectedStockIn()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewStockIn WHERE refno like '" + txtReference.Text + "' and status like 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this Item?", "Stock In Module", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblStockin WHERE sid = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", "Stock In Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowSelectedStockIn();
                }
            }
        }

        public void Clear()
        {
            SomeRandomReferenceNo();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void AdminStockIn_Load(object sender, EventArgs e)
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.FromArgb(217, 219, 223);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 54, 75);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 5, 0, 5);
            this.dataGridView2.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView2.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }

        private void BtnStocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReference.Text == String.Empty || txtStockby.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    txtReference.Focus();
                    return;
                }
                else
                {
                    AdminSearchProductStockIn frm = new AdminSearchProductStockIn(this);
                    frm.ShowProducts();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveStockIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to Save this Stock-In?", "Saving Stock-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            //update tblProduct quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodqty = prodqty + '" + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + "' WHERE prodcode like '" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update tblStockIn quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblStockIn SET prodqty = prodqty + '" + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + "', status = 'Done' WHERE sid like '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                    Clear();
                    // Popup Notification for critical products
                    Alert.Show("Adding stocks to your inventory is committed successfully, Good job!", Alert.AlertType.info);
                    ShowSelectedStockIn();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Oops we're having issues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Generate a random number
        public void SomeRandomReferenceNo()
        {
            Random rad = new Random();
            txtReference.Text = rad.Next().ToString();
        }


        private void BtnActivityHistory_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminStockInHistory"))
            {
                AdminStockInHistory his = new AdminStockInHistory();
                his.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(his);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminStockInHistory"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

       
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminProducts"))
            {
                AdminProducts pro = new AdminProducts();
                pro.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(pro);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminProducts"].BringToFront();
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

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminStockIn"))
            {
                AdminStockIn stkin = new AdminStockIn();
                stkin.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(stkin);

                
                stkin.txtStockby.Text = AdminAdministrator.PassStockInName;
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
