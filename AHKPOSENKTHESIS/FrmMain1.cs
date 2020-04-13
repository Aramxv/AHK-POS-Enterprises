using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Import the Material Skin

namespace AHKPOSENKTHESIS
{
    public partial class FrmMain1 : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;

        public static string PasslblName;
        public static string PassCanName;

        public static string PassAdminName;
        public static string PassAccount;

        public static string PassToPOSName;
        public static string PassToPOSAccount;

        public static string PassStockUsername;

        public FrmMain1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            ShowDashBoardInFront();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //Close buttons
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

        //Maximize Buttone
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                Container.Size = Container.Size;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Container.Size = Container.Size;
            }
        }

        //Minimize Button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void ShowDashBoardInFront()
        {
            FrmDashboard shit = new FrmDashboard();       //Call the Form; Set Variable
            this.Size = Container.Size;
            shit.lblDailySales.Text = dbcon.GetDailySales().ToString("#,##0.00");
            shit.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
            shit.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
            shit.lblCriticalProducts.Text = dbcon.CriticalProduct().ToString("#,##0");
            shit.lblCustomerCount.Text = dbcon.CustomerCount().ToString("#,##0");
            shit.Size = Container.Size;
            shit.TopLevel = false;                        //Set the Form TopLevel 0
            Container.Controls.Clear();                   //Clear the Container controls
            Container.Controls.Add(shit);                 //Add the Form to the Container
            MngtProductsPanel.Visible = false;            //Should not to see the product management
            MngtDashboardPanel.Visible = true;            //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;            //Should not see the Customer management settings
            MngtSales.Visible = false;                //Should see the Sub report module
            materialDivider3.Visible = true;                 //Indicator is on
            materialDivider4.Visible = false;                //Indicator is off
            materialDivider5.Visible = false;                //Indicator is off
            materialDivider6.Visible = false;                //Indicator is off
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.Show();                                  //Show the Form 
        }

        //Dashboard Button
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {                                                 //Container == panel3; or any panel you assign
            FrmDashboard shit = new FrmDashboard();       //Call the Form; Set Variable
            this.Size = Container.Size;
            shit.lblDailySales.Text = dbcon.GetDailySales().ToString("#,##0.00");
            shit.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
            shit.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
            shit.lblCriticalProducts.Text = dbcon.CriticalProduct().ToString("#,##0");
            shit.lblCustomerCount.Text = dbcon.CustomerCount().ToString("#,##0");
            shit.Size = Container.Size;
            shit.TopLevel = false;                        //Set the Form TopLevel 0
            Container.Controls.Clear();                   //Clear the Container controls
            Container.Controls.Add(shit);                 //Add the Form to the Container
            MngtProductsPanel.Visible = false;            //Should not to see the product management
            MngtDashboardPanel.Visible = true;            //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;            //Should not see the Customer management settings
            MngtSales.Visible = false;                //Should see the Sub report module
            materialDivider3.Visible = true;                 //Indicator is on
            materialDivider4.Visible = false;                //Indicator is off
            materialDivider5.Visible = false;                //Indicator is off
            materialDivider6.Visible = false;                //Indicator is off
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.Show();                                  //Show the Form 
        }

        //Manage Products Button
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {                                                  //Container == panel3; or any panel you assign
            FrmProductlist shit = new FrmProductlist();    //Call the Form; Set Variable
            shit.Size = Container.Size;
            shit.TopLevel = false;                         //Set the Form TopLevel 0
            Container.Controls.Clear();                    //Clear the Container controls
            Container.Controls.Add(shit);                  //Add the Form to the Container
            MngtProductsPanel.Visible = true;              //Get to see the product management
            MngtDashboardPanel.Visible = false;            //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;             //Should not see the Customer management settings
            MngtSales.Visible = false;                     //Should see the Sub report module
            materialDivider3.Visible = false;                 //Indicator is off
            materialDivider4.Visible = true;                  //Indicator is on
            materialDivider5.Visible = false;                 //Indicator is off
            materialDivider6.Visible = false;                 //Indicator is off
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.LoadShitData();                          //Function Definition
            shit.Show();                                  //Show the Form 
        }

        //Manage Category Button
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            FrmCategoryList Cat = new FrmCategoryList();    //Call the Form; Set Variable
            Cat.Size = Container.Size;
            Cat.TopLevel = false;                           //Set the Form TopLevel 0
            Container.Controls.Clear();                     //Clear the Container controls
            Container.Controls.Add(Cat);                    //Add the Form to the Container
            MngtProductsPanel.Visible = true;               //Should not to see the product management
            MngtDashboardPanel.Visible = false;             //Should not see the Dashboard settings
            MngtCustomerPanel.Visible = false;              //Should not see the Customer management settings
            Cat.BringToFront();                             //Get the Form you want to display to front 
            Cat.LoadCategory();                             //Function Definition
            Cat.Show();                                     //Show the Form 
        }

        //Manage Customers Button
        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            FrmCustomerList cust = new FrmCustomerList();
            cust.Size = Container.Size;
            cust.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(cust);
            MngtProductsPanel.Visible = false;               //Should not to see the product management settings
            MngtDashboardPanel.Visible = false;              //Should not see the Dashboard settings
            MngtCustomerPanel.Visible = true;                //Should see the Customer management settings
            MngtSales.Visible = false;                       //Should see the Sub report module
            materialDivider3.Visible = false;                    //Indicator is off
            materialDivider4.Visible = false;                    //Indicator is off
            materialDivider5.Visible = true;                     //Indicator is on
            materialDivider6.Visible = false;                    //Indicator is off
            cust.BringToFront();
            cust.Show();
        }

        //Stock-In Button
        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            FrmStockIn stk = new FrmStockIn();              //Call the Form; Set Variable
            stk.Size = Container.Size;
            stk.TopLevel = false;                           //Set the Form TopLevel 0
            Container.Controls.Clear();                     //Clear the Container controls
            Container.Controls.Add(stk);                    //Add the Form to the Container
            MngtProductsPanel.Visible = true;               //Should not to see the product management
            MngtDashboardPanel.Visible = false;             //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;              //Should not see the Customer management settings
            stk.BringToFront();                             //Get the Form you want to display to front 
                                                            //stk.LoadProduct();                             
                                                            //Function Definition
            PasslblName = lblUsername.Text;
            stk.Show();                                     //Show the Form 
        }

        //Sales Records Button
        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            FrmReports rep = new FrmReports();
            rep.Size = Container.Size;
            rep.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(rep);
            MngtProductsPanel.Visible = false;               //Should not to see the product management
            MngtDashboardPanel.Visible = false;              //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;               //Should not see the Customer management settings
            MngtSales.Visible = true;                        //Should see the Sub report module
            materialDivider3.Visible = false;                  //Indicator is off
            materialDivider4.Visible = false;                  //Indicator is off
            materialDivider5.Visible = false;                  //Indicator is off
            materialDivider6.Visible = true;                   //Indicator is on
            rep.BringToFront();
            rep.Show();
        }

        //User Settings Button
        private void materialFlatButton12_Click(object sender, EventArgs e)
        {
            FrmUserFiles user = new FrmUserFiles();          //Call the Form; Set Variable
            user.Size = Container.Size;
            user.TopLevel = false;                           //Set the Form TopLevel 0
            Container.Controls.Clear();                      //Clear the Container controls
            Container.Controls.Add(user);                    //Add the Form to the Container
            MngtProductsPanel.Visible = false;               //Should not to see the product management
            MngtDashboardPanel.Visible = true;               //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;               //Should not see the Customer management settings
            user.BringToFront();                             //Get the Form you want to display to front 
            //user.LoadAccounts();                           //Function Definition
            user.Show();                                     //Show the Form 
        }

        //Supplier Button
        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            FrmSupplierList sup = new FrmSupplierList();
            sup.Size = Container.Size;
            sup.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(sup);
            MngtProductsPanel.Visible = true;               //Should not to see the product management
            MngtDashboardPanel.Visible = false;             //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;              //Should not see the Customer management settings
            sup.BringToFront();
            sup.LoadSuppliers();
            sup.Show();

        }

        private void BtnRoutes_Click(object sender, EventArgs e)
        {
            FrmRoutelist route = new FrmRoutelist();
            route.Size = Container.Size;
            route.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(route);
            route.BringToFront();
            route.Show();
        }

        private void MngtCustomerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            FrmProductlist shit = new FrmProductlist();    //Call the Form; Set Variable
            shit.Size = Container.Size;
            shit.TopLevel = false;                         //Set the Form TopLevel 0
            Container.Controls.Clear();                    //Clear the Container controls
            Container.Controls.Add(shit);                  //Add the Form to the Container
            MngtProductsPanel.Visible = true;              //Get to see the product management
            MngtDashboardPanel.Visible = false;            //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;             //Should not see the Customer management settings
            MngtSales.Visible = false;                     //Should see the Sub report module
            materialDivider3.Visible = false;                 //Indicator is off
            materialDivider4.Visible = true;                  //Indicator is on
            materialDivider5.Visible = false;                 //Indicator is off
            materialDivider6.Visible = false;                 //Indicator is off
            shit.BringToFront();                          //Get the Form you want to display to front 
            shit.LoadShitData();                          //Function Definition
            shit.Show();                                  //Show the Form 
        }

        private void materialFlatButton18_Click(object sender, EventArgs e)
        {
            FrmCustomerList cust = new FrmCustomerList();
            cust.Size = Container.Size;
            cust.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(cust);
            MngtProductsPanel.Visible = false;               //Should not to see the product management settings
            MngtDashboardPanel.Visible = false;              //Should not see the Dashboard settings
            MngtCustomerPanel.Visible = true;                //Should see the Customer management settings
            MngtSales.Visible = false;                       //Should see the Sub report module
            materialDivider3.Visible = false;                    //Indicator is off
            materialDivider4.Visible = false;                    //Indicator is off
            materialDivider5.Visible = true;                     //Indicator is on
            materialDivider6.Visible = false;                    //Indicator is off
            cust.BringToFront();
            cust.Show();
        }
        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            FrmInvoiceList list = new FrmInvoiceList();
            list.Size = Container.Size;
            PassCanName = lblUsername.Text;
            list.Size = Container.Size;
            list.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(list);
            MngtProductsPanel.Visible = false;               //Should not to see the product management settings
            MngtDashboardPanel.Visible = false;              //Should not see the Dashboard settings
            MngtCustomerPanel.Visible = true;                //Should see the Customer management settings
            MngtSales.Visible = false;                       //Should see the Sub report module
            materialDivider3.Visible = false;                    //Indicator is off
            materialDivider4.Visible = false;                    //Indicator is off
            materialDivider5.Visible = true;                     //Indicator is on
            materialDivider6.Visible = false;                    //Indicator is off
            list.BringToFront();
            list.Show();
        }

        //Inventory Button
        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            FrmInventory inv = new FrmInventory();
            PassStockUsername = lblUsername.Text;
            inv.Size = Container.Size;
            inv.TopLevel = false;
            Container.Controls.Clear();
            Container.Controls.Add(inv);
            MngtProductsPanel.Visible = true;              //Get to see the product management
            MngtDashboardPanel.Visible = false;            //Should see the Dashboard settings
            MngtCustomerPanel.Visible = false;             //Should not see the Customer management settings
            MngtSales.Visible = false;                     //Should see the Sub report module
            materialDivider3.Visible = false;                 //Indicator is off
            materialDivider4.Visible = true;                  //Indicator is on
            materialDivider5.Visible = false;                 //Indicator is off
            materialDivider6.Visible = false;                 //Indicator is off
            inv.BringToFront();
            inv.LoadShitData();
            inv.Show();
        }

        public void BackToAdminButton()
        {
            FrmMain2 back = new FrmMain2();
            back.BtnBackAdminMode.Visible = true;
        }

        private void BtnSwitchToPOS_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You are now entering the AHK Enterprises Point of Sales Module. Click Yes if you want to continue.", "Point of Sales", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                PassToPOSName = lblUsername.Text;
                PassToPOSAccount = lblAccount.Text;

                FrmLoading3 load = new FrmLoading3();
                load.Show();


                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            return;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out as Administrator?", "AHK Security", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Show the Login Form 
                FrmLogin log = new FrmLogin();
                log.Show();

                //Dispose this Form
                this.Dispose();
            }
        }

        private void FrmMain1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                Container.Size = Container.Size;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Container.Size = Container.Size;
            }
        }
    }
}
