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
//Chart Display
using System.Windows.Forms.DataVisualization.Charting;

namespace AHKPOSENKTHESIS
{
    public partial class AdminAdministrator : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        int sidewidth = 85;
        static AdminAdministrator _obj;

        public static string PassStockUsername;

        public static string PassStockInName;

        public static string PassStockAdjName;

        // Cancel Invoice
        public static string PassCanName;

        public AdminAdministrator()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        public static AdminAdministrator Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AdminAdministrator();
                }
                return _obj;
            }
        }

        public Button BackButton
        {
            get { return BtnBack; }
            set { BtnBack = value; }
        }

        public Button BackToInvoiceButton
        {
            get { return BtnBackToInvoice; }
            set { BtnBackToInvoice = value; }
        }

        public Button BackToReportsButton
        {
            get { return BtnBacktoReports; }
            set { BtnBacktoReports = value; }
        }

        public Panel PnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        private void FrmMainAdmin_Load(object sender, EventArgs e)
        {
            BtnBack.Visible = false;
            BtnBackToInvoice.Visible = false;
            BtnBacktoReports.Visible = false;

            _obj = this;

            AdminResources res = new AdminResources();
            res.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(res);
            res.lblDailySales.Text = dbcon.GetDailySales().ToString("#,##0.00");
            res.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
            res.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
            res.lblCriticalProducts.Text = dbcon.CriticalProduct().ToString("#,##0");
            res.lblCustomerCount.Text = dbcon.CustomerCount().ToString("#,##0");
            res.DisplayChartTopSelling();

            // Store a value for this variable -- and pass the value to AdminStockAdjustment.cs { txtAdjustment.text }
            PassStockUsername = lblUsername.Text;
            // Store a value for this variable -- and pass the vaue to AdminStockIn.cs { txtStockby.text }
            PassStockInName = lblUsername.Text;
            // Store a value for this variable -- and pass the vaue to AdminStockIn.cs { txtStockby.text }
            PassStockAdjName = lblUsername.Text;
        }


        private void BtnCleanDashboard_Click(object sender, EventArgs e)
        {
            if (panel1.Width == sidewidth)
            {
                panel1.Width = 220;
            }
            else
            {
                panel1.Width = sidewidth;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            // get the path of the image
            Image compress = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\compress_36px.png");

            // get the path of the image
            Image fullscreen = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\full_screen_36px.png");

            if (this.WindowState != FormWindowState.Maximized)
            {
                BtnReduce.Image = compress;
                this.WindowState = FormWindowState.Maximized;
                pnlContainer.Size = pnlContainer.Size;

            }
            else
            {
                BtnReduce.Image = fullscreen;
                this.WindowState = FormWindowState.Normal;
                pnlContainer.Size = pnlContainer.Size;
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            // get the path of the image
            Image compress = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\compress_36px.png");

            // get the path of the image
            Image fullscreen = Image.FromFile(@"C:\Users\Arjie\source\repos\AHKPOSENKTHESIS MASTER\AHKPOSENKTHESIS WIP\AHKPOSENKTHESIS\bin\Debug\Icons\full_screen_36px.png");

            if (this.WindowState != FormWindowState.Maximized)
            {
                BtnReduce.Image = compress;

                // Reduce the size of the form 
                this.WindowState = FormWindowState.Maximized;
                pnlContainer.Size = pnlContainer.Size;
            }
            else
            {
                BtnReduce.Image = fullscreen;
                this.WindowState = FormWindowState.Normal;
                pnlContainer.Size = pnlContainer.Size;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminResources"))
            {
                AdminResources res = new AdminResources();
                res.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(res);

                res.lblDailySales.Text = dbcon.GetDailySales().ToString("#,##0.00");
                res.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
                res.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
                res.lblCriticalProducts.Text = dbcon.CriticalProduct().ToString("#,##0");
                res.lblCustomerCount.Text = dbcon.CustomerCount().ToString("#,##0");
                res.DisplayChartTopSelling();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminResources"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = false;
            AdminAdministrator.Instance.BackToInvoiceButton.Visible = false;
        }

        private void BtnBackToInvoice_Click(object sender, EventArgs e)
        {
            AdminAdministrator.Instance.PnlContainer.Controls.Clear();
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInvoices"))
            {
                AdminInvoices inv = new AdminInvoices();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowAllInvoices();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInvoices"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            BtnBackToInvoice.Visible = false;
        }

        private void BtnBacktoReports_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminSalesReportHome"))
            {
                AdminSalesReportHome rep = new AdminSalesReportHome();
                rep.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(rep);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminSalesReportHome"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToInvoiceButton.Visible = false;
        }

        private void BtnResources_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminResources"))
            {
                AdminResources res = new AdminResources();
                res.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(res);

                res.lblDailySales.Text = dbcon.GetDailySales().ToString("#,##0.00");
                res.lblProductLine.Text = dbcon.ProductLine().ToString("#,##0");
                res.lblStockOnHand.Text = dbcon.StockOnHand().ToString("#,##0");
                res.lblCriticalProducts.Text = dbcon.CriticalProduct().ToString("#,##0");
                res.lblCustomerCount.Text = dbcon.CustomerCount().ToString("#,##0");
                res.DisplayChartTopSelling();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminResources"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = false;
            AdminAdministrator.Instance.BackToInvoiceButton.Visible = false;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminProducts"))
            {
                AdminProducts pro = new AdminProducts();
                pro.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(pro);

                pro.ShowAllProductsInDatabase();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminProducts"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToInvoiceButton.Visible = false;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnInventoryFlow_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInventory"))
            {
                AdminInventory inv = new AdminInventory();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowInventoryProducts();

                AdminAdministrator admin = new AdminAdministrator();
                PassStockUsername = admin.lblUsername.Text;
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInventory"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminCustomer"))
            {
                AdminCustomer custom = new AdminCustomer();
                custom.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(custom);

                // Store the value of username text into PassCanName variable so it can pass to Cancel Invoice
                PassCanName = lblUsername.Text;
                custom.ShowCustomersInformation();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminCustomer"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToInvoiceButton.Visible = false;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminInvoices"))
            {
                AdminInvoices inv = new AdminInvoices();
                inv.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(inv);

                inv.ShowAllInvoices();
                inv.PopulateCustomerNameCombobox();
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminInvoices"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnSalesReports_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminSalesReportHome"))
            {
                AdminSalesReportHome rep = new AdminSalesReportHome();
                rep.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(rep);

               
            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminSalesReportHome"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminSettings"))
            {
                AdminSettings set = new AdminSettings();
                set.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(set);


            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminSettings"].BringToFront();
            AdminAdministrator.Instance.BackButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Visible = false;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel2_Click(object sender, EventArgs e)
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Show the Login Form 
                Login log = new Login();
                log.Show();

                //Dispose this Form
                this.Dispose();
            }
        }

        private void BtnAvatarOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Show the Login Form 
                Login log = new Login();
                log.Show();

                //Dispose this Form
                this.Dispose();
            }
        }

    }
}
