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
    public partial class FrmCustomer : Form
    { 
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        
        FrmCustomerList CSlist;
        string stitle = "Routes";

        public FrmCustomer(FrmCustomerList Clist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            CSlist = Clist;
        }


        public void ClearCustomer()
        {
            txtCustomerName.Clear();
            txtOwnerName.Clear();
            txtAddress.Clear();
            txtRoute.Clear();
            txtPhone.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            cbxActive.SelectedIndex = -1;
        }

        public void InsertRoute()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tblRoutes (route, datecreated) VALUES (@route, @date)", cn);
            cm.Parameters.AddWithValue("@route", txtRoute.Text);
            cm.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cm.ExecuteNonQuery();
            cn.Close();
        }
      
        public void InsertCustomerInformation()
        {
            //INSERTION
            cn.Open();
            cm = new SqlCommand("INSERT INTO tblCustomer (customername, name, address, route, phone, telephone, email, status, datecreated) VALUES (@customername, @name, @address, @route, @phone, @telephone, @email, @status, @date)", cn);
            cm.Parameters.AddWithValue("@customername", txtCustomerName.Text);
            cm.Parameters.AddWithValue("@name", txtOwnerName.Text);
            cm.Parameters.AddWithValue("@address", txtAddress.Text);
            cm.Parameters.AddWithValue("@route", txtRoute.Text);
            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
            cm.Parameters.AddWithValue("@telephone", txtTelephone.Text);
            cm.Parameters.AddWithValue("@email", txtEmail.Text);
            cm.Parameters.AddWithValue("@status", cbxActive.Text);
            cm.Parameters.AddWithValue("@date", DateTime.Now);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        //Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == String.Empty || txtOwnerName.Text == String.Empty || txtAddress.Text == String.Empty || txtRoute.Text == String.Empty)
            {
                MessageBox.Show("Please Fill the Important Details to proceed(*).", "Saving New Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cn.Open();
                cm = new SqlCommand("SELECT route FROM tblRoutes WHERE route = @route", cn);
                cm.Parameters.AddWithValue("@route", txtRoute.Text);
                da = new SqlDataAdapter(cm);
                dt = new DataTable();
                da.Fill(dt);
                cn.Close();

                if (dt.Rows.Count >= 1)
                {
                    InsertCustomerInformation();
                    MessageBox.Show("Customer Information Successfully Saved Into Database, You may now view it in customer tab", "Saving New Customer Informtaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                    ClearCustomer();
                    CSlist.LoadCustomersInfo();
                    this.Hide();
                }
                cn.Close();
            }
            if (dt.Rows.Count <= 0)
            {
                InsertRoute();
                InsertCustomerInformation();

                MessageBox.Show("Customer Information Successfully Saved Into Database, You may now view  it in customer tab", "Saving New Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();

                ClearCustomer();
                CSlist.LoadCustomersInfo();
                this.Dispose();
            }
            else
            {
                return;
            }
        }

        //Control Box
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cn.Close();
            ClearCustomer();
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cn.Close();
            ClearCustomer();
            this.Dispose();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
           
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
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

        //Update Button
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update the Customer Information?", "Customer Module", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCustomer SET customername = @customer, name = @name, address = @address, route = @route, phone =@phone, telephone = @tel, email = @email, status = @status, dateupdated = @date WHERE id like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@customer", txtCustomerName.Text);
                    cm.Parameters.AddWithValue("@name", txtOwnerName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@route", txtRoute.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@tel", txtTelephone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@status", cbxActive.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer Information Successfully Updated!", "Customer Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CSlist.LoadCustomersInfo();
                  //  LoadRoutes();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Dispose();
        }

        private void cbxRoute_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRoute.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    //AUTOCOMPLETE TEXTBOX BASED ON CATEGORY
                    cn.Open();
                    cm = new SqlCommand("SELECT route FROM tblRoutes WHERE route LIKE @route", cn);
                    cm.Parameters.Add(new SqlParameter("@route", "%" + txtRoute.Text + "%"));
                    cm.ExecuteNonQuery();
                    dr = cm.ExecuteReader();

                    AutoCompleteStringCollection com = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        com.Add(dr.GetString(0));
                    }
                    //cbxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
                    //cbxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtRoute.AutoCompleteCustomSource = com;
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
