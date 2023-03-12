namespace ProductStock.Views.Compunents
{
    partial class ProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.selectImageBtn = new CustomControls.RJControls.RJButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.prodPictureBox = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backBtn = new CustomControls.RJControls.RJButton();
            this.editProdBtn = new CustomControls.RJControls.RJButton();
            this.removeProdBtn = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editModePanel = new System.Windows.Forms.Panel();
            this.saveEditBtn = new CustomControls.RJControls.RJButton();
            this.cancelEditBtn = new CustomControls.RJControls.RJButton();
            this.colorHexPanel = new System.Windows.Forms.Panel();
            this.prodCountTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodColorHexTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodColorTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodPriceTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodTypeNameTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodNameTextBox = new CustomControls.RJControls.RJTextBox();
            this.prodIdTextBox = new CustomControls.RJControls.RJTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodPictureBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.editModePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 653);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 594);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.selectImageBtn);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(440, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 594);
            this.panel5.TabIndex = 1;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.BackColor = System.Drawing.Color.Purple;
            this.selectImageBtn.BackgroundColor = System.Drawing.Color.Purple;
            this.selectImageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.selectImageBtn.BorderRadius = 0;
            this.selectImageBtn.BorderSize = 0;
            this.selectImageBtn.FlatAppearance.BorderSize = 0;
            this.selectImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageBtn.ForeColor = System.Drawing.Color.White;
            this.selectImageBtn.Location = new System.Drawing.Point(248, 442);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(128, 34);
            this.selectImageBtn.TabIndex = 3;
            this.selectImageBtn.Text = "Select Image";
            this.selectImageBtn.TextColor = System.Drawing.Color.White;
            this.selectImageBtn.UseVisualStyleBackColor = false;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.prodPictureBox);
            this.panel7.Location = new System.Drawing.Point(76, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(478, 386);
            this.panel7.TabIndex = 1;
            // 
            // prodPictureBox
            // 
            this.prodPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodPictureBox.Image = global::ProductStock.Properties.Resources.image_gdc9f050a2_640;
            this.prodPictureBox.Location = new System.Drawing.Point(0, 0);
            this.prodPictureBox.Name = "prodPictureBox";
            this.prodPictureBox.Size = new System.Drawing.Size(478, 386);
            this.prodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prodPictureBox.TabIndex = 0;
            this.prodPictureBox.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.backBtn);
            this.panel6.Controls.Add(this.editProdBtn);
            this.panel6.Controls.Add(this.removeProdBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 507);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(630, 87);
            this.panel6.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gray;
            this.backBtn.BackgroundColor = System.Drawing.Color.Gray;
            this.backBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backBtn.BorderRadius = 0;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(427, 15);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(150, 40);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.TextColor = System.Drawing.Color.White;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // editProdBtn
            // 
            this.editProdBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.editProdBtn.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.editProdBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editProdBtn.BorderRadius = 0;
            this.editProdBtn.BorderSize = 0;
            this.editProdBtn.FlatAppearance.BorderSize = 0;
            this.editProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProdBtn.ForeColor = System.Drawing.Color.White;
            this.editProdBtn.Location = new System.Drawing.Point(23, 15);
            this.editProdBtn.Name = "editProdBtn";
            this.editProdBtn.Size = new System.Drawing.Size(150, 40);
            this.editProdBtn.TabIndex = 1;
            this.editProdBtn.Text = "Edit";
            this.editProdBtn.TextColor = System.Drawing.Color.White;
            this.editProdBtn.UseVisualStyleBackColor = false;
            this.editProdBtn.Click += new System.EventHandler(this.editProdBtn_Click);
            // 
            // removeProdBtn
            // 
            this.removeProdBtn.BackColor = System.Drawing.Color.DarkRed;
            this.removeProdBtn.BackgroundColor = System.Drawing.Color.DarkRed;
            this.removeProdBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeProdBtn.BorderRadius = 0;
            this.removeProdBtn.BorderSize = 0;
            this.removeProdBtn.FlatAppearance.BorderSize = 0;
            this.removeProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProdBtn.ForeColor = System.Drawing.Color.White;
            this.removeProdBtn.Location = new System.Drawing.Point(198, 15);
            this.removeProdBtn.Name = "removeProdBtn";
            this.removeProdBtn.Size = new System.Drawing.Size(150, 40);
            this.removeProdBtn.TabIndex = 0;
            this.removeProdBtn.Text = "Remove";
            this.removeProdBtn.TextColor = System.Drawing.Color.White;
            this.removeProdBtn.UseVisualStyleBackColor = false;
            this.removeProdBtn.Click += new System.EventHandler(this.removeProdBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editModePanel);
            this.panel3.Controls.Add(this.colorHexPanel);
            this.panel3.Controls.Add(this.prodCountTextBox);
            this.panel3.Controls.Add(this.prodColorHexTextBox);
            this.panel3.Controls.Add(this.prodColorTextBox);
            this.panel3.Controls.Add(this.prodPriceTextBox);
            this.panel3.Controls.Add(this.prodTypeNameTextBox);
            this.panel3.Controls.Add(this.prodNameTextBox);
            this.panel3.Controls.Add(this.prodIdTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 594);
            this.panel3.TabIndex = 0;
            // 
            // editModePanel
            // 
            this.editModePanel.Controls.Add(this.saveEditBtn);
            this.editModePanel.Controls.Add(this.cancelEditBtn);
            this.editModePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editModePanel.Location = new System.Drawing.Point(0, 507);
            this.editModePanel.Name = "editModePanel";
            this.editModePanel.Size = new System.Drawing.Size(440, 87);
            this.editModePanel.TabIndex = 2;
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.BackColor = System.Drawing.Color.Green;
            this.saveEditBtn.BackgroundColor = System.Drawing.Color.Green;
            this.saveEditBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveEditBtn.BorderRadius = 0;
            this.saveEditBtn.BorderSize = 0;
            this.saveEditBtn.FlatAppearance.BorderSize = 0;
            this.saveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditBtn.ForeColor = System.Drawing.Color.White;
            this.saveEditBtn.Location = new System.Drawing.Point(75, 15);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(150, 40);
            this.saveEditBtn.TabIndex = 3;
            this.saveEditBtn.Text = "Save";
            this.saveEditBtn.TextColor = System.Drawing.Color.White;
            this.saveEditBtn.UseVisualStyleBackColor = false;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // cancelEditBtn
            // 
            this.cancelEditBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelEditBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cancelEditBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelEditBtn.BorderRadius = 0;
            this.cancelEditBtn.BorderSize = 0;
            this.cancelEditBtn.FlatAppearance.BorderSize = 0;
            this.cancelEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditBtn.ForeColor = System.Drawing.Color.White;
            this.cancelEditBtn.Location = new System.Drawing.Point(242, 15);
            this.cancelEditBtn.Name = "cancelEditBtn";
            this.cancelEditBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelEditBtn.TabIndex = 2;
            this.cancelEditBtn.Text = "Cancel";
            this.cancelEditBtn.TextColor = System.Drawing.Color.White;
            this.cancelEditBtn.UseVisualStyleBackColor = false;
            this.cancelEditBtn.Click += new System.EventHandler(this.cancelEditBtn_Click);
            // 
            // colorHexPanel
            // 
            this.colorHexPanel.Location = new System.Drawing.Point(190, 289);
            this.colorHexPanel.Name = "colorHexPanel";
            this.colorHexPanel.Size = new System.Drawing.Size(109, 31);
            this.colorHexPanel.TabIndex = 7;
            // 
            // prodCountTextBox
            // 
            this.prodCountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodCountTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodCountTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodCountTextBox.BorderRadius = 0;
            this.prodCountTextBox.BorderSize = 2;
            this.prodCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodCountTextBox.Location = new System.Drawing.Point(29, 347);
            this.prodCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodCountTextBox.Multiline = false;
            this.prodCountTextBox.Name = "prodCountTextBox";
            this.prodCountTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodCountTextBox.PasswordChar = false;
            this.prodCountTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodCountTextBox.PlaceholderText = "";
            this.prodCountTextBox.Size = new System.Drawing.Size(134, 31);
            this.prodCountTextBox.TabIndex = 6;
            this.prodCountTextBox.Texts = "";
            this.prodCountTextBox.UnderlinedStyle = false;
            // 
            // prodColorHexTextBox
            // 
            this.prodColorHexTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodColorHexTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodColorHexTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodColorHexTextBox.BorderRadius = 0;
            this.prodColorHexTextBox.BorderSize = 2;
            this.prodColorHexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodColorHexTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodColorHexTextBox.Location = new System.Drawing.Point(29, 289);
            this.prodColorHexTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodColorHexTextBox.Multiline = false;
            this.prodColorHexTextBox.Name = "prodColorHexTextBox";
            this.prodColorHexTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodColorHexTextBox.PasswordChar = false;
            this.prodColorHexTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodColorHexTextBox.PlaceholderText = "";
            this.prodColorHexTextBox.Size = new System.Drawing.Size(134, 31);
            this.prodColorHexTextBox.TabIndex = 5;
            this.prodColorHexTextBox.Texts = "";
            this.prodColorHexTextBox.UnderlinedStyle = false;
            // 
            // prodColorTextBox
            // 
            this.prodColorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodColorTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodColorTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodColorTextBox.BorderRadius = 0;
            this.prodColorTextBox.BorderSize = 2;
            this.prodColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodColorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodColorTextBox.Location = new System.Drawing.Point(29, 237);
            this.prodColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodColorTextBox.Multiline = false;
            this.prodColorTextBox.Name = "prodColorTextBox";
            this.prodColorTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodColorTextBox.PasswordChar = false;
            this.prodColorTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodColorTextBox.PlaceholderText = "";
            this.prodColorTextBox.Size = new System.Drawing.Size(134, 31);
            this.prodColorTextBox.TabIndex = 4;
            this.prodColorTextBox.Texts = "";
            this.prodColorTextBox.UnderlinedStyle = false;
            // 
            // prodPriceTextBox
            // 
            this.prodPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodPriceTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodPriceTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodPriceTextBox.BorderRadius = 0;
            this.prodPriceTextBox.BorderSize = 2;
            this.prodPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodPriceTextBox.Location = new System.Drawing.Point(29, 179);
            this.prodPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodPriceTextBox.Multiline = false;
            this.prodPriceTextBox.Name = "prodPriceTextBox";
            this.prodPriceTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodPriceTextBox.PasswordChar = false;
            this.prodPriceTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodPriceTextBox.PlaceholderText = "";
            this.prodPriceTextBox.Size = new System.Drawing.Size(270, 31);
            this.prodPriceTextBox.TabIndex = 3;
            this.prodPriceTextBox.Texts = "";
            this.prodPriceTextBox.UnderlinedStyle = false;
            // 
            // prodTypeNameTextBox
            // 
            this.prodTypeNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodTypeNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodTypeNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodTypeNameTextBox.BorderRadius = 0;
            this.prodTypeNameTextBox.BorderSize = 2;
            this.prodTypeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTypeNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodTypeNameTextBox.Location = new System.Drawing.Point(29, 130);
            this.prodTypeNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodTypeNameTextBox.Multiline = false;
            this.prodTypeNameTextBox.Name = "prodTypeNameTextBox";
            this.prodTypeNameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodTypeNameTextBox.PasswordChar = false;
            this.prodTypeNameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodTypeNameTextBox.PlaceholderText = "";
            this.prodTypeNameTextBox.Size = new System.Drawing.Size(270, 31);
            this.prodTypeNameTextBox.TabIndex = 2;
            this.prodTypeNameTextBox.Texts = "";
            this.prodTypeNameTextBox.UnderlinedStyle = false;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodNameTextBox.BorderRadius = 0;
            this.prodNameTextBox.BorderSize = 2;
            this.prodNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodNameTextBox.Location = new System.Drawing.Point(29, 73);
            this.prodNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodNameTextBox.Multiline = false;
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodNameTextBox.PasswordChar = false;
            this.prodNameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodNameTextBox.PlaceholderText = "";
            this.prodNameTextBox.Size = new System.Drawing.Size(270, 31);
            this.prodNameTextBox.TabIndex = 1;
            this.prodNameTextBox.Texts = "";
            this.prodNameTextBox.UnderlinedStyle = false;
            // 
            // prodIdTextBox
            // 
            this.prodIdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prodIdTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.prodIdTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.prodIdTextBox.BorderRadius = 0;
            this.prodIdTextBox.BorderSize = 2;
            this.prodIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodIdTextBox.Location = new System.Drawing.Point(29, 23);
            this.prodIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodIdTextBox.Multiline = false;
            this.prodIdTextBox.Name = "prodIdTextBox";
            this.prodIdTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodIdTextBox.PasswordChar = false;
            this.prodIdTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodIdTextBox.PlaceholderText = "";
            this.prodIdTextBox.Size = new System.Drawing.Size(270, 31);
            this.prodIdTextBox.TabIndex = 0;
            this.prodIdTextBox.Texts = "";
            this.prodIdTextBox.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 59);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products Detail";
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 653);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.OnProductDetailLoad);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodPictureBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.editModePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox prodPictureBox;
        private CustomControls.RJControls.RJTextBox prodIdTextBox;
        private CustomControls.RJControls.RJTextBox prodTypeNameTextBox;
        private CustomControls.RJControls.RJTextBox prodNameTextBox;
        private CustomControls.RJControls.RJTextBox prodPriceTextBox;
        private CustomControls.RJControls.RJTextBox prodCountTextBox;
        private CustomControls.RJControls.RJTextBox prodColorHexTextBox;
        private CustomControls.RJControls.RJTextBox prodColorTextBox;
        private System.Windows.Forms.Panel colorHexPanel;
        private CustomControls.RJControls.RJButton editProdBtn;
        private CustomControls.RJControls.RJButton removeProdBtn;
        private System.Windows.Forms.Panel editModePanel;
        private CustomControls.RJControls.RJButton saveEditBtn;
        private CustomControls.RJControls.RJButton cancelEditBtn;
        private CustomControls.RJControls.RJButton backBtn;
        private CustomControls.RJControls.RJButton selectImageBtn;
    }
}