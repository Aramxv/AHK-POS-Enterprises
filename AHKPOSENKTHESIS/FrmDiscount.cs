﻿using System;
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
    public partial class FrmDiscount : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
       

        FrmCreateNewInvoice dis;

        public FrmDiscount(FrmCreateNewInvoice count)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            dis = count;

            this.KeyPreview = true;
        }

        private void TxtPercentDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(txtPrice.Text) * Double.Parse(txtPercentDiscount.Text);
                txtAmountDiscount.Text = discount.ToString("#,##0.00");
            }
            catch (Exception)
            {
                txtAmountDiscount.Text = "0.00";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add Discount to this item?", "Discount Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblInvoiceOrder SET discount = @discount WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@discount", Double.Parse(txtAmountDiscount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    dis.LoadInvoiceOrder();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
