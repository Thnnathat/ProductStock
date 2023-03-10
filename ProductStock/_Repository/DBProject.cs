using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using ProductStock.Models;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProductStock._Repository
{

    internal class DBProject
    {

        public static MySqlConnection GetConnection()
        {
            string password = "thnnathat";
            string sql = "datasource=localhost;port=3306;username=root;password=" + password + ";database=product_stock";
            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection: " + ex);
            }
            return conn;
        }

        public EmployeeModel getAEmpolyee(string EmpID, string password)
        {
            MySqlConnection conn = GetConnection();
            EmployeeModel AEmp = new EmployeeModel();
            try
            {
                string sql = "select * from employees where id='" + EmpID + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AEmp.EmpID = reader.GetString(0);
                    AEmp.Password = reader.GetString(1);
                    AEmp.Prefix = reader.GetString(2);
                    AEmp.FirstName = reader.GetString(3);
                    AEmp.LastName = reader.GetString(4);
                    AEmp.Role = reader.GetString(5);
                    AEmp.Image = reader.GetFieldValue<byte[]>(6);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            conn.Close();
            return AEmp;
        }

        public DataTable prodDisplay(string query)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable prodDt = new DataTable();
            adp.Fill(prodDt);
            conn.Close();
            return prodDt;
        }
    }
}
