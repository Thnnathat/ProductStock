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

        private Form activeForm;
        public ProductItems()
        {
            InitializeComponent();
            prodDataGridView.AllowUserToAddRows = false;
        }

        private void OnLoadProductItems(object sender, EventArgs e)
        {
            showProdTable();
        }

        private void showProdTable()
        {
            try
            {
                string query;
                DBProject db = new DBProject();
                query = "SELECT * FROM products";
                DataTable dt = db.displayData(query);
                if (dt != null)
                {
                    prodDataGridView.DataSource = dt;
                }
            }
            catch
            {
            }
        }

        private void searchProdTable()
        {
            DBProject db = new DBProject();
            string search = (searchProdText.Texts).Trim();
            string query = "SELECT * FROM products WHERE id LIKE '%" + search + "%' OR name LIKE '%" + search + "%' OR type_name LIKE '%" + search + "%' OR price LIKE '%" + search + "%' OR color LIKE '%" + search + "%'";
            DataTable dt = db.displayData(query);
            if (dt != null)
            {
                prodDataGridView.DataSource = dt;
            }
        }

        private void OnProductCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prodDataGridView.SelectedRows.Count > 0 && prodDataGridView.SelectedRows.Count != prodDataGridView.RowCount) // make sure user select at least 1 row 
            {
                DataGridView dgv = prodDataGridView;
                ProductDetail prodDetail = new ProductDetail();
                if (activeForm != null)
                    activeForm.Close();
                activeForm = prodDetail;
                prodDetail.dgv = dgv;
                prodDetail.Show();
            }
        }

        public void reloadData()
        {
            searchProdText.Texts = "";
            showProdTable();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            ProductDetail prodDetail = new ProductDetail();
            if (activeForm != null)
                activeForm.Close();
            activeForm = prodDetail;
            prodDetail.btnName = addProdBtn.Name;
            prodDetail.Show();
        }

        private void searchProdChange(object sender, EventArgs e)
        {
            searchProdTable();
        }
    }
}
