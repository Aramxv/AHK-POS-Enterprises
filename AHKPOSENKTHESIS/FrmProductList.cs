using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmProductlist : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        public FrmProductlist()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public void LoadShitData()
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
         // AlertCriticalProducts();
        }

        private void BtnAddprod_Click(object sender, EventArgs e)
        {
            FrmProduct shit = new FrmProduct(this);

            //if the add product button is click 
            //save button is present in the form
            shit.BtnSave.Visible = true;

            //change the location of save button next to cancel button
            shit.BtnSave.Location = new System.Drawing.Point(360, 520);

            //update button is not present in the form
            shit.BtnUpdate.Visible = false;
            shit.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmProduct Frp = new FrmProduct(this);
                Frp.BtnSave.Enabled = false;
                Frp.BtnUpdate.Enabled = true;
                Frp.lbl1.Text = "UPDATE PRODUCT";

                Frp.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Frp.txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Frp.txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Frp.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Frp.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Frp.txtQuan.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Frp.txtWarnqty.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                LoadShitData();
                Frp.BtnSave.Visible = false;
                Frp.BtnUpdate.Visible = true;
                Frp.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Product's Information?", "Deleting Product Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete FROM tblProduct WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product's Information Successfully Deleted.", "Deleting Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadShitData();
                }
            }
        }


        private void FrmProductlist_Load(object sender, EventArgs e)
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
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadShitData();
        }
    }
}
