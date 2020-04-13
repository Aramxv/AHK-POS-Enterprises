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
    public partial class FrmCategory : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        FrmCategoryList flist;

        public FrmCategory(FrmCategoryList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ClearData()
        {
            BtnSave.Enabled = true;
            BtnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == String.Empty)
                {
                    MessageBox.Show("Please Fill Category to Proceed.", "Saving New Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Category has been successfully saved", "Saving New Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    flist.LoadCategory();
                    this.Dispose();
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
                if (MessageBox.Show("Are you sure you want to update this Category?", "Deleting Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCategory Set category = @category, lastupdate = @date WHERE cid like '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category Information has been Deleted.", "Deleted Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flist.LoadCategory();
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
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cn.Close();
            this.Dispose();
        }
    }
}
