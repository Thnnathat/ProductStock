using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Views
{
    public partial class DevPage : Form
    {
        public DevPage()
        {
            InitializeComponent();
        }

        private void createEmp_Click(object sender, EventArgs e)
        {
            CreateEmployeePage creEmp = new CreateEmployeePage();
            creEmp.Show();
        }

        private void createProdBtn_Click(object sender, EventArgs e)
        {
            CreateProductPage creProd = new CreateProductPage();
            creProd.Show();
        }

        private void editEmpBtn_Click(object sender, EventArgs e)
        {
            EditEmployeePage editEmp = new EditEmployeePage();
            editEmp.Show();
        }

        private void editProdBtn_Click(object sender, EventArgs e)
        {
            EditProductPage editProd = new EditProductPage();
            editProd.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void indexBtn_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
