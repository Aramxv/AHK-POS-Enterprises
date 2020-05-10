using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminAddProduct : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        AdminProducts PRlist;

        public AdminAddProduct(AdminProducts Plist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            PRlist = Plist;

            this.KeyPreview = true;
            PopulateCategoryInCombobox();
        }

        private void ClearData()
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            txtCode.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtCode.Focus();
            txtCategory.SelectedIndex = -1;
            txtQuan.Clear();
            txtWarnqty.Clear();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        public void PopulateCategoryInCombobox()
        {
            txtCategory.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT category from tblCategory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void FrmProduct_Click(object sender, EventArgs e)
        {
            WarningIndicator.Visible = false;
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
            cm.Parameters.AddWithValue("@qty", txtQuan.Text);
            cm.Parameters.AddWithValue("@warningqty", txtWarnqty.Text);
            cm.Parameters.AddWithValue("@status", stats);
            cm.Parameters.AddWithValue("@date", dateTimePicker.Value);
            cm.ExecuteNonQuery();
            cn.Close();
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

        private void txtQuan_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cn.Close();
            ClearData();
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == String.Empty) 
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(522, 100);
                txtDesc.Focus();
                return;
            }
            if (txtCode.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(522, 173);
                return;
            }
            if (txtCategory.Text == String.Empty)
            {
                WarningIndicator.Location = new System.Drawing.Point(377, 247);
                WarningIndicator.Visible = true;
               
                txtDesc.Focus();
                return;
            }
            if (txtPrice.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(319, 313);
                txtDesc.Focus();
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
                    MessageBox.Show("Product Information Successfully Saved. ", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                    ClearData();
                    PRlist.ShowAllProductsInDatabase();
                    this.Dispose();
                }
                cn.Close();
            }
            if (dt.Rows.Count <= 0)
            {
                //Automation of Inserting Category in category table
                InsertCategory();
                InsertProductInformation();

                MessageBox.Show("Product Information Successfully Saved.", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();

                ClearData();
                PRlist.ShowAllProductsInDatabase();
                this.Dispose();
            }
            else
            {
                return;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure you want to Update this Product Information?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("Product Information Successfully Saved.", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    PRlist.ShowAllProductsInDatabase();
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

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void pnlWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
