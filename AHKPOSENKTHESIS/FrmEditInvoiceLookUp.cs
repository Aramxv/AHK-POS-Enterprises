using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmEditInvoiceLookUp : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        Frm2EditInvoices edit;

        public FrmEditInvoiceLookUp(Frm2EditInvoices idit)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            edit = idit;
        }

        private void FrmEditInvoiceLookUp_Load(object sender, EventArgs e)
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

        //display the data searched tblProduct in datagridview 
        public void LoadShitData()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-box-242.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip asc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void NotifyTheUserForTheProductQuantityLevel()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Create loop
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    // condition
                    if (int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()))
                    {
                        // Get the path of the image
                        Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icon_critical.png");

                        // Add a row and set a value 
                        // Change the pucture of the cell that s critical quantity count
                        dataGridView1.Rows[i].Cells[8].Value = imglink;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                FrmEditInvoicesQuantity frm = new FrmEditInvoicesQuantity(edit);
                frm.ProductDetails(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), double.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()), edit.lblInvoiceNo.Text, edit.txtCustomer.Text, int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()), edit.addqty);
                frm.ShowDialog();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadShitData();
        }
    }
}
