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
using System.Drawing;

namespace AHKPOSENKTHESIS
{
    public partial class FrmStockAdjustment : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        int _qty;

        public FrmStockAdjustment()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            txtAdjustBy.Text = FrmMain1.PassStockUsername;


        }

        private void FrmStockAdjustment_Load(object sender, EventArgs e)
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

        public void LoadStocks()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblProduct  WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //Get a random number
        public void GetReferenceNo()
        {
            Random rad = new Random();
            txtReferenceNo.Text = rad.Next().ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Adjust") 
            {
                lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProductCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "," + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "," + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
        }

        private void BtnSaveAdjustment_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation for empty fields
                if (cmbCommand.Text == String.Empty || txtRemarks.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill the empty field/s to Continue!", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Validate the quantity input 
                if (int.Parse(txtQuantity.Text) > _qty)
                {
                    MessageBox.Show("Stock on Hand Quantity should be greater than Adjustment Quantity", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbCommand.Text == "Remove from Inventory")
                {
                    SqlStatement("UPDATE tblProduct SET prodqty = (prodqty - " + int.Parse(txtQuantity.Text) + ") WHERE id like '" + lblID.Text + "'");
                }
                else if (cmbCommand.Text == "Add to Inventory")
                {
                    SqlStatement("UPDATE tblProduct SET prodqty = (prodqty + " + int.Parse(txtQuantity.Text) + ") WHERE id like '" + lblID.Text + "'");
                }

                string StockDate = DateTime.Now.ToString("dd-MMM-yyyy");

                SqlStatement("INSERT INTO tblStockAdjustment (referenceno, prodcode, proddescrip, prodqty, action, remarks, stockdate, stockby) VALUES ('" + txtReferenceNo.Text + "', '" + txtProductCode.Text + "', '" + txtDescription.Text + "', '" + txtQuantity.Text + "', '" + cmbCommand.Text + "', '" + txtRemarks.Text + "', '" + StockDate + "', '" + txtAdjustBy.Text + "')");

                MessageBox.Show("Stock Adjustment Process Completely", "Stock Adjustment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStocks();
                FrmInventory inv = new FrmInventory();
                inv.LoadShitData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void SqlStatement(string _sql)
        {
            cn.Open();
            cm = new SqlCommand(_sql, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void Clear()
        {
            txtReferenceNo.Clear();
            txtProductCode.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            cmbCommand.SelectedIndex = -1;
            txtRemarks.Clear();
        }

        private void FrmStockAdjustment_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
