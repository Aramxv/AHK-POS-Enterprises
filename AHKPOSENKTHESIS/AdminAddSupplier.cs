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
    public partial class AdminAddSupplier : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        AdminSupplier suplist;

        string tiltlesataas = "Supplier Module";

        public AdminAddSupplier(AdminSupplier slist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            suplist = slist;
        }


        private void ClearSupplierInformatiion()
        {
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierPhone.Clear();
            txtSupplierTelephone.Clear();
        }


   
        private void FrmSupplier_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Dispose();
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Supplier?", tiltlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSupplier Set supplier = @supplier, address = @address, phone = @phone, telephone = @telephone, lastupdate = @lastupdate WHERE id like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cm.Parameters.AddWithValue("@address", txtSupplierAddress.Text);
                    cm.Parameters.AddWithValue("@phone", txtSupplierPhone.Text);
                    cm.Parameters.AddWithValue("@telephone", txtSupplierTelephone.Text);
                    cm.Parameters.AddWithValue("@lastupdate", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully Updated", tiltlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    suplist.ShowSuppliers();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(475, 113);

                    txtSupplierName.Focus();
                    return;
                }
                if (txtSupplierAddress.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(475, 191);

                    txtSupplierAddress.Focus();
                    return;
                }
                if (txtSupplierPhone.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(299, 267);

                    txtSupplierPhone.Focus();
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this Supplier?", tiltlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblSupplier (supplier, address, phone, telephone, date) VALUES (@supplier, @address, @phone, @telephone, @date)", cn);
                    cm.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cm.Parameters.AddWithValue("@address", txtSupplierAddress.Text);
                    cm.Parameters.AddWithValue("@phone", txtSupplierPhone.Text);
                    cm.Parameters.AddWithValue("@telephone", txtSupplierTelephone.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been succesfully saved", tiltlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSupplierInformatiion();
                    suplist.ShowSuppliers();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cn.Close();
            ClearSupplierInformatiion();
            this.Dispose();
        }

        private void txtSupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //accept backspace 
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48 - 57 between 0-9
            {
                e.Handled = true;
            }
        }

        private void txtSupplierTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                //accept backspace 
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code 48 - 57 between 0-9
            {
                e.Handled = true;
            }
        }
    }
}
