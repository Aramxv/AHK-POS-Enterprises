using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace AHKPOSENKTHESIS
{
    public partial class Login : Form
    {
        //declare varaibles for sql
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();
        string titlesataas = "AHK Enterprises";

        public static string ClickPassName;
        public static string ClickPassAccount;

        public static string InvPassName;
        public static string InvPassAccount;
        public static string InvPassUser;


        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            preLoad.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void ClearLogin()
        {
            txtUser.Clear();
            txtPassword.Clear();
        }


        //Close Buttons 
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Shutdown Application. Click Yes to confirm?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void emptyUsername()
        {
            // Set the location 
            pnlWarning.Visible = true;
            pnlWarning.Location = new System.Drawing.Point(23, 568);

            // Set a message to the user
            lblWarning.Text = "Username is Empty";
            txtUser.Focus();
            return;
        }

        private void emptyPassword()
        {
            // Set the location 
            pnlWarning.Visible = true;
            pnlWarning.Location = new System.Drawing.Point(23, 568);

            // Set a message to the user
            lblWarning.Text = "Password is Empty";
            txtPassword.Focus();
            return;
        }

        private void misCredentials()
        {
            // Set the location 
            pnlWarning.Visible = true;
            pnlWarning.Location = new System.Drawing.Point(23, 568);

            // Set a message to the user
            lblWarning.Text = "Username and Password is invalid.";
            txtUser.Focus();
            return;
        }

        private void onClickHideIndicators()
        {
            pnlWarning.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string _username = "";
            string _password = "";
            string _account = "";
            string _name = "";
            string _logdate = DateTime.Now.ToString("yyyyMMdd");

            try
            {
                bool found = false;

                if (txtUser.Text == String.Empty)
                {
                    emptyUsername();
                }
                if (txtPassword.Text == String.Empty)
                {
                    emptyPassword();
                }
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblUsers WHERE username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _password = dr["password"].ToString();
                    _account = dr["account"].ToString();
                    _name = dr["name"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                // Set Conditions if Username and Password is correct
                if (found == true)
                {
                    
                    if (_account == "System Administrator")
                    {
                        preLoad.Visible = true;
                        MessageBox.Show("Access Granted! Welcome " + _name + " as System Administrator.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearLogin();
                        this.Hide();

                        ClickPassName = _name;
                        ClickPassAccount = _account;

                        FrmLoading loading = new FrmLoading();
                        loading.Show();
                        this.Hide();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblLogTrails (name, username, account, logindate) VALUES (@name, @username, @account, @logdate)", cn);
                        cm.Parameters.AddWithValue("@name", _name);
                        cm.Parameters.AddWithValue("@username", _username);
                        cm.Parameters.AddWithValue("@account", _account);
                        cm.Parameters.AddWithValue("@logdate", dateTimePicker1.Value);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    else
                    {
                        preLoad.Visible = true;
                        MessageBox.Show("Access Granted! Welcome " + _name + " as Invoicer.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Clear the textboxes
                        ClearLogin();
                        this.Hide();

                        InvPassName = _name;
                        InvPassAccount = _account;
                        InvPassUser = _username;

                        FrmLoading2 load = new FrmLoading2();
                        load.Show();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblLogTrails (name, username, account, logindate) VALUES (@name, @username, @account, @logdate)", cn);
                        cm.Parameters.AddWithValue("@name", _name);
                        cm.Parameters.AddWithValue("@username", _username);
                        cm.Parameters.AddWithValue("@account", _account);
                        cm.Parameters.AddWithValue("@logdate", dateTimePicker1.Value);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                else
                {
                    misCredentials();
                    ClearLogin();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Click(object sender, EventArgs e)
        {
            onClickHideIndicators();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            onClickHideIndicators();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            onClickHideIndicators();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            onClickHideIndicators();
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string _username = "";
                string _password = "";
                string _account = "";
                string _name = "";
                string _logdate = DateTime.Now.ToString("yyyyMMdd");

                try
                {
                    bool found = false;

                    if (txtUser.Text == String.Empty)
                    {
                        emptyUsername();
                    }
                    if (txtPassword.Text == String.Empty)
                    {
                        emptyPassword();
                    }
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblUsers WHERE username = @username and password = @password", cn);
                    cm.Parameters.AddWithValue("@username", txtUser.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {

                        found = true;
                        _username = dr["username"].ToString();
                        _password = dr["password"].ToString();
                        _account = dr["account"].ToString();
                        _name = dr["name"].ToString();
                    }
                    else
                    {
                        found = false;
                    }
                    dr.Close();
                    cn.Close();

                    //Set Conditions if Username and Password is correct
                    if (found == true)
                    {
                        if (_account == "System Administrator")
                        {
                            preLoad.Visible = true;
                            MessageBox.Show("Access Granted! Welcome " + _name + " as System Administrator.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearLogin();
                            this.Hide();

                            ClickPassName = _name;
                            ClickPassAccount = _account;

                            FrmLoading loading = new FrmLoading();
                            loading.Show();
                            this.Hide();

                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tblLogTrails (name, username, account, logindate) VALUES (@name, @username, @account, @logdate)", cn);
                            cm.Parameters.AddWithValue("@name", _name);
                            cm.Parameters.AddWithValue("@username", _username);
                            cm.Parameters.AddWithValue("@account", _account);
                            cm.Parameters.AddWithValue("@logdate", dateTimePicker1.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        else
                        {
                            preLoad.Visible = true;
                            MessageBox.Show("Access Granted! Welcome " + _name + " as Invoicer.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Clear the textboxes
                            ClearLogin();
                            this.Hide();

                            InvPassName = _name;
                            InvPassAccount = _account;
                            InvPassUser = _username;

                            FrmLoading2 load = new FrmLoading2();
                            load.Show();

                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tblLogTrails (name, username, account, logindate) VALUES (@name, @username, @account, @logdate)", cn);
                            cm.Parameters.AddWithValue("@name", _name);
                            cm.Parameters.AddWithValue("@username", _username);
                            cm.Parameters.AddWithValue("@account", _account);
                            cm.Parameters.AddWithValue("@logdate", dateTimePicker1.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                    else
                    {
                        misCredentials();
                        ClearLogin();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
