using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminInventory : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public static string PassStockUsername;
        public static string PassStockAdjByusername;

        public AdminInventory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        public void ShowInventoryProducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();

            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

            }
            dr.Close();
            cn.Close();
            AlertCriticalProducts();
        }

        public void AlertCriticalProducts()
        {
            try
            {
                UpdateCritical();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCritical()
        {
            string alert = "Critical";
            string healthy = "Good";

            if (dataGridView1.Rows.Count > 0)
            {

                // Create loop
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                        cm.Parameters.AddWithValue("@status", alert);
                        cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                        dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                        dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;

                        // Change the picture of the cell that is in critical quantity count 
                        Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24_XX.png");

                        // Add a row set the value
                        dataGridView1.Rows[i].Cells[1].Value = imglink;

                        // Popup Notification for critical products
                        Alert.Show("You have Critical Products in Inventory. Re-stock to fullfil your client needs.", Alert.AlertType.critical);
                    
                    }
                    else
                    {
                        // Change the picture of the cell that is in critical quantity count 
                        Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

                        // Add a row set the value
                        dataGridView1.Rows[i].Cells[1].Value = imglink;

                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                        cm.Parameters.AddWithValue("@status", healthy);
                        cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                        cm.ExecuteNonQuery();
                        dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.SeaGreen;
                        cn.Close();
                    }
                }
            }
        }

        public void UpdateCriticalWithoutNotification()
        {
            string alert = "Critical";
            string healthy = "Good";

            if (dataGridView1.Rows.Count > 0)
            {
                {
                    // Create loop
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", alert);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;

                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24_XX.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;
                        }
                        else
                        {
                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;

                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", healthy);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.SeaGreen;
                            cn.Close();
                        }
                    }
                }
            }
        }

        private void AdminInventory_Load(object sender, EventArgs e)
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

            ShowInventoryProducts();
        }

        // Search the products in inventory without popping a side notification
        public void SearchInventory()
        {

            int i = 0;
            dataGridView1.Rows.Clear();

            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();

            UpdateCriticalWithoutNotification();
        }

        public void NotifyUserForHealthyProducts()
        {
            // Popup Notification for critical products
            Alert.Show("You got " + dataGridView1.Rows.Count.ToString() + " Good products in inventory. Keep your bussiness going! Keep it up!.", Alert.AlertType.critical);
        }


        public void ShowAllNormalQuantityInInventory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();

            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' and prodstatus = 'Good' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            NotifyUserForHealthyProducts();
            UpdateCriticalWithoutNotification();
        }
        
        public void NotifyUserForCriticalProducts()
        {
            // Popup Notification for critical products
            Alert.Show("You got " + dataGridView1.Rows.Count.ToString() + " critical items in inventory. Re-stock to keep your business going.", Alert.AlertType.critical);
        }
     
        public void ShowAllCriticalQuantityInInventory()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' and prodstatus = 'Critical' order by proddescrip", cn);


            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            NotifyUserForCriticalProducts();
            dr.Close();
            cn.Close();

            UpdateCriticalWithoutNotification();
        }

        private void BtnShowAll_Click_1(object sender, EventArgs e)
        {
            SearchInventory();
        }

        private void BtnNormal_Click_1(object sender, EventArgs e)
        {
            ShowAllNormalQuantityInInventory();
        }

        private void BtnCritical_Click_1(object sender, EventArgs e)
        {
            ShowAllCriticalQuantityInInventory();
        }

        private void BtnStockAdjust_Click_1(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminStockAdjustment"))
            {
                AdminStockAdjustment adj = new AdminStockAdjustment();
                adj.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(adj);

                AdminAdministrator admin = new AdminAdministrator();
                adj.txtAdjustBy.Text = AdminAdministrator.PassStockAdjName;

                adj.ShowStockAdjustmentInInventory();
                adj.SomeRandomReferenceNo();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminStockAdjustment"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInventory();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ShowInventoryProducts();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Product Inventory Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Inventory Shown";
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

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminProducts"))
            {
                AdminProducts pro = new AdminProducts();
                pro.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(pro);

                pro.ShowAllProductsInDatabase();
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

                AdminAdministrator admin = new AdminAdministrator();
                PassStockUsername = admin.lblUsername.Text;
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

                AdminAdministrator admin = new AdminAdministrator();
                stin.txtStockby.Text = AdminAdministrator.PassStockInName;
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminStockIn"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            AdminAdministrator.Instance.PnlContainer.Controls.Clear();
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
            AdminAdministrator.Instance.PnlContainer.Controls.Clear();
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
