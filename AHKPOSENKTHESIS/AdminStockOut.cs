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
    public partial class AdminStockOut : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;


        public AdminStockOut()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        public void ShowOutofStockInventory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();

            // get the path of the image 
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24_XX.png");

            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' and prodqty <= 0", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            NotifyIfThereIsOutofStockProduct();
            cn.Close();
        }

        public void NotifyIfThereIsOutofStockProduct()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Create a for loop condition 
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // Popup Notification for critical products
                    Alert.Show("You got " + dataGridView1.Rows.Count.ToString() + " out of stock items in inventory. Re-stock to keep your business going.", Alert.AlertType.critical);
               
                }
            }
        }

        private void AdminStockOut_Load(object sender, EventArgs e)
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

            ShowOutofStockInventory();
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


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Out of Stock Products Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Out of Stock Products Shown";
        }
    }
}
