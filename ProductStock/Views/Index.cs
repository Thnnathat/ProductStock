using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock._Repository;
using ProductStock.Models;
using ProductStock.Views.Compunents;
using ProductStock.Modules;
namespace ProductStock.Views
{
    public partial class Index : Form
    {
        private Button currentButton;
        private Form activeForm;

        public EmployeeModel AEmp;
        public Index()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(89, 0, 97);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in indexMenuPannel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(37, 24, 56);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.indexContentPannel.Controls.Add(childForm);
            this.indexContentPannel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Index_load(object sender, EventArgs e)
        {
            if (AEmp != null)
            {
                rightAEmp();
                showAEmp();
            }
            productMenuBtn.PerformClick();
        }

        private void rightAEmp()
        {
            if (AEmp.Role != "admin")
            {
                employeeMenuBtn.Visible = false;
                employeeMenuBtn.Enabled = false;
            }
        }

        private void showAEmp()
        {
            empID.Text = AEmp.EmpID;
            empRole.Text = AEmp.Role;
            empName.Text = AEmp.Prefix + ". " + AEmp.FirstName + " " + AEmp.LastName;

            ImageBinaryConverter img = new ImageBinaryConverter();
            personCircularPictureBox.Image = img.ByteToImage(AEmp.Image);
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

        private void productMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductSubMenu(), sender);
        }

        private void employeeMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeSubMenu(), sender);
        }
    }
}
