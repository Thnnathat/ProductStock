using ProductStock.Models;
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
    public partial class ProdStock : Form
    {
        private Button currentButton;
        private Form activeForm;
        public ProductModel prodModel;

        public ProdStock()
        {
            InitializeComponent();
        }

        private void OnProdStockLoad(object sender, EventArgs e)
        {
            inStockBtn.PerformClick();
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
            this.stockPanel.Controls.Add(childForm);
            this.stockPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.prodModel = prodModel;
            addStock.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inStockBtn_Click(object sender, EventArgs e)
        {
            string prodId = prodModel.Id;
            InStock inStock = new InStock();
            inStock.prodId = prodId;
            OpenChildForm(inStock, sender);
        }

        private void outStockBtn_Click(object sender, EventArgs e)
        {
            string prodId = prodModel.Id;
            OutStock outStock = new OutStock();
            outStock.prodId = prodId;
            OpenChildForm(outStock, sender);
        }
    }
}
