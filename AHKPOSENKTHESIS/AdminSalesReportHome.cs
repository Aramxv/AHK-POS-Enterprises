﻿using System;
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
    public partial class AdminSalesReportHome : UserControl
    {

        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        public AdminSalesReportHome()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void AdminSalesReportHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnTrackSales_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminReportsTrackSales"))
            {
                AdminReportsTrackSales track = new AdminReportsTrackSales();
                track.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(track);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminReportsTrackSales"].BringToFront();
            AdminAdministrator.Instance.BackToReportsButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Location = new System.Drawing.Point(8, 7);
        }

        private void BtnTopSelling_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminReportsTrackSales"))
            {
                AdminReportsTopSelling top = new AdminReportsTopSelling();
                top.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(top);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminReportsTopSelling"].BringToFront();
            AdminAdministrator.Instance.BackToReportsButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Location = new System.Drawing.Point(8, 7);
        }

        private void BtnSold_Click(object sender, EventArgs e)
        {
            if (!AdminAdministrator.Instance.PnlContainer.Controls.ContainsKey("AdminReportSold"))
            {
                AdminReportSold sold = new AdminReportSold();
                sold.Dock = DockStyle.Fill;
                AdminAdministrator.Instance.PnlContainer.Controls.Add(sold);

            }
            AdminAdministrator.Instance.PnlContainer.Controls["AdminReportSold"].BringToFront();
            AdminAdministrator.Instance.BackToReportsButton.Visible = true;
            AdminAdministrator.Instance.BackToReportsButton.Location = new System.Drawing.Point(8, 7);
        }
    }
}
