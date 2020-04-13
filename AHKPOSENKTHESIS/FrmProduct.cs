using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmProduct : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        FrmProductlist PRlist;

        public FrmProduct(FrmProductlist Plist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            PRlist = Plist;
        }

        private void ClearData()
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            txtCode.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtCode.Focus();
            txtCategory.Clear();
            txtQuan.Clear();
            txtWarnqty.Clear();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        //Insertion of Data in tblCategory Function
        public void InsertCategory()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tblCategory (category, date) VALUES (@category, @date)", cn);
            cm.Parameters.AddWithValue("@category", txtCategory.Text);
            cm.Parameters.AddWithValue("@date", dateTimePicker.Value);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        //Insertion of Data in tblProduct Function
        public void InsertProductInformation()
        {
            //Insert the product information into database (tblProduct)
            string stats = "Good";
            cn.Open();
            cm = new SqlCommand("INSERT INTO tblProduct (prodcode, proddescrip, prodprice, category, prodqty, warningqty, prodstatus, date) VALUES (@code, @desc, @price, @category, @qty, @warningqty, @status, @date)", cn);
            cm.Parameters.AddWithValue("@code", txtCode.Text);
            cm.Parameters.AddWithValue("@desc", txtDesc.Text);
            cm.Parameters.AddWithValue("@price", txtPrice.Text);
            cm.Parameters.AddWithValue("@category", txtCategory.Text);
            cm.Parameters.AddWithValue("@qty", int.Parse(txtQuan.Text));
            cm.Parameters.AddWithValue("@warningqty", int.Parse(txtWarnqty.Text));
            cm.Parameters.AddWithValue("@status", stats);
            cm.Parameters.AddWithValue("@date", dateTimePicker.Value);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        //Save the products information
        //Save the category if the category is not existing in the database
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (txtDesc.Text == String.Empty || txtCode.Text == String.Empty || txtCategory.Text == String.Empty || txtPrice.Text == String.Empty)
            {
                MessageBox.Show("Please Fill the Important Details to proceed(*).", "Saving New Product Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("SELECT category FROM tblCategory WHERE category = @category", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                da = new SqlDataAdapter(cm);
                dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count >= 1)
                {
                    InsertProductInformation();
                    MessageBox.Show("Product Information Successfully Saved Into Database, You may now view it in Products tab", "Saving New Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                    ClearData();
                    PRlist.LoadShitData();
                    this.Dispose();
                }
                cn.Close();
            }
            if (dt.Rows.Count <= 0)
            {
                //Automation of Inserting Category in category table
                InsertCategory();
                InsertProductInformation();

                MessageBox.Show("Product Information Successfully Saved Into Database, You may now view it in Products tab", "Saving New Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();

                ClearData();
                PRlist.LoadShitData();
                this.Dispose();
            }
            else
            {
                return;
            }
        }
        //Update the products information
        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure you want to Update this Product's Information?", "Updating Product information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //set parameters to update the product information
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET prodcode = @code, proddescrip = @desc, prodprice = @price, category = @category, prodqty = @qty, warningqty = @warning, lastupdate = @update WHERE id like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@desc", txtDesc.Text);
                    cm.Parameters.AddWithValue("@code", txtCode.Text);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQuan.Text));
                    cm.Parameters.AddWithValue("@warning", int.Parse(txtWarnqty.Text));
                    cm.Parameters.AddWithValue("@update", dateTimePicker.Value);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product Information Successfully Saved to Database. You can now view it in Products Tab.", "Updating Prodcut Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    PRlist.LoadShitData();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                //Log exception
                //Display Error message
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            cn.Close();
            ClearData();
            this.Dispose();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                //accept .(for cents or decimal places)
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace 
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48 - 57 between 0-9
            {
                e.Handled = true;
            }
        }


        private void txtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //accept backspace 
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void txtQuan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Dispose();
        }


        private void cbxCategory_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    //AUTOCOMPLETE TEXTBOX BASED ON CATEGORY
                    cn.Open();
                    cm = new SqlCommand("SELECT category FROM tblCategory WHERE category LIKE @category", cn);
                    cm.Parameters.Add(new SqlParameter("@category", "%" + txtCategory.Text + "%"));
                    cm.ExecuteNonQuery();
                    dr = cm.ExecuteReader();

                    AutoCompleteStringCollection com = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        com.Add(dr.GetString(0));
                    }
                    //cbxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
                    //cbxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtCategory.AutoCompleteCustomSource = com;
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
