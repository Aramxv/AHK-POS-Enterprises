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
    public partial class FrmSupplierList : Form
    { 
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        string titlesataas = "Supplier Module";

        public FrmSupplierList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        public void LoadSuppliers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblSupplier WHERE supplier like '%" + txtSearch.Text + "%' order by supplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            cn.Close();
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier sup = new FrmSupplier(this);
            sup.BtnSave.Visible = true;
            sup.BtnSave.Location = new System.Drawing.Point(338, 371);
            sup.BtnUpdate.Visible = false;
            sup.BtnUpdate.Enabled = false;
            sup.BtnSave.Enabled = true;
            sup.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmSupplier sup = new FrmSupplier(this);
                sup.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                sup.txtSupplierName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                sup.txtSupplierAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                sup.txtSupplierPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                sup.txtSupplierTelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                sup.BtnUpdate.Focus();
                sup.BtnSave.Enabled = false;
                sup.BtnUpdate.Enabled = true;
                sup.lbl1.Text = "UPDATE BRAND";
                sup.BtnSave.Visible = false;
                sup.BtnUpdate.Visible = true;
                sup.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Supplier", titlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblSupplier WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully Deleted", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void FrmSupplierList_Load(object sender, EventArgs e)
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
    }
}
