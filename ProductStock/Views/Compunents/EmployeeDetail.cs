using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock._Repository;
using Org.BouncyCastle.Asn1.Cmp;
using ProductStock.Models;
using ProductStock.Models;
using ProductStock.Modules;

namespace ProductStock.Views.Compunents
{
    public partial class EmployeeDetail : Form
    {

        EmployeeItems obj = (EmployeeItems)Application.OpenForms["EmployeeItems"];
        public DataGridView dgv;
        EmployeeModel AEmp;
        public string empId;
        private string mode;

        public EmployeeDetail()
        {
            InitializeComponent();
            disableAllTextBox();
            prefixComboBox.Items.Add("mr");
            prefixComboBox.Items.Add("ms");
            roleComboBox.Items.Add("admin");
            roleComboBox.Items.Add("staff");
        }

        private void disableAllTextBox()
        {
            empIdTextBox.Enabled = false;
            prefixComboBox.Enabled = false;
            empPasswordTextBox.Enabled = false;
            empFirstNameTextBox.Enabled = false;
            empLastNameTextBox.Enabled = false;
            roleComboBox.Enabled = false;
        }

        private void enableAllTextBox()
        {
            empIdTextBox.Enabled = true;
            prefixComboBox.Enabled = true;
            empPasswordTextBox.Enabled = true;
            empFirstNameTextBox.Enabled = true;
            empLastNameTextBox.Enabled = true;
            roleComboBox.Enabled = true;
        }

        private void disableEditMode()
        {
            editModePanel.Enabled = false;
            editModePanel.Visible = false;
            selectImageBtn.Visible = false;
            disableAllTextBox();
        }

        private void enableEditMode()
        {
            mode = "editMode";
            editModePanel.Enabled = true;
            editModePanel.Visible = true;
            selectImageBtn.Visible = true;
            enableAllTextBox();
        }


        private void reloadEmpList()
        {
            obj.reloadData();
            dgv.Update();
            dgv.Refresh();
            this.Close();
        }

        private void addProdMode()
        {
            mode = "addProdMode";
            enableAllTextBox();
        }

        private void showEmpDeail()
        {
            DBProject db = new DBProject();
            ImageBinaryConverter ibc = new ImageBinaryConverter();
            AEmp = db.getAEmpolyee(empId);
            empIdTextBox.Texts = AEmp.EmpID;
            empPasswordTextBox.Texts = AEmp.Password;
            prefixComboBox.SelectedIndex = prefixComboBox.FindStringExact(AEmp.Prefix);
            empFirstNameTextBox.Texts = AEmp.FirstName;
            empLastNameTextBox.Texts = AEmp.LastName;
            roleComboBox.SelectedIndex = roleComboBox.FindStringExact(AEmp.Role);
            empPictureBox.Image = ibc.ByteToImage(AEmp.Image);
            dateTimeLabel.Text = AEmp.DateTime;
        }

        private void OnEmpLoad(object sender, EventArgs e)
        {
            disableEditMode();
            showEmpDeail();
        }

        private void editEmpBtn_Click(object sender, EventArgs e)
        {
            enableEditMode();
        }

        private void cancelEditBtn_Click(object sender, EventArgs e)
        {
            disableEditMode();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            reloadEmpList();
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            DBProject db = new DBProject();
            bool deleteSucess = db.removeData("employees", AEmp.EmpID);
            if (deleteSucess)
            {
                MessageBox.Show("Delete success.", "Delete product");
                reloadEmpList();
            }
            else
            {
                MessageBox.Show("Delete failed.", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
