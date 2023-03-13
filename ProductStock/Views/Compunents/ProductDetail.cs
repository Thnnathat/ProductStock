using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using ProductStock._Repository;
using ProductStock.Models;
using ProductStock.Modules;

namespace ProductStock.Views.Compunents
{
    public partial class ProductDetail : Form
    {

        //ไม่สามรถ reload เพจได้ (วิธีแก้ เปลี่ยนจาก datagrid view เป็นการนำเอา id ไป query ใหม่) -> แก้ไขแล้ว

        // public DataGridView dgv; !
        ProductModel prodModel;
        ProductItems obj = (ProductItems)Application.OpenForms["ProductItems"];
        public string btnName;
        private string mode;
        public string prodId;

        public ProductDetail()
        {
            InitializeComponent();
            disableAllTextBox();
            stockBtn.Visible = true;
        }

        private void disableAllTextBox()
        {
            prodIdTextBox.Enabled = false;
            prodNameTextBox.Enabled = false;
            prodTypeNameTextBox.Enabled = false;
            prodPriceTextBox.Enabled = false;
            prodColorTextBox.Enabled = false;
            prodColorHexTextBox.Enabled = false;
            prodCountTextBox.Enabled = false;
        }

        private void enableAllTextBox()
        {
            prodIdTextBox.Enabled = true;
            prodNameTextBox.Enabled = true;
            prodTypeNameTextBox.Enabled = true;
            prodPriceTextBox.Enabled = true;
            prodColorTextBox.Enabled = true;
            prodColorHexTextBox.Enabled = true;
            prodCountTextBox.Enabled = true;
        }

        private void disableEditMode()
        {
            editModePanel.Enabled = false;
            editModePanel.Visible = false;
            selectImageBtn.Visible = false;
            disableAllTextBox();
        }

        // ตอนนี้ edit ไม่ได้ เนื่องจาก inStock กับ outStock อ้างอิงค์ถึง product อยู่ (วิธีแก้ สินค้าที่มี stock แล้ว ไม่ให้แก้ไข id) -> แก้ไขแล้ว
        private void enableEditMode()
        {
            mode = "editMode";
            editModePanel.Enabled = true;
            editModePanel.Visible = true;
            selectImageBtn.Visible = true;
            enableAllTextBox();
            prodCountTextBox.Enabled = false;
            prodIdTextBox.Enabled = false;
        }

        private void addProdMode()
        {
            mode = "addProdMode";
            enableAllTextBox();
            editModePanel.Enabled = true;
            editModePanel.Visible = true;
            removeProdBtn.Visible = false;
            cancelEditBtn.Visible = false;
            editProdBtn.Visible = false;
            selectImageBtn.Visible = true;
            stockBtn.Visible = false;
            prodCountTextBox.Visible = false;
            prodCountTextBox.Texts = "0"; // ค่าเริ่มต้น = 0
            countLabel.Visible = false;
        }

        private void OnProductDetailLoad(object sender, EventArgs e)
        {
            if (btnName != null && btnName == "addProdBtn")
            {
                addProdMode();
            }
            getProdDetail();
        }

        private void getProdDetail()
        {
            DBProject db = new DBProject();
            prodModel = new ProductModel();
            prodModel = db.getAProductCount(prodId);

            if (prodModel != null)
            {
                mode = "viewMode";
                showProdDetail();
                disableEditMode();
            }
        }

        private void showProdDetail()
        {
            if (prodModel != null)
            {
                ImageBinaryConverter itb = new ImageBinaryConverter();
                prodIdTextBox.Texts = prodModel.Id;
                prodNameTextBox.Texts = prodModel.Name;
                prodTypeNameTextBox.Texts = prodModel.TypeName;
                prodPriceTextBox.Texts = (prodModel.Price).ToString();
                prodColorTextBox.Texts = prodModel.Color;
                string colorHex = prodModel.ColorHex;
                prodColorHexTextBox.Texts = colorHex;
                colorHexPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(colorHex);
                prodCountTextBox.Texts = (prodModel.ProductCount).ToString();
                prodPictureBox.Image = itb.ByteToImage(prodModel.Image);
            }
        }

        public void reloadData()
        {
            getProdDetail(); 
        }

        private void editProdBtn_Click(object sender, EventArgs e)
        {
            enableEditMode();
        }

        private void cancelEditBtn_Click(object sender, EventArgs e)
        {
            disableEditMode();
            showProdDetail();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reloadProdList()
        {
            obj.reloadData();
            this.Close();
        }

        //Remove ไม่ได้ ต้อง remove Stock ก่อน -> แก้แล้ว
        private void removeProdBtn_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Do you want to remove the product?", "Remove product.", MessageBoxButtons.YesNoCancel);
            if (check == DialogResult.Yes)
            {
                bool deleteSuccess = false;
                DBProject db = new DBProject();
                if (prodModel.ProductCount > 0)
                {
                    db.removeData("in_stocks", prodModel.Id);
                    db.removeData("out_stocks", prodModel.Id);
                    deleteSuccess = db.removeData("products", prodModel.Id);
                }
                else
                {
                    deleteSuccess = db.removeData("products", prodModel.Id);
                }
                {

                }
                if (deleteSuccess)
                {
                    MessageBox.Show("Delete success.", "Delete product");
                    reloadProdList();
                }
                else
                {
                    MessageBox.Show("Delete failed.", "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            ImageBinaryConverter itb = new ImageBinaryConverter();
            string id, name, type_name, price, color, color_hex, product_count;
            string query;
            bool Success = false;

            id = prodIdTextBox.Texts;
            name = prodNameTextBox.Texts;
            type_name = prodTypeNameTextBox.Texts;
            price = prodPriceTextBox.Texts;
            color = prodColorTextBox.Texts;
            color_hex = prodColorHexTextBox.Texts;
            byte[] image;

            //แก้แบบ EmployeeDetail เลย (เห้อออ) -> แก้ไขแล้ว
            try
            {
                MemoryStream ms = new MemoryStream();
                prodPictureBox.Image.Save(ms, prodPictureBox.Image.RawFormat);
                image = ms.ToArray();
            }
            catch
            {
                image = prodModel.Image;
            }

            product_count = prodCountTextBox.Texts;
            DBProject db = new DBProject();
            if (mode == "editMode")
            {
                query = "UPDATE products SET id=@id, name=@name, type_name=@type_name, price=@price, color=@color, color_hex=@color_hex, image=@image where id='" + prodModel.Id + "';";
                Success = db.prodDetailRepo(query, id, name, type_name, price, color, color_hex, image);
            }

            else if (mode == "addProdMode")
            {
                query = "INSERT INTO products(id, name, type_name, price, color, color_hex, image, product_count) VALUES(@id, @name, @type_name, @price, @color, @color_hex, @image, @product_count)";
                Success = db.prodDetailRepo(query, id, name, type_name, price, color, color_hex, image, product_count);
            }

            if (Success)
            {
                MessageBox.Show("success.", "Edit product");
                reloadProdList();
            }
            else
            {
                MessageBox.Show("failed.", "Edit product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                prodPictureBox.Image = imgBitmap;
            }
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            disableEditMode();
            showProdDetail();
            ProdStock prodStock = new ProdStock();
            prodStock.prodModel = prodModel;
            prodStock.Show();
        }
    }
}
