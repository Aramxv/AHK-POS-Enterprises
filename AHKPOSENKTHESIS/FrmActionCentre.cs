﻿using System;
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
    public partial class FrmActionCentre : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();

        public FrmActionCentre()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        // Show the change password dialog
        private void BtnChangePass_Click_1(object sender, EventArgs e)
        {
            FrmChangePassword change = new FrmChangePassword();
            change.ShowDialog();
        }
    }
}
