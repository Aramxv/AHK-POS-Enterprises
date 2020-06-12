using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AHKPOSENKTHESIS
{
    public partial class AdminAccountSettings : UserControl
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        private const Int32 CUSTOM_CONTENT_HEIGHT = 18;

        public AdminAccountSettings()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        //Load all created user account in the datagrid
        public void ShowAllAccounts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUsers", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[2].ToString(), dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void BtnBacktoSettings_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminSettings"))
            {
                AdminSettings settings = new AdminSettings();
                settings.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(settings);



                AdminAdministrator admin = new AdminAdministrator();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminSettings"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
        }

        private void AdminUserSettings_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 219, 223);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 54, 75);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 5, 0, 5);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 119, 231);

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AdminAddAccount cruser = new AdminAddAccount(this);
                cruser.txtFullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cruser.txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cruser.txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cruser.txtRetypePass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cruser.cmbQuestion.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cruser.txtAnswer.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cruser.cmbAccount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                // pass the value of username to the label 
                cruser.lblUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cruser.lbl1.Text = "Update User Profile";

                //Make the Save Button not visible 
                cruser.BtnSave.Visible = false;

                //Make the Update Button visible
                cruser.BtnUpdate.Visible = true;
                cruser.ShowDialog();
                ShowAllAccounts();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Account?", "Delete Account Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete FROM tblUsers WHERE username like '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account has been successfully Deleted", "Account Profile Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllAccounts();
                }
            }
        }

        private void BtnCreateNewAccount_Click(object sender, EventArgs e)
        {
            AdminAddAccount use = new AdminAddAccount(this);

            //Make the Save Button Visible
            use.BtnSave.Visible = true;

            //Still the Update Button will not be visible 
            use.BtnUpdate.Visible = false;

            //Relocate the Save button next to Cancel Button
            use.BtnSave.Location = new System.Drawing.Point(102, 672);
            use.ShowDialog();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Active Account Shown";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDataRowCount.Text = dataGridView1.Rows.Count.ToString() + " Active Account Shown";
        }

       
    }
}
