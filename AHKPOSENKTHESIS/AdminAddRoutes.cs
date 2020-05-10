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
    public partial class AdminAddRoutes : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        AdminRoutes rlist;

        public AdminAddRoutes(AdminRoutes rr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rlist = rr;

            this.KeyPreview = true;
        }

        private void ClearRoute()
        {
            txtRoute.Clear();
        }

        private void FrmRoute_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtRoute.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    txtRoute.Focus();
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this route?", "New Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblRoutes (route, datecreated) VALUES (@route, @date)", cn);
                    cm.Parameters.AddWithValue("@route", txtRoute.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    ClearRoute();
                    rlist.ShowRoutes();
                    this.Dispose();
                    MessageBox.Show("Route has been successfully Saved", "Route Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Update this Route?", "Update Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblRoutes Set route = @route, dateupdated = @update WHERE rid like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@route", txtRoute.Text);
                    cm.Parameters.AddWithValue("@update", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated", "Route Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rlist.ShowRoutes();
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
            ClearRoute();
            this.Dispose();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void FrmRoute_Click(object sender, EventArgs e)
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
    }
}
