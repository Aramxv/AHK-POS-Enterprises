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
    public partial class FrmStockIn : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        string titlesataas = "Stock In Module";

        public FrmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
        }

        //reload data in datagidview2
        public void LoadStockIn()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewStockIn WHERE refno like '" + txtReference.Text +"' and status like 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;    
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void LoadStockInHistory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM ViewStockIn WHERE cast(stockdate as date) between '" + date1.Value.ToString("yyyy-MM-dd") + "' and '" + date2.Value.ToString("yyyy-MM-dd")  + "' and status like 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this Item?", "Stock In Module", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                { 
                cn.Open();
                cm = new SqlCommand("DELETE FROM tblStockin WHERE sid = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'",cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Item has been successfully removed", "Stock In Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStockIn();
                }
            }
        }

        public void Clear()
        {
            txtReference.Clear();
            txtStockby.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FrmStockIn_Load(object sender, EventArgs e)
        {
            //For Datagridview1 in Stock in History
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

            //For Datagridview2 in Stock Entry Tab
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            txtStockby.Text = FrmMain1.PasslblName;
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records?", titlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            //update tblProduct quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodqty = prodqty + '" + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + "' WHERE prodcode like '" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update tblStockIn quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblStockIn SET prodqty = prodqty + '" + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + "', status = 'Done' WHERE sid like '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                    Clear();
                    LoadStockIn();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReference.Text == String.Empty || txtStockby.Text == String.Empty)
                {
                    MessageBox.Show("Please fill the Reference Number in format of R(Date Today), and your name in Stock-in by to Proceed.", "Stock-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReference.Focus();
                    return;
                }
                else
                {
                    FrmSearchProduct_StockIn frm = new FrmSearchProduct_StockIn(this);
                    frm.LoadProduct();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Del")
            {
                if (MessageBox.Show("Are you sure you want to delete this Stock-In History?", "Deleting Stock-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete FROM tblStockIn WHERE sid like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product Stock-in has been successfully Deleted.", "Deleting Stock-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockInHistory();
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
