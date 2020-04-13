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
    public partial class FrmRoute : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        FrmRoutelist rlist;

        public FrmRoute(FrmRoutelist rr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            rlist = rr;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Dispose this form
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Dipose this form
            this.Dispose();
        }

        private void ClearRoute()
        {
            txtRoute.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this route?", "Route Module", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblRoutes (route, datecreated) VALUES (@route, @date)", cn);
                    cm.Parameters.AddWithValue("@route", txtRoute.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    ClearRoute();
                    rlist.LoadRoutes();
                    this.Dispose();
                    MessageBox.Show("Route has been successfully Saved", "Route Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               if (MessageBox.Show("Do you want to Update this Route?", "AHK Routes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblRoutes Set route = @route, dateupdated = @update WHERE rid like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@route", txtRoute.Text);
                    cm.Parameters.AddWithValue("@update", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated", "AHK Routes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rlist.LoadRoutes();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
