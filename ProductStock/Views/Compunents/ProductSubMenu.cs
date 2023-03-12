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
    public partial class ProductSubMenu : Form
    {

        private Button currentButton;
        private Form activeForm;

        public ProductSubMenu()
        {
            InitializeComponent();
        }

        private void OnProductSubMenuLoad(object sender, EventArgs e)
        {
            prodListBtn.PerformClick();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(27, 0, 142);
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
            this.prodMenuContainerPanel.Controls.Add(childForm);
            this.prodMenuContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void prodListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductItems(), sender);
        }

        private void prodDetailBtn_Click(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail();
            OpenChildForm(productDetail, sender);
        }

        private void prodStockBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProdStock(), sender);
        }
    }
}
