﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using ProductStock.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public EmployeeModel getAEmpolyee(string EmpID)
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
                    AEmp.DateTime = reader.GetString(7);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            conn.Close();
            return AEmp;
        }

        public DataTable displayData(string query)
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

        public bool removeData(string table, string id)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string sql = "DELETE FROM " + table + " where id='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public bool updateData(string query)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public bool addProductPara(string sql, string id, string name, string type_name, string price, string color, string color_hex, byte[] image, string product_count)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("@id", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@type_name", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@price", MySqlDbType.Double);
                cmd.Parameters.Add("@color", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@color_hex", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);
                cmd.Parameters.Add("@product_count", MySqlDbType.Int64);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@name"].Value = name;
                cmd.Parameters["@type_name"].Value = type_name;
                cmd.Parameters["@price"].Value = price;
                cmd.Parameters["@color"].Value = color;
                cmd.Parameters["@color_hex"].Value = color_hex;
                cmd.Parameters["@image"].Value = image;
                cmd.Parameters["@product_count"].Value = product_count;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

    }
}

