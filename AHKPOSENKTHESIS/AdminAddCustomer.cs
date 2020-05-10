using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class AdminAddCustomer : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        AdminCustomer CSlist;

        string stitle = "Routes";

        public AdminAddCustomer(AdminCustomer Clist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            CSlist = Clist;

            this.KeyPreview = true;
        }

        public void ClearCustomer()
        {
            txtCustomerName.Clear();
            txtOwnerName.Clear();
            txtAddress.Clear();
            txtRoute.SelectedIndex = -1;
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
            // INSERTION
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

        public void PopulateRouteCombobox()
        {
            txtRoute.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT route from tblRoutes", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtRoute.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
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


        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            cn.Close();
            ClearCustomer();
            this.Dispose();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(486, 104);
                txtCustomerName.Focus();
                return;
            }
            if (txtOwnerName.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(486, 175);
                txtOwnerName.Focus();
                return;
            }
            if (txtAddress.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(485, 246);
                txtAddress.Focus();
                return;
            }
            if (txtRoute.Text == String.Empty)
            {
                WarningIndicator.Visible = true;
                WarningIndicator.Location = new System.Drawing.Point(276, 311);
                txtRoute.Focus();
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
                    MessageBox.Show("Customer Information Successfully Saved.", "Saving New Customer Informtaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                    ClearCustomer();
                    CSlist.ShowCustomersInformation();
                    this.Hide();
                }
                else if (dt.Rows.Count <= 0)
                {
                    InsertRoute();
                    AdminRoutes rout = new AdminRoutes();
                    rout.ShowRoutes();
                    InsertCustomerInformation();

                    MessageBox.Show("Customer Information Successfully Saved Into Database.", "Customer Information Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                    ClearCustomer();
                    CSlist.ShowCustomersInformation();
                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
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
                    CSlist.ShowCustomersInformation();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            cn.Close();
            ClearCustomer();
            this.Dispose();
        }

        private void FrmCustomer_Click(object sender, EventArgs e)
        {
            if (WarningIndicator.Visible == true)
            {
                WarningIndicator.Visible = false;
            }
            else
            {
                WarningIndicator.Visible = false;
            }
        }

        private void FrmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
