using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmLogin : Form
    {
        //declare varaibles for sql
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DatabaseConnection dbcon = new DatabaseConnection();
        string titlesataas = "AHK Enterprises Security";

        public static string ClickPassName;
        public static string ClickPassAccount;

        public static string InvPassName;
        public static string InvPassAccount;
        public static string InvPassUser;


        public FrmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        //Use of Key Enter to Login
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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

                    if ((txtUser.Text == String.Empty) && (txtPassword.Text == String.Empty))
                    {
                        MessageBox.Show("Please enter your Username and Password.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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
                            MessageBox.Show("Access Granted! Welcome " + _name + "!", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Access Granted! Welcome " + _name + "!", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Invalid Username and Password", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearLogin();
                        txtUser.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void ClearLogin()
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            string _username = "";
            string _password = "";
            string _account = "";
            string _name = "";
            string _logdate = DateTime.Now.ToString("yyyyMMdd");

            try
            {
                bool found = false;

                if ((txtUser.Text == String.Empty) && (txtPassword.Text == String.Empty))
                {
                    MessageBox.Show("Please enter your Username and Password.", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
                        MessageBox.Show("Access Granted! Welcome " + _name + "!", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Access Granted! Welcome " + _name + "!", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Invalid Username and Password", titlesataas, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearLogin();
                    txtUser.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Close Buttons 
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Shutting down the AHK POSIM. Confirm?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        //Minimize Button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
