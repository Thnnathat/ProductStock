using ProductStock._Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Views.Compunents
{
    public partial class ProductItems : Form
    {
        public ProductItems()
        {
            InitializeComponent();
        }

        private void OnLoadProductItems(object sender, EventArgs e)
        {
            showProdTable();
        }

        private void showProdTable()
        {
            try
            {
                DBProject db = new DBProject();
                string query = "SELECT id, name, type_name, price, color, color_hex, product_count FROM products";
                DataTable dt = db.prodDisplay(query);
                if (dt != null)
                {
                    prodDataGridView.DataSource = dt;
                }
            }
            catch
            {
            }
        }

        private void searchProdKeyPress(object sender, KeyPressEventArgs e)
        {
            searchProdTable();
        }

        private void searchProdTable()
        {
            DBProject db = new DBProject();
            string search = (searchProdText.Texts).Trim();
            string query = "SELECT id, name, type_name, price, color, color_hex, product_count FROM products WHERE id LIKE '%" + search + "%' OR name LIKE '%" + search + "%' OR type_name LIKE '%" + search + "%' OR price LIKE '%" + search + "%' OR color LIKE '%" + search + "%'";
            DataTable dt = db.prodDisplay(query);
            if (dt != null)
            {
                prodDataGridView.DataSource = dt;
            }
        }
    }
}
