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
    public partial class AdminReportInventory : UserControl
    {
        // Declare SQLconnection Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        String InventoryStartDate;
        String InventoryEndDate;

        public AdminReportInventory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            // Set the date to current date
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;

            // Store a value of datetimepicker to a variable
            InventoryStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            InventoryEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            // Print the stored value of the variable
            bunifuCustomLabel1.Text = InventoryStartDate;
            bunifuCustomLabel2.Text = InventoryEndDate;
        }

        private void AdminReportInventory_Load(object sender, EventArgs e)
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

        public void CollapseSettings()
        {
            // Create an image path 
            Image down = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_down_36px.png");

            // Create an image path 
            Image up = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_up_36px.png");


            if (panel1.Height == 50)
            {
                BtnDropDown.Image = up;
                panel1.Height = 255;
            }
            else
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;
            }
        }

        public void UnCollapeSettings()
        {
            // Create an image path 
            Image down = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_down_36px.png");

            // Create an image path 
            Image up = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\icons\alertchevron_up_36px.png");


            if (panel1.Height == 255)
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;

            }
            else
            {
                BtnDropDown.Image = down;
                panel1.Height = 50;

            }
        }

        private void BtnDropDown_Click(object sender, EventArgs e)
        {
            CollapseSettings();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CollapseSettings();
        }

        private void AdminReportInventory_Click(object sender, EventArgs e)
        {
            UnCollapeSettings();
        }

        public void ShowInventoryRecords()
        {
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblProduct order by proddescrip", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["category"].ToString(), dr["prodprice"].ToString(), dr["prodqty"].ToString(), dr["warningqty"].ToString(), dr["prodstatus"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowRecords_Click(object sender, EventArgs e)
        {
            // Popup Notification for critical products
            Alert.Show("Generating Inventory Line into a Report.", Alert.AlertType.success);

            ShowInventoryRecords();
        }

        private void BtnPrintRecords_Click(object sender, EventArgs e)
        {
            // Popup Notification for critical products
            Alert.Show("Inventory Line Report is now ready for printing. You may now review the Inventory Line.", Alert.AlertType.success);

            AdminPreviewInventoryLine inventoryLine = new AdminPreviewInventoryLine(this);
            inventoryLine.LoadInventory();
            inventoryLine.ShowDialog();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Inventory Line Count";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Inventory Line Count";
        }
    }
}
