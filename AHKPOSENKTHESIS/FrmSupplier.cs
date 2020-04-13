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
    public partial class FrmSupplier : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        FrmSupplierList suplist;

        string tiltlesataas = "Supplier Module";

        public FrmSupplier(FrmSupplierList slist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            suplist = slist;
        }


        private void ClearSup()
        {
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierPhone.Clear();
            txtSupplierTelephone.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill Supplier's Name to Proceed.", "Saving New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierName.Focus();
                    return;
                }
                if (txtSupplierAddress.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill Supplier's Address to Proceed.", "Saving New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierAddress.Focus();
                    return;
                }
                if (txtSupplierPhone.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill Supplier's Phone contact to Proceed.", "Saving New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierPhone.Focus();
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this Supplier?", tiltlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
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
                    ClearSup();
                    suplist.LoadSuppliers();
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
            this.Dispose();
        }

      
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Supplier?", tiltlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
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
                    suplist.LoadSuppliers();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
