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
    public partial class FrmCreateUser : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        string titlesataas = "Administrator: User Accounts";


        public FrmCreateUser()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

       

        //Clear the texts in create account groupbox
        private void Clear()
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

      
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRetypePass.Text)
                {
                    MessageBox.Show("Password did not match! Please try Again.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to Create this account?", titlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    Clear();
                    MessageBox.Show("User Account has been Created", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmUserList use = new FrmUserList();
                    use.LoadAccounts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update this Account?", titlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblUsers SET name = @name, username = @username, password = @password, question = @question, answer = @answer, account = @account, dateupdated = @date WHERE username like @username", cn);
                    cm.Parameters.AddWithValue("@name", txtFullname.Text);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@question", cmbQuestion.Text);
                    cm.Parameters.AddWithValue("@answer", txtAnswer.Text);
                    cm.Parameters.AddWithValue("@account", cmbAccount.Text);
                    cm.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cm.ExecuteNonQuery();
                    Clear();
                    cn.Close();
                    MessageBox.Show("User Account has been Updated", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmUserList use = new FrmUserList();
                    use.LoadAccounts();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
