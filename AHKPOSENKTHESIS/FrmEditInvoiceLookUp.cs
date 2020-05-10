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

        AdminUpdateInvoice edit;

        public FrmEditInvoiceLookUp(AdminUpdateInvoice idit)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            edit = idit;

            this.KeyPreview = true;
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
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr["prodcode"].ToString(), dr["proddescrip"].ToString(), dr["prodprice"].ToString(), dr["category"].ToString(), dr["prodqty"].ToString(), dr["warningqty"].ToString(), dr["prodstatus"].ToString());
            }
            IndicateThatProductReachedWarningLevel();
            dr.Close();
            cn.Close();
        }

        public void IndicateThatProductReachedWarningLevel()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    // get the path of the image
                    Image reachedwarning = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icon_critical.png");

                    // Add a row set the value
                    dataGridView1.Rows[i].Cells[8].Value = reachedwarning;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                FrmEditInvoicesQuantity frm = new FrmEditInvoicesQuantity(edit);
                frm.ProductDetails(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), double.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()), edit.lblInvoiceNo.Text, edit.txtCustomer.Text, int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()));
                frm.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadShitData();
        }

        // Counting the rows and displaying it in string
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblRowProductCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        // Counting the rows and displaying it in string
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblRowProductCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        // Escape key to close 
        private void FrmEditInvoiceLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
