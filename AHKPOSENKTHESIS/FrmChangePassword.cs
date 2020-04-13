using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmChangePassword : Form
    {
        //declare varaibles for sql
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();
        string title = "Security [Changing Password]";


        public FrmChangePassword()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            txtUsername.Text = FrmLogin.InvPassUser;
        }

        public void ClearPassword()
        {
            txtOldPass.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            FrmMain2 main = new FrmMain2();
            try
            {
                string _oldpass = dbcon.GetPassword(txtUsername.Text);
                if (_oldpass != txtOldPass.Text)
                {
                    MessageBox.Show("Old Password did not matched!", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("New Password didi not matched!", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Change Password?", "Changing Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblUsers SET password = @password WHERE username = @username", cn);
                        cm.Parameters.AddWithValue("@password", txtNewPass.Text);
                        cm.Parameters.AddWithValue("@username", txtUsername.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password has been Successfully Changed! You may now continue your work.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
