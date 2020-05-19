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
    public partial class AdminStockInDatePicker : Form
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataReader dr;

        String PrintStartDate;
        String PrintEndDate;

        public AdminStockInDatePicker()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

            //Set the datetime pickers Value to the system default time and date
            bunifuDatepicker1.Value = DateTime.Now;
            bunifuDatepicker2.Value = DateTime.Now;


            PrintStartDate = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
            PrintEndDate = bunifuDatepicker2.Value.ToString("dd-MMM-yyyy");

            bunifuCustomLabel1.Text = PrintStartDate;
            bunifuCustomLabel2.Text = PrintEndDate;

            LoadStockInBy();
        }

        private void AdminStockInDatePicker_Load(object sender, EventArgs e)
        {

        }

        public void LoadStockInBy()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * from tblUsers WHERE account like 'System Administrator'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    CbxStockBy.Items.Add(dr["name"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminStockInDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnLoadHistory_Click(object sender, EventArgs e)
        {
            if (CbxStockBy.Text == String.Empty)
            {
                MessageBox.Show("Please Select on Stock-In By Options to Continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AdminPreviewStockInHistory stock = new AdminPreviewStockInHistory(this);
            stock.LoadStockInReport();
            stock.ShowDialog();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = bunifuDatepicker1.Value.ToString("dd-MMM-yyyy");
        }

    
    }
}
