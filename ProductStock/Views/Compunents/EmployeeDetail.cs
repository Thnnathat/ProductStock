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
using ProductStock.Modules;
using System.IO;
using System.Drawing.Imaging;

namespace ProductStock.Views.Compunents
{
    public partial class EmployeeDetail : Form
    {

        public string btnName;

        public DataGridView dgv;
        EmployeeModel AEmp;
        public string empId;
        public string mode;
        EmployeeItems obj2 = (EmployeeItems)Application.OpenForms["EmployeeItems"];

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
            mode = "veiwMode";
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
            obj2.reloadData();
            dgv.Update();
            dgv.Refresh();
            this.Close();
        }

        private void addEmpMode()
        {
            mode = "addEmpMode";
            enableAllTextBox();
            editModePanel.Enabled = true;
            editModePanel.Visible = true;
            removeEmpBtn.Visible = false;
            cancelEditBtn.Visible = false;
            editEmpBtn.Visible = false;
            selectImageBtn.Visible = true;
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
            if (btnName != null && btnName == "addEmpBtn")
            {
                addEmpMode();
            }

            if (mode == "viewMode")
            {
                disableEditMode();
                showEmpDeail();
            }
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
            ImageBinaryConverter itb = new ImageBinaryConverter();
            string id, password, prefix, first_name, last_name, role;
            string query;
            bool Success = false;

            id = empIdTextBox.Texts;
            password = empPasswordTextBox.Texts;
            prefix = prefixComboBox.Text;
            first_name = empFirstNameTextBox.Texts;
            last_name = empLastNameTextBox.Texts;
            role = roleComboBox.Text;
            byte[] image;

            // !ไม่สามารถใช้รูปเดิมได้ ms จะเจอข้อมูลซ้ำ ไม่สามารถแปลงได้
            // แก้ไข ถ้า ms ไม่สามารถอ่านข้อมูลได้ จะให้ใช้รูปเดิมจาก AEmp.Image. (โบกปูนทับ)
            try
            {
                MemoryStream ms = new MemoryStream();
                empPictureBox.Image.Save(ms, empPictureBox.Image.RawFormat);
                image = ms.ToArray();
            }
            catch
            {
                image = AEmp.Image;
            }
            DBProject db = new DBProject();
            if (mode == "editMode")
            {
                query = "UPDATE employees SET id=@id, password=@password, prefix=@prefix, first_name=@first_name, last_name=@last_name, role=@role, image=@image where id='" + AEmp.EmpID + "';";
                Success = db.empDetailRepo(query, id, password, prefix, first_name, last_name, role, image);
            }

            else if (mode == "addEmpMode")
            {
                query = "INSERT INTO employees(id, password, prefix, first_name, last_name, role, image) VALUES(@id, @password, @prefix, @first_name, @last_name, @role, @image)";
                Success = db.empDetailRepo(query, id, password, prefix, first_name, last_name, role, image);
            }

            if (Success)
            {
                MessageBox.Show("success.", "Edit product");
                reloadEmpList();
            }
            else
            {
                MessageBox.Show("failed.", "Edit product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Do you want to remove the employee?", "Remove employee.", MessageBoxButtons.YesNoCancel);
            if (check == DialogResult.Yes) //Creates the yes function
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

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            ImageBinaryConverter itb = new ImageBinaryConverter();
            OpenFileDialog opnfd = itb.getImage();
            if (opnfd != null)
            {
                string imagePathUpload = opnfd.FileName;
                Bitmap imgBitmap = new Bitmap(imagePathUpload);
                empPictureBox.Image = imgBitmap;
            }
        }
    }
}
