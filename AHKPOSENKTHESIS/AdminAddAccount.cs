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
    public partial class AdminAddAccount : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        AdminAccountSettings userset;

        public AdminAddAccount(AdminAccountSettings set)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            userset = set;
        }

        //Clear the texts in create account groupbox
        private void ClearData()
        {
            //Create
            txtFullname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRetypePass.Clear();
            cmbQuestion.SelectedIndex = -1;
            cmbAccount.SelectedIndex = -1;
            txtAnswer.Clear();
        }

        private void FrmCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Input Validations
                if (txtFullname.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(433, 119);
                    txtFullname.Focus();
                    return;
                }
                if (txtUsername.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(433, 196);
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(433, 280);
                    txtPassword.Focus();
                    return;
                }
                if (txtPassword.Text != txtRetypePass.Text)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(433, 362);
                    txtPassword.Focus();
                    MessageBox.Show("Password did not match! Please try Again.", "Account Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbQuestion.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(418, 439);
                    cmbQuestion.Focus();
                    return;
                }
                if (txtAnswer.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(433, 519);
                    txtAnswer.Focus();
                    return;
                }
                if (cmbAccount.Text == String.Empty)
                {
                    WarningIndicator.Visible = true;
                    WarningIndicator.Location = new System.Drawing.Point(417, 596);
                    cmbAccount.Focus();
                    return;
                }
                else
                {
                    // Check the database for duplication of username
                    cn.Open();
                    cm = new SqlCommand("SELECT username FROM tblUsers WHERE username = @username", cn);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    da = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();
                    if (dt.Rows.Count <= 0)
                    {
                        // If the input username did not found on the database, insert the information to the database.
                        CreateNewAccountProfile();
                        MessageBox.Show("User Account has been Successfully Created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();

                        ClearData();
                        userset.ShowAllAccounts();
                        this.Dispose();
                    }
                    else
                    {
                        // The username already exist, the user have to change his/her username
                        MessageBox.Show("Sorry but, the username already exist. Please select another username!", "Username Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateNewAccountProfile()
        {
            if (MessageBox.Show("Are you sure you want to Create this account?", "Creating New Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblUsers (name, username, password, question, answer, account, datecreated) VALUES (@name, @username, @password, @question, @answer, @account, @date)", cn);
                cm.Parameters.AddWithValue("@name", txtFullname.Text);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                cm.Parameters.AddWithValue("@question", cmbQuestion.Text);
                cm.Parameters.AddWithValue("@answer", txtAnswer.Text);
                cm.Parameters.AddWithValue("@account", cmbAccount.Text);
                cm.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cm.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this Account?", "Updating Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblUsers SET name = @name, username = @username, password = @password, question = @question, answer = @answer, account = @account, dateupdated = @date WHERE username = '" + lblUsername.Text + "'", cn);
                    cm.Parameters.AddWithValue("@name", txtFullname.Text);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@question", cmbQuestion.Text);
                    cm.Parameters.AddWithValue("@answer", txtAnswer.Text);
                    cm.Parameters.AddWithValue("@account", cmbAccount.Text);
                    cm.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cm.ExecuteNonQuery();
                    ClearData();
                    cn.Close();
                    MessageBox.Show("User Account has been Successfully Updated!", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminAccountSettings user = new AdminAccountSettings();
                    user.ShowAllAccounts();
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
            this.Close();
        }
    }
}
