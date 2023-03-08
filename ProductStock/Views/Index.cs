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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }
    }
}
