using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AHKPOSENKTHESIS
{
    public partial class AdminSearchProductStockIn : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        
        AdminStockIn slist;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public AdminSearchProductStockIn(AdminStockIn flist)
        {
            InitializeComponent();
            slist = flist;
            cn = new SqlConnection(dbcon.MyConnection());

            this.KeyPreview = true;
        }

        public void ShowProducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if (slist.txtReference.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Reference Number", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slist.txtReference.Focus();
                    return;
                }
                if (slist.txtStockby.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Stock In By", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slist.txtStockby.Focus();
                    return;
                }
            if (MessageBox.Show("Add this item?", "Stock-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblStockIn (refno, prodcode, stockdate, stockinby) VALUES (@refno, @code, @sdate, @sinby)", cn);  //FROM tblProduct WHERE proddescrip like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.Parameters.AddWithValue("@refno", slist.txtReference.Text);
                    cm.Parameters.AddWithValue("@code", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.Parameters.AddWithValue("@sdate", slist.dateTimePicker1.Value);
                    cm.Parameters.AddWithValue("@sinby", slist.txtStockby.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Successfully added!", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 slist.ShowSelectedStockIn();
                }
            }
        }

        private void FrmSearchProduct_StockIn_Load(object sender, EventArgs e)
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

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        private void FrmSearchProduct_StockIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
