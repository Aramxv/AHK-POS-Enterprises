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
    public partial class AdminAddCategory : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        AdminCategory flist;

        public AdminAddCategory(AdminCategory frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;

            this.KeyPreview = true;
        }

        public void ClearData()
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    txtCategory.Focus();
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this Category?", "Updating Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCategory Set category = @category, lastupdate = @date WHERE cid like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category Information has been successfully updated.", "Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flist.ShowCategories();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    txtCategory.Focus();
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this Category?", "Saving New Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCategory (category, date)VALUES (@category, @date)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully saved.", "Category Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    flist.ShowCategories();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCategory_Click(object sender, EventArgs e)
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

        private void FrmCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
