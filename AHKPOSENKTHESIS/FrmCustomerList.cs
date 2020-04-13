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
    public partial class FrmCustomerList : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private int rowindex = 0;

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public FrmCustomerList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCustomersInfo();
        }

        public void LoadCustomersInfo()
        {
            int i= 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCustomer WHERE customername like '%" + txtSearch.Text + "%' order by customername", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            cn.Close();
        }

        private void BtnAddprod_Click(object sender, EventArgs e)
        {
            FrmCustomer cust = new FrmCustomer(this);
            cust.BtnSave.Visible = true;
            cust.BtnSave.Location = new System.Drawing.Point(324, 658);
            cust.BtnUpdate.Visible = false;
          //  cust.LoadRoutes(); 
            cust.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomersInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
             if (colName == "Edit")
             {
                FrmCustomer c = new FrmCustomer(this);

                c.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                c.txtCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                c.txtOwnerName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                c.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                c.txtRoute.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                c.txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                c.txtTelephone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                c.txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                c.cbxActive.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                //Hide the Save Button
                c.BtnSave.Visible = false;

                //Show Only the Update Button
                c.BtnUpdate.Visible = true;
                c.lbl1.Text = "UPDATE CUSTOMER INFORMATION";
                c.Show();
             }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete the Customer Information?", "Customer Module", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCustomer WHERE id like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer Information has been successfully Deleted", "Customer Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomersInfo();
                }
            }
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Transfer the data into a buffer when clicked(right)
                this.ID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.label2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.label3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.label4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.label5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.label6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.label7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.label8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.label9.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowindex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //File a switch case statement
            switch (e.ClickedItem.Name.ToString())
            {
                case "edi":
                    
                    contextMenuStrip1.Hide();
                    FrmCustomer c = new FrmCustomer(this);

                    c.lblID.Text = ID.Text;
                    c.txtCustomerName.Text = label2.Text;
                    c.txtOwnerName.Text = label3.Text;
                    c.txtAddress.Text = label4.Text;
                    c.txtRoute.Text = label5.Text;
                    c.txtPhone.Text = label6.Text;
                    c.txtTelephone.Text = label7.Text;
                    c.txtEmail.Text = label8.Text;
                    c.cbxActive.Text = label9.Text;

                    //Hide the Save Button
                    c.BtnSave.Visible = false;

                    //Show Only the Update Button
                    c.BtnUpdate.Visible = true;
                    c.lbl1.Text = "UPDATE CUSTOMER INFORMATION";
                    c.Show();

                    break;

                case "del":

                    contextMenuStrip1.Hide();
                    if (MessageBox.Show("Are you sure you want to delete the Customer Information?", "Customer Module", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblCustomer WHERE id like '" + ID.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Customer Information has been successfully Deleted", "Customer Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomersInfo();
                    }

                    break;

                case "deta":

                    contextMenuStrip1.Hide();

                    FrmCustomerDetails cd = new FrmCustomerDetails();

                    cd.materialLabel1.Text = label2.Text; 
                    cd.materialLabel3.Text = label4.Text;
                    cd.materialLabel4.Text = label5.Text;
                    cd.materialLabel5.Text = label6.Text;
                    cd.materialLabel6.Text = label7.Text;
                    cd.materialLabel7.Text = label8.Text;
                    cd.Show();

                    break;
            }
        }

        private void deta_Click(object sender, EventArgs e)
        {

        }
    }
}
