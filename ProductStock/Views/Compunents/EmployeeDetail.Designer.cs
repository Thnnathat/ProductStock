namespace ProductStock.Views.Compunents
{
    partial class EmployeeDetail
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
            this.empPictureBox = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backBtn = new CustomControls.RJControls.RJButton();
            this.editEmpBtn = new CustomControls.RJControls.RJButton();
            this.removeEmpBtn = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editModePanel = new System.Windows.Forms.Panel();
            this.saveEditBtn = new CustomControls.RJControls.RJButton();
            this.cancelEditBtn = new CustomControls.RJControls.RJButton();
            this.empLastNameTextBox = new CustomControls.RJControls.RJTextBox();
            this.empFirstNameTextBox = new CustomControls.RJControls.RJTextBox();
            this.empPasswordTextBox = new CustomControls.RJControls.RJTextBox();
            this.empIdTextBox = new CustomControls.RJControls.RJTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1068, 645);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 586);
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
            this.panel5.Size = new System.Drawing.Size(628, 586);
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
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.empPictureBox);
            this.panel7.Location = new System.Drawing.Point(76, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(476, 378);
            this.panel7.TabIndex = 1;
            // 
            // empPictureBox
            // 
            this.empPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empPictureBox.Image = global::ProductStock.Properties.Resources.image_gdc9f050a2_640;
            this.empPictureBox.Location = new System.Drawing.Point(0, 0);
            this.empPictureBox.Name = "empPictureBox";
            this.empPictureBox.Size = new System.Drawing.Size(476, 378);
            this.empPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPictureBox.TabIndex = 0;
            this.empPictureBox.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.backBtn);
            this.panel6.Controls.Add(this.editEmpBtn);
            this.panel6.Controls.Add(this.removeEmpBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 499);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 87);
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
            // editEmpBtn
            // 
            this.editEmpBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.editEmpBtn.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.editEmpBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editEmpBtn.BorderRadius = 0;
            this.editEmpBtn.BorderSize = 0;
            this.editEmpBtn.FlatAppearance.BorderSize = 0;
            this.editEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmpBtn.ForeColor = System.Drawing.Color.White;
            this.editEmpBtn.Location = new System.Drawing.Point(23, 15);
            this.editEmpBtn.Name = "editEmpBtn";
            this.editEmpBtn.Size = new System.Drawing.Size(150, 40);
            this.editEmpBtn.TabIndex = 1;
            this.editEmpBtn.Text = "Edit";
            this.editEmpBtn.TextColor = System.Drawing.Color.White;
            this.editEmpBtn.UseVisualStyleBackColor = false;
            this.editEmpBtn.Click += new System.EventHandler(this.editEmpBtn_Click);
            // 
            // removeEmpBtn
            // 
            this.removeEmpBtn.BackColor = System.Drawing.Color.DarkRed;
            this.removeEmpBtn.BackgroundColor = System.Drawing.Color.DarkRed;
            this.removeEmpBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeEmpBtn.BorderRadius = 0;
            this.removeEmpBtn.BorderSize = 0;
            this.removeEmpBtn.FlatAppearance.BorderSize = 0;
            this.removeEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmpBtn.ForeColor = System.Drawing.Color.White;
            this.removeEmpBtn.Location = new System.Drawing.Point(198, 15);
            this.removeEmpBtn.Name = "removeEmpBtn";
            this.removeEmpBtn.Size = new System.Drawing.Size(150, 40);
            this.removeEmpBtn.TabIndex = 0;
            this.removeEmpBtn.Text = "Remove";
            this.removeEmpBtn.TextColor = System.Drawing.Color.White;
            this.removeEmpBtn.UseVisualStyleBackColor = false;
            this.removeEmpBtn.Click += new System.EventHandler(this.removeEmpBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimeLabel);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.roleComboBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.prefixComboBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.editModePanel);
            this.panel3.Controls.Add(this.empLastNameTextBox);
            this.panel3.Controls.Add(this.empFirstNameTextBox);
            this.panel3.Controls.Add(this.empPasswordTextBox);
            this.panel3.Controls.Add(this.empIdTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 586);
            this.panel3.TabIndex = 0;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(137, 353);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.dateTimeLabel.TabIndex = 15;
            this.dateTimeLabel.Text = "Date Time Add";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date Time Add";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(94, 301);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.FormattingEnabled = true;
            this.prefixComboBox.Location = new System.Drawing.Point(94, 76);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(121, 21);
            this.prefixComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prefix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "LastNmae";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "id";
            // 
            // editModePanel
            // 
            this.editModePanel.Controls.Add(this.saveEditBtn);
            this.editModePanel.Controls.Add(this.cancelEditBtn);
            this.editModePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editModePanel.Location = new System.Drawing.Point(0, 499);
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
            // empLastNameTextBox
            // 
            this.empLastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.empLastNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.empLastNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.empLastNameTextBox.BorderRadius = 0;
            this.empLastNameTextBox.BorderSize = 2;
            this.empLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empLastNameTextBox.Location = new System.Drawing.Point(94, 240);
            this.empLastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empLastNameTextBox.Multiline = false;
            this.empLastNameTextBox.Name = "empLastNameTextBox";
            this.empLastNameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.empLastNameTextBox.PasswordChar = false;
            this.empLastNameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empLastNameTextBox.PlaceholderText = "";
            this.empLastNameTextBox.Size = new System.Drawing.Size(270, 31);
            this.empLastNameTextBox.TabIndex = 3;
            this.empLastNameTextBox.Texts = "";
            this.empLastNameTextBox.UnderlinedStyle = false;
            // 
            // empFirstNameTextBox
            // 
            this.empFirstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.empFirstNameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.empFirstNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.empFirstNameTextBox.BorderRadius = 0;
            this.empFirstNameTextBox.BorderSize = 2;
            this.empFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFirstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empFirstNameTextBox.Location = new System.Drawing.Point(94, 191);
            this.empFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empFirstNameTextBox.Multiline = false;
            this.empFirstNameTextBox.Name = "empFirstNameTextBox";
            this.empFirstNameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.empFirstNameTextBox.PasswordChar = false;
            this.empFirstNameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empFirstNameTextBox.PlaceholderText = "";
            this.empFirstNameTextBox.Size = new System.Drawing.Size(270, 31);
            this.empFirstNameTextBox.TabIndex = 2;
            this.empFirstNameTextBox.Texts = "";
            this.empFirstNameTextBox.UnderlinedStyle = false;
            // 
            // empPasswordTextBox
            // 
            this.empPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.empPasswordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.empPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.empPasswordTextBox.BorderRadius = 0;
            this.empPasswordTextBox.BorderSize = 2;
            this.empPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empPasswordTextBox.Location = new System.Drawing.Point(94, 122);
            this.empPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empPasswordTextBox.Multiline = false;
            this.empPasswordTextBox.Name = "empPasswordTextBox";
            this.empPasswordTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.empPasswordTextBox.PasswordChar = false;
            this.empPasswordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empPasswordTextBox.PlaceholderText = "";
            this.empPasswordTextBox.Size = new System.Drawing.Size(270, 31);
            this.empPasswordTextBox.TabIndex = 1;
            this.empPasswordTextBox.Texts = "";
            this.empPasswordTextBox.UnderlinedStyle = false;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.empIdTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.empIdTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.empIdTextBox.BorderRadius = 0;
            this.empIdTextBox.BorderSize = 2;
            this.empIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empIdTextBox.Location = new System.Drawing.Point(94, 27);
            this.empIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empIdTextBox.Multiline = false;
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.empIdTextBox.PasswordChar = false;
            this.empIdTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empIdTextBox.PlaceholderText = "";
            this.empIdTextBox.Size = new System.Drawing.Size(270, 31);
            this.empIdTextBox.TabIndex = 0;
            this.empIdTextBox.Texts = "";
            this.empIdTextBox.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 59);
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
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 645);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeDetail";
            this.Load += new System.EventHandler(this.OnEmpLoad);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.editModePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.RJControls.RJButton selectImageBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox empPictureBox;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.RJControls.RJButton backBtn;
        private CustomControls.RJControls.RJButton editEmpBtn;
        private CustomControls.RJControls.RJButton removeEmpBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel editModePanel;
        private CustomControls.RJControls.RJButton saveEditBtn;
        private CustomControls.RJControls.RJButton cancelEditBtn;
        private CustomControls.RJControls.RJTextBox empLastNameTextBox;
        private CustomControls.RJControls.RJTextBox empFirstNameTextBox;
        private CustomControls.RJControls.RJTextBox empPasswordTextBox;
        private CustomControls.RJControls.RJTextBox empIdTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox prefixComboBox;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label label8;
    }
}