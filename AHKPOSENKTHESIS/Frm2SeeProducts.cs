using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class Frm2SeeProducts : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();

        public Frm2SeeProducts()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadShitData();
        }

        public void UpdateCritical()
        {
            string alert = "Critical";
            string healthy = "Good";

            if (dataGridView1.Rows.Count > 0)
            {
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", alert);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;

                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24_XX.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;

                            // Alert the user, send a pop-up notification 
                            Alert.Show("Critical Product", Alert.AlertType.critical);
                        }
                        else
                        {
                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", healthy);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.SeaGreen;
                            cn.Close();

                        }
                    }
                }
            }
        }

        public void SearchProductsWithoutNotification()
        {
            string alert = "Critical";
            string healthy = "Good";

            if (dataGridView1.Rows.Count > 0)
            {
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()) <= int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()))
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", alert);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;

                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24_XX.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;
                        }
                        else
                        {
                            // Change the picture of the cell that is in critical quantity count 
                            Image imglink = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

                            // Add a row set the value
                            dataGridView1.Rows[i].Cells[1].Value = imglink;
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET prodstatus = @status, lastupdate = @update WHERE id = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.Parameters.AddWithValue("@status", healthy);
                            cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                            cm.ExecuteNonQuery();
                            dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.SeaGreen;
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

        public void LoadShitData()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            AlertCriticalProducts();
        }

        public void SearchProducts()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            SearchProductsWithoutNotification();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void Frm2SeeProducts_Load(object sender, EventArgs e)
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

        public void ShowAllProducts()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' order by proddescrip", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            SearchProductsWithoutNotification();
        }

        public void ShowOnlyGoodStatusProducts()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' and prodstatus = 'Good' order by proddescrip", cn);


            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            SearchProductsWithoutNotification();
        }

        public void ShowOnlyCriticalProducts()
        {
            // get the path of the image
            Image img = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\icons8-used-product-24.png");

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus FROM tblProduct WHERE proddescrip like '%" + txtSearch.Text + "%' and prodstatus = 'Critical' order by proddescrip", cn);


            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, img, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
            SearchProductsWithoutNotification();
        }
        // Show all the products 
        private void BtnShowAllProducts_Click(object sender, EventArgs e)
        {
            ShowAllProducts();
        }

        private void BtnGoodProducts_Click(object sender, EventArgs e)
        {
            ShowOnlyGoodStatusProducts();
        }

        private void BtnCriticalProducts_Click(object sender, EventArgs e)
        {
            ShowOnlyCriticalProducts();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblProductRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblProductRowCount.Text = dataGridView1.Rows.Count.ToString() + " Products Shown";
        }
    }
}
