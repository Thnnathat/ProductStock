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
            empDataGridView.AllowUserToAddRows = false;
        }

        private void OnLoadEmployeeItems(object sender, EventArgs e)
        {
            showEmpTable();
        }

        private void showEmpTable()
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
            string query = "SELECT id, password, prefix, first_name, last_name, role FROM employees WHERE id LIKE '%" + search + "%' OR password LIKE '%" + search + "%' OR prefix LIKE '%" + search + "%' OR first_name LIKE '%" + search + "%' OR last_name LIKE '%" + search + "%' OR role LIKE '%" + search + "%'";
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
                    EmployeeDetail empDetail = new EmployeeDetail();
                    if (activeForm != null)
                        activeForm.Close();
                    activeForm = empDetail;
                    empDetail.dgv = dgv;
                    empDetail.empId = empid;
                    empDetail.mode = "viewMode";
                    empDetail.Show();
                }

            }
            catch { }
        }

        public void reloadData()
        {
            searchProdText.Texts = "";
            showEmpTable();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetail empDetail = new EmployeeDetail();
            if (activeForm != null)
                activeForm.Close();
            activeForm = empDetail;
            empDetail.btnName = addEmpBtn.Name;
            empDetail.dgv = empDataGridView; 
            empDetail.Show();
        }
    }
}
