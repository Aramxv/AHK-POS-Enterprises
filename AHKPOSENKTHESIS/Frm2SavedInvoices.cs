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
    public partial class Frm2SavedInvoices : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        string titlesataas = "Invoice Module";

                
        public Frm2SavedInvoices( )
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadInvoiceRecords();
        }

        public void LoadInvoiceRecords()
        { 
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-purchase-order-30.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblInvoiceRecords WHERE customer like '%" + txtSearch.Text + "%' order by invoiceno desc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), double.Parse(dr[4].ToString()).ToString("#,##0.00"), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void FrmSavedInvoices_Load(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInvoiceRecords();
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            { 
                Frm2EditInvoices edit = new Frm2EditInvoices();

                edit.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                edit.lblInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                edit.txtCustomer.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                edit.cbxPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                edit.Dmdays.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                edit.txtBilling.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                edit.lblSalesTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                edit.lblDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                edit.lblVAT.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                edit.lblVatable.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                edit.lblTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                edit.dataGridView1.Rows.Clear();

                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    edit.dataGridView1.Rows.Add(i, dr[0].ToString(), edit.addqty, dr[7].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString());
                }
                cn.Close();
                //Compute automatically the amount of the ordered products
                Frm2EditInvoices invoice = new Frm2EditInvoices();
                invoice.GetOrderTotal();
                edit.Show();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Invoice?", "Deleting Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceOrder WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadInvoiceRecords();

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblInvoiceRecords WHERE invoiceno like '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Invoice Successfully Deleted.", "Deleting Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceRecords();
                }
            }
           
        }
    }
}
