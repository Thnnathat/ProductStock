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
    public partial class EmployeeItems : Form
    {

        private Form activeForm;
        public EmployeeItems()
        {
            InitializeComponent();
        }

        private void OnLoadEmployeeItems(object sender, EventArgs e)
        {
            showProdTable();
        }

        private void showProdTable()
        {
            try
            {
                DBProject db = new DBProject();
                string query = "SELECT id, password, prefix, first_name, last_name, role FROM employees";
                DataTable dt = db.displayData(query);
                if (dt != null)
                {
                    empDataGridView.DataSource = dt;
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
            string query = "SELECT id, password, prefix, first_name, last_name, role FROM employees WHERE id LIKE '%" + search + "%' OR name LIKE '%" + search + "%' OR type_name LIKE '%" + search + "%' OR price LIKE '%" + search + "%' OR color LIKE '%" + search + "%'";
            DataTable dt = db.displayData(query);
            if (dt != null)
            {
                empDataGridView.DataSource = dt;
            }
        }

        private void OnEmpCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (empDataGridView.SelectedRows.Count > 0 && empDataGridView.SelectedRows.Count != empDataGridView.RowCount && empDataGridView != null) // make sure user select at least 1 row 
                {
                    DataGridView dgv = empDataGridView;
                    string empid = dgv.SelectedRows[0].Cells[0].Value + string.Empty;
                    EmployeeDetail prodDetail = new EmployeeDetail();
                    if (activeForm != null)
                        activeForm.Close();
                    activeForm = prodDetail;
                    prodDetail.dgv = dgv;
                    prodDetail.empId = empid;
                    prodDetail.Show();
                }

            }
            catch { }
        }

        public void reloadData()
        {
            searchProdText.Texts = "";
            showProdTable();
        }
    }
}
