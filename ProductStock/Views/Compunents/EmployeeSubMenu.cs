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
    public partial class EmployeeSubMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public EmployeeSubMenu()
        {
            InitializeComponent();
        }

        private void OnEmployeeSubMenuLoad(object sender, EventArgs e)
        {
            empListBtn.PerformClick();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(5, 160, 0);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in indexMenuPannel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.empMenuContainerPanel.Controls.Add(childForm);
            this.empMenuContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void empListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeItems(), sender);
        }

        private void empDetailBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeDetail(),sender);
        }

    }
}
