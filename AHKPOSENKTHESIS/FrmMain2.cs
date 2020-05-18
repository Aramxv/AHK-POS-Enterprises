using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AHKPOSENKTHESIS
{
    public partial class FrmMain2 : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        public static string PasslblName;

        public static string PassAdminName;
        public static string PassAccountType;

        public static string BackToAdminName;
        public static string BackToAdminAccount;

        public static string PassChangeUsename;
      
        public FrmMain2()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            //initializes the date in creating invoice
            lblDate.Text = DateTime.Now.ToLongDateString();
           
            this.KeyPreview = true;
        }
     
      

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowInvoiceInFront();

            PassAdminName = lblUsername.Text;
            PassAdminName = lblName.Text;
            PassAccountType = lblAccount.Text;
            PassAccountType = lblPosition.Text;
        }

        //Control Box
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowInvoiceInFront()
        {
            //Off the visibility of the Button of see products
            BtnSeeProducts.Visible = false;
            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Pass the label name of the user logged in


            //Off the visibility of the Button of User Account 
            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //This line of code here is the process of passing the Full name of account logged in to the system,
            //so, we can record the name of the invoicer who process the order.
            PasslblName = lblUsername.Text;


            //Container 1
            FrmCreateNewInvoice XXL = new FrmCreateNewInvoice();  //Set a variable to call the form
            XXL.Size = Container1.Size;
            XXL.TopLevel = false;                                //Make the toplevel = 0
            Container1.Controls.Clear();                         //Clear the Container first (Para kung may laman matatanggal muna bago mo ilagay kung anung form man ilalagay mo)
            Container1.Controls.Add(XXL);
            XXL.BringToFront();                                  //Bring the form in front of the other peripherals
            XXL.LoadCustomersFromDatabaseToCustomerCombobox();   // Populate the Customer Combobox with Customer name in the database
            XXL.Show();                                          //Show the form

            //Indicators
            Indicator1.Visible = true;  //1
            Indicator2.Visible = false; //0
            Indicator3.Visible = false; //0
            Indicator4.Visible = false; //0
            Indicator5.Visible = false; //0
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            //Off the visibility of the Button of see products
            BtnSeeProducts.Visible = false;
            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Pass the label name of the user logged in
            

            //Off the visibility of the Button of User Account 
            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //This line of code here is the process of passing the Full name of account logged in to the system,
            //so, we can record the name of the invoicer who process the order.
            PasslblName = lblUsername.Text;

            //Container 1
            FrmCreateNewInvoice XXL = new FrmCreateNewInvoice();  //Set a variable to call the form
            XXL.Size = Container1.Size;
            XXL.TopLevel = false;                           //Make the toplevel = 0
            Container1.Controls.Clear();                    //Clear the Container first (Para kung may laman matatanggal muna bago mo ilagay kung anung form man ilalagay mo)
            Container1.Controls.Add(XXL);
            XXL.BringToFront();                             //Bring the form in front of the other peripherals
            XXL.Show();                                     //Show the form

            //Indicators
            Indicator1.Visible = true;  //1
            Indicator2.Visible = false; //0
            Indicator3.Visible = false; //0
            Indicator4.Visible = false; //0
            Indicator5.Visible = false; //0
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            //Set it to appear once button is clicked
            BtnSeeProducts.Visible = true;
            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Off the visibility of the Button of User Account 
            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //Relocate the button and the indicator to center
            BtnSeeProducts.Location = new System.Drawing.Point(703, 79);
            Indicator5.Location = new System.Drawing.Point(703, 115);
            
            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = true;  //1
            Indicator3.Visible = false; //0
            Indicator4.Visible = false; //0
            Indicator5.Visible = true;  //1
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0

            // Show the Products list 
            Frm2SeeProducts CC = new Frm2SeeProducts();
            CC.Size = Container1.Size;
            CC.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(CC);
            CC.BringToFront();
            CC.Show();
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            //Off the visibility of the Button of see products
            BtnSeeProducts.Visible = false;
            Indicator8.Visible = false;

            //Relocate the Buttons and indicators
            BtnInvoices.Visible = true;
            BtnInvoices.Location = new System.Drawing.Point(661, 79);
            Indicator6.Location = new System.Drawing.Point(662, 115);

            BtnCustomers.Visible = true;
            BtnCustomers.Location = new System.Drawing.Point(767, 79);
            Indicator7.Location = new System.Drawing.Point(767, 115);

            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = false; //0
            Indicator3.Visible = true;  //1
            Indicator4.Visible = false; //0
            Indicator5.Visible = false; //0
            Indicator6.Visible = true; //1
            Indicator7.Visible = false; //0

            //Show the Invoice List 
            Frm2SavedInvoices SV = new Frm2SavedInvoices();
            SV.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(SV);
            SV.BringToFront();
            SV.Show();
        }
       
        private void BtnSeeProducts_Click(object sender, EventArgs e)
        {
            //Set it to appear once button is clicked
            BtnSeeProducts.Visible = true;
            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Off the visibility of the Button of User Account 
            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //Relocate the button and the indicator to center
            BtnSeeProducts.Location = new System.Drawing.Point(703, 79);
            Indicator5.Location = new System.Drawing.Point(703, 115);
            //Indicators
            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = true;
            Indicator3.Visible = false;
            Indicator4.Visible = false; //0
            Indicator5.Visible = true;
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0
            Indicator5.Visible = true; //1

            Frm2SeeProducts CC = new Frm2SeeProducts();
            CC.Size = Container1.Size;
            CC.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(CC);
            CC.BringToFront();
            CC.Show();

        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        { 
            //Off the visibility of the Button of see products
            BtnSeeProducts.Visible = false;
            Indicator8.Visible = false;

            //Relocate the Buttons and indicators
            BtnInvoices.Visible = true;
            BtnInvoices.Location = new System.Drawing.Point(661, 79);
            Indicator6.Location = new System.Drawing.Point(662, 115);

            BtnCustomers.Visible = true;
            BtnCustomers.Location = new System.Drawing.Point(767, 79);
            Indicator7.Location = new System.Drawing.Point(767, 115);

            BtnUserAccount.Visible = false;
            Indicator8.Visible = false;

            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = false; //0
            Indicator3.Visible = true;  //1
            Indicator4.Visible = false; //0
            Indicator5.Visible = false;
            Indicator6.Visible = true;
            Indicator7.Visible = false; //0

            Frm2SavedInvoices SV = new Frm2SavedInvoices();
            SV.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(SV);
            SV.BringToFront();
            SV.Show();

           
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            Frm2SeeCustomers XC = new Frm2SeeCustomers();
            XC.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(XC);
            XC.BringToFront();
            XC.Show();
            
            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = false; //0
            Indicator3.Visible = true;
            Indicator4.Visible = false; //0
            Indicator5.Visible = false; //0
            Indicator6.Visible = false; //0
            Indicator7.Visible = true;  //1

            //Off the visibility of the Button of see products
            BtnSeeProducts.Visible = false;

            //Off the visibility of the Button of User Account 
            BtnUserAccount.Visible = false;
        }

        private void BtnActionCentre_Click(object sender, EventArgs e)
        {
            PassChangeUsename = lblUsername.Text;

            //Make the User Button and indicator8 visible
            BtnUserAccount.Visible = true;
            BtnUserAccount.Location = new System.Drawing.Point(701, 79);
            
            Indicator8.Location = new System.Drawing.Point(701, 115);

            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = false; //0
            Indicator3.Visible = false; //0
            Indicator4.Visible = false; //0
            Indicator5.Visible = false; //0
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0
            Indicator8.Visible = false; //0
        }

        private void BtnUserAccount_Click(object sender, EventArgs e)
        {
            PassChangeUsename = lblUsername.Text;

            //Make the User Button and indicator8 visible
            BtnUserAccount.Visible = true;
            BtnUserAccount.Location = new System.Drawing.Point(701, 79);

            Indicator8.Location = new System.Drawing.Point(701, 115);

            BtnInvoices.Visible = false;
            BtnCustomers.Visible = false;

            //Indicators
            Indicator1.Visible = false; //0
            Indicator2.Visible = false; //0
            Indicator3.Visible = false; //0
            Indicator4.Visible = true;
            Indicator5.Visible = false; //0
            Indicator6.Visible = false; //0
            Indicator7.Visible = false; //0
            Indicator8.Visible = true;

            FrmActionCentre act = new FrmActionCentre();
            act.TopLevel = false;
            Container1.Controls.Clear();
            Container1.Controls.Add(act);
            act.BringToFront();
            act.Show();

         
        }

        private void BtnBackAdminMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Go back to Administrator Mode?", "Security", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BackToAdminName = lblUsername.Text;
                BackToAdminAccount = lblAccount.Text;

                FrmLoading4 load = new FrmLoading4();
                load.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Main Form Hot Keys
        private void FrmMain2_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                BtnInvoice_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                BtnSeeProducts_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                BtnInvoices_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                BtnUserAccount_Click(sender, e);
            }
        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            if (AvatarPanel.Visible == false)
            {
                AvatarPanel.Visible = true;
            }
            else
            {
                AvatarPanel.Visible = false;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (AvatarPanel.Visible == true)
            {
                AvatarPanel.Visible = false;
            }
            else
            {
                AvatarPanel.Visible = false;
            }
        }

        private void Container1_Click(object sender, EventArgs e)
        {
            if (AvatarPanel.Visible == true)
            {
                AvatarPanel.Visible = false;
            }
            else
            {
                AvatarPanel.Visible = false;
            }
        }

        private void BtnOpLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Terminate the application
                //System.Windows.Forms.Application.Exit();
                this.Dispose();

                //Return to the login form
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        // Show the Change password dialog 
        private void BtnOpChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassword pass = new FrmChangePassword();
            pass.Show();
        }

        private void BtnOpUserProf_Click(object sender, EventArgs e)
        {
            FrmUserProfile profile = new FrmUserProfile();
            profile.ShowDialog();
        }
    }
}
