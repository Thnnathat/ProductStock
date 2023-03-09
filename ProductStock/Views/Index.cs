using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.Models;

namespace ProductStock.Views
{
    public partial class Index : Form
    {

        public EmployeeModel AEmp;
        public Index()
        {
            InitializeComponent();
        }

        private void Index_load(object sender, EventArgs e)
        {
            showAEmp();
        }

        private void showAEmp()
        {
            empID.Text = AEmp.EmpID;
            empRole.Text = AEmp.Role;
            empName.Text = AEmp.Prefix + ". " + AEmp.FirstName + " " + AEmp.LastName;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void On_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

    }
}
