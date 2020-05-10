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
    public partial class FrmRoutelist : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        public FrmRoutelist()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRoutes();
        }

        public void LoadRoutes()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblRoutes WHERE route like '%" + txtSearch.Text + "%' order by route", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            cn.Close();
        }

        private void BtnAddprod_Click(object sender, EventArgs e)
        {
            //FrmRoute route = new FrmRoute(this);

            ////Show the Save button 
            //route.BtnSave.Visible = true;
            //route.BtnUpdate.Visible = false;

            ////Relocate the Save button
            //route.BtnSave.Location = new System.Drawing.Point(438, 167);

            ////Show the Add new Route Form
            //route.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            //if (colName == "Edit")
            //{
            //    FrmRoute frm = new FrmRoute(this);
            //    frm.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    frm.txtRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    frm.BtnSave.Visible = false;
            //    frm.BtnUpdate.Visible = true;
            //    frm.lbl1.Text = "UPDATE ROUTE";
            //    frm.ShowDialog();
            //}
            //else if (colName == "Delete")
            //{
            //    if (MessageBox.Show("Are you sure you want to Delete this Route?", "AHK Routes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        cn.Open();
            //        cm = new SqlCommand("DELETE FROM tblRoutes WHERE rid like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
            //        cm.ExecuteNonQuery();
            //        cn.Close();
            //        MessageBox.Show("Route has been Successfully Deleted", "AHK Routes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadRoutes();
            //    }
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRoutes();
        }

        private void FrmRoutelist_Load(object sender, EventArgs e)
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
