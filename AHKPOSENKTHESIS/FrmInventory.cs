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
    public partial class FrmInventory : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        public FrmInventory()
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
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            AlertCriticalProducts();
        }

        public void UpdateCritical()
        {
            string alert = "Critical";
            string healthy = "Good";

            if (dataGridView1.Rows.Count > 0)
            {
                {
                    // Create loop
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()))
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", alert);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                            //   MessageBox.Show("[NOTICE] There is a Product with Critical Stock", "Critical Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Alert.Show("Critical Products", Alert.AlertType.critical);
                        }
                        else
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", healthy);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.SeaGreen;
                            cn.Close();
                        }
                    }
                }
            }
        }

        public void AlertCriticalProducts()
        {
            try
            {
                UpdateCritical();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmInventory_Load(object sender, EventArgs e)
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

            LoadShitData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadShitData();
        }

        private void BtnStockAdjust_Click(object sender, EventArgs e)
        {
            FrmStockAdjustment adj = new FrmStockAdjustment();
            adj.LoadStocks();
            adj.GetReferenceNo();
            adj.ShowDialog();
        }
    }
}
