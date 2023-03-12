using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProductStock.Views;
using ProductStock.Models;
using ProductStock._Repository;

namespace ProductStock
{
    public partial class Login : Form
    {
        //[DllImport("Gdi32.dll",EntryPoint="CreateRoundRgn")]
        public Login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginHandler();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void loginHandler()
        {
            EmployeeModel AEmp;
            DBProject db = new DBProject();
            string EmpID;
            string Password;
            EmpID = empIDTextBox.Texts;
            Password = empPasswordTextBox.Texts;
            AEmp = db.getAEmpolyee(EmpID);
            if (AEmp.EmpID != null && AEmp.Password != null)
            {
                if (EmpID == AEmp.EmpID && Password == AEmp.Password)
                {
                    this.Hide();
                    Index index = new Index();
                    index.AEmp = AEmp;
                    index.Show();
                }
                else
                {
                    empIDTextBox.Texts = "";
                    empPasswordTextBox.Texts = "";
                    MessageBox.Show("Password ไม่ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                empIDTextBox.Texts = "";
                empPasswordTextBox.Texts = "";
                MessageBox.Show("ไม่มีข้อมูลพนักงาน", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
