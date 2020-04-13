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

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;


namespace AHKPOSENKTHESIS
{
    public partial class Form1 : MaterialForm
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        string titlesataas = "AHK Administrator: Security";

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());


            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey900,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are now entering the AHK Enterprises Point of Sales Module. Click Yes if you want to continue.", "Point of Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
               
            }
            return;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {                                                 //Container == panel3; or any panel you assign
            FrmProductlist shit = new FrmProductlist();   //Call the Form; Set Variable
            shit.TopLevel = false;                        //Set the Form TopLevel 0
            Container.Controls.Clear();                      //Clear the Container controls
            Container.Controls.Add(shit);                    //Add the Form to the Container
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.LoadShitData();                          //Function Definition
            shit.Show();                                  //Show the Form 
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            FrmCategoryList Cat = new FrmCategoryList();
            Cat.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(Cat);
            Cat.BringToFront();
            Cat.LoadCategory();
            Cat.Show();
        }

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            FrmStockIn stk = new FrmStockIn();
            stk.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(stk);
            stk.BringToFront();
          //  stk.LoadProduct();
            stk.Show();
        }
        private void BtnUserSettings_Click(object sender, EventArgs e)
        {
            FrmCreateUser user = new FrmCreateUser();
            user.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(user);
            user.BringToFront();
           // user.LoadAccounts();
            user.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Logout?", titlesataas, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {                                                 //Container == panel3; or any panel you assign
            FrmDashboard shit = new FrmDashboard();   //Call the Form; Set Variable
            shit.TopLevel = false;                        //Set the Form TopLevel 0
            Container.Controls.Clear();                      //Clear the Container controls
            Container.Controls.Add(shit);                    //Add the Form to the Container
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.Show();                                  //Show the Form 
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
