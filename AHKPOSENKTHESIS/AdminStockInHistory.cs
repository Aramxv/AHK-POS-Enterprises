using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminStockInHistory : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 30;

        String PrintStartDate;
        String PrintEndDate;

       
        public AdminStockInHistory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;

            PrintStartDate = date1.Value.ToString("dd-MMM-yyyy");
            PrintEndDate = date2.Value.ToString("dd-MMM-yyyy");
        }

        private void BtnLoadHistory_Click(object sender, EventArgs e)
        {
            ShowStockInHistory();
        }

        private void ShowStockInHistory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewStockIn WHERE cast(stockdate as date) between '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd") + "' and status like 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void AdminStockInHistory_Load(object sender, EventArgs e)
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

        // Paints the custom selection background for selected rows.
        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        { 

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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            AdminStockInDatePicker date = new AdminStockInDatePicker();
            date.Show();
        }
    }
}
