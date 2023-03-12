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
    public partial class InStock : Form
    {

        public string prodId;

        public InStock()
        {
            InitializeComponent();
            inStockDataGridView.AllowUserToAddRows = false;
        }

        private void OnInStockLoad(object sender, EventArgs e)
        {
            showInstockTable();
        }

        public void reloadData()
        {
            searchProdText.Texts = "";
            showInstockTable();
        }

        private void showInstockTable()
        {
            try
            {
                DBProject db = new DBProject();
                string query = "SELECT p.id, stock_id, name, date_time FROM products AS p INNER JOIN in_stocks AS i ON p.id = i.id WHERE p.id='" + prodId + "'";
                DataTable dt = db.displayData(query);
                if (dt != null)
                {
                    inStockDataGridView.DataSource = dt;
                }
            }
            catch
            {
            }
        }

        private void OnInStaocSearchChange(object sender, EventArgs e)
        {
            searchInStock();
        }

        private void searchInStock()
        {
            DBProject db = new DBProject();
            string search = (searchProdText.Texts).Trim();
            string query = "SELECT * FROM in_stocks WHERE id='" + prodId + "' AND (stock_id LIKE '%" + search + "%')";
            DataTable dt = db.displayData(query);
            if (dt != null)
            {
                inStockDataGridView.DataSource = dt;
            }
        }
    }
}
