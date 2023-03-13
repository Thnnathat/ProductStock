using ProductStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock._Repository;

namespace ProductStock.Views.Compunents
{
    public partial class AddStock : Form
    {

        public ProductModel prodModel;
        InStock obj3 = (InStock)Application.OpenForms["InStock"];
        ProductItems obj4 = (ProductItems)Application.OpenForms["ProductItems"];
        ProductDetail obj5 = (ProductDetail)Application.OpenForms["ProductDetail"];

        public AddStock()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProdBtn_Click(object sender, EventArgs e)// แก้ชื่อ function.
        {
            DBProject db = new DBProject();
            string sql = "INSERT INTO in_stocks(id) VALUES(@id)";
            int count = 0;
            bool countToInt = int.TryParse(stockCountTextBox.Texts, out count);
            if (countToInt)
            {
                bool success = db.addProdStock(sql, prodModel.Id, count);
                if (success)
                {
                    MessageBox.Show("Add stock success.", "Add Stock");
                    countStock();
                    reloadStockList();
                }
                else
                {
                    MessageBox.Show("Add stock failed.", "Add Stock");
                }
            }
            else
            {
                MessageBox.Show("Please enter number.", "Edit product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeStock_Click(object sender, EventArgs e)
        {
            DBProject db = new DBProject();
            string sql;
            int count = 0;
            bool countToInt = int.TryParse(stockCountTextBox.Texts, out count);
            bool success = false;
            if (countToInt)
            {
                string[] stock_id;
                sql = "SELECT stock_id FROM in_stocks WHERE id='" + prodModel.Id + "' LIMIT " + count + "";
                stock_id = db.getInStock(sql);
                for (int i = 0; i < stock_id.Length; i++)
                {
                    sql = "INSERT INTO out_stocks(id, stock_id) VALUES(@id, @stock_id)";
                    success = db.transferProdStock(sql, prodModel.Id, stock_id[i]);
                    sql = "DELETE FROM in_stocks WHERE id='" + prodModel.Id + "' AND stock_id='" + stock_id[i] + "'";
                    success = db.removeStock(sql);
                }
                if (success)
                {
                    MessageBox.Show("Remove stock success.", "Add Stock");
                    countStock();
                    reloadStockList();
                }
                else
                {
                    MessageBox.Show("Remove stock failed.", "Add Stock");
                }
            }
            else
            {
                MessageBox.Show("Please enter number.", "Edit product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool countStock()
        {
            DBProject db = new DBProject();
            try
            {
                string sql;
                sql = "SELECT COUNT(*) FROM in_stocks WHERE id='" + prodModel.Id + "'";
                int stockCount = db.getProductCount(sql);
                sql = "UPDATE products SET product_count=@product_count WHERE id='"+prodModel.Id+"'";
                bool success = db.updateProdCount(sql, stockCount);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // มีปัญหา หน้า Product reload ไม่ได้ หน้าต่างอัพเดทไม่ได้ แก้ไขการโหลดข้อมูล
        private void reloadStockList()
        {
            obj3.reloadData();
            obj4.reloadData();
            obj5.reloadData();
            this.Close();
        }


    }
}
