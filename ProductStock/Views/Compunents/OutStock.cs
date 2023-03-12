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
    public partial class OutStock : Form
    {

        public string prodId;
        public OutStock()
        {
            InitializeComponent();
            outStockDataGridView.AllowUserToAddRows = false;
        }

        private void OnOutStockLoad(object sender, EventArgs e)
        {
            showOutStock();
        }

        public void reloadData()
        {
            outSearchTextBox.Texts = "";
            showOutStock();
        }

        private void showOutStock()
        {
            try
            {
                DBProject db = new DBProject();
                string query = "SELECT p.id, stock_id, name, date_time FROM products AS p INNER JOIN out_stocks AS i ON p.id = i.id WHERE p.id='" + prodId + "'";
                DataTable dt = db.displayData(query);
                if (dt != null)
                {
                    outStockDataGridView.DataSource = dt;
                }
            }
            catch
            {
            }
        }

        private void searchOutStock()
        {
            DBProject db = new DBProject();
            string search = (outSearchTextBox.Texts).Trim();
            string query = "SELECT * FROM out_stocks WHERE id='" + prodId + "' AND (stock_id LIKE '%" + search + "%')";
            DataTable dt = db.displayData(query);
            if (dt != null)
            {
                outStockDataGridView.DataSource = dt;
            }
        }

        private void OutSearchChange(object sender, EventArgs e)
        {
            searchOutStock();
        }
    }
}
