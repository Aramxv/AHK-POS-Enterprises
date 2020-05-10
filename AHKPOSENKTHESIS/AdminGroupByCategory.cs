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
    public partial class AdminGroupByCategory : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        AdminCategory category;
        public AdminGroupByCategory(AdminCategory cat)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            category = cat;
        }

        private void AdminGroupByCategory_Load(object sender, EventArgs e)
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

        public void ShowCategorizedProducts()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\cardboard_box_24px.png");

            cn.Open();
            dataGridView1.Rows.Clear();
            int i = 0;
            cm = new SqlCommand("SELECT * FROM tblProduct WHERE category = '" + category.lblCategory.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

            }
            cn.Close();
        }


        private void BtnProducts_Click(object sender, EventArgs e)
        {
            AdminAdministrator.Instance.PnlContainer.Controls.Clear();
            dataGridView1.Rows.Clear();
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

        private void dataGridView1_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Under " + category.lblCategory.Text + "";

        }

        private void dataGridView1_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Under " + category.lblCategory.Text + "";

        }
    }
}
