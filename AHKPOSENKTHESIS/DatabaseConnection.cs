using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AHKPOSENKTHESIS
{
    public class DatabaseConnection
    {
        //declare sqlconnetion
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private double dailysales;
        private int productline;
        private int stockonhand;
        private int critical;
        private int customer;

        private string con;

        public string MyConnection()
        {
          con = @"Data Source=DESKTOP-F3K4H52\SQLEXPRESS;Initial Catalog=AHKENTPOSDATABASE;Integrated Security=True";
          return con;
        }


        public double GetVat()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblVat", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            cn.Close();
            return vat;
        }

        public double GetVatable()
        {
            double vatable = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblVatable", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vatable = double.Parse(dr["vatable"].ToString());
            }
            dr.Close();
            cn.Close();
            return vatable;
        }

        public String GetPassword(string user)
        {
            string password = "";
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUsers WHERE username = @username", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }

            dr.Close();
            cn.Close();
            return password;
        }

        public double GetDailySales()
        {
            string xdate = DateTime.Now.ToString("yyyyMMdd");
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT isnull(sum(total),0) as total from tblInvoiceOrder where stockdate between '" + xdate + "' and '" + xdate + "' and status like 'Sold'", cn);
            dailysales = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return dailysales;
        }

        public double ProductLine()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT count(*) from tblProduct", cn);
            productline = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return productline;
        }

        public double StockOnHand()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT isnull(sum(prodqty),0) as prodqty from tblProduct", cn);
            stockonhand = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return stockonhand;
        }

        public double CriticalProduct()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT count(*) from ViewCritical", cn);
            critical = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return critical;
        }

        public double CustomerCount()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("SELECT count(*) from tblCustomer", cn);
            customer = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return customer;
        }
         
    }
}
