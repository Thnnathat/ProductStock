namespace ProductStock.Views
{
    partial class Index
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.empName = new System.Windows.Forms.Label();
            this.empRole = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indexContentPannel = new System.Windows.Forms.Panel();
            this.indexMenuPannel = new System.Windows.Forms.Panel();
            this.employeeMenuBtn = new System.Windows.Forms.Button();
            this.productMenuBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.personCircularPictureBox = new ProductStock.CircularPictureBox();
            this.logoutBtn = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.indexMenuPannel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personCircularPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(145)))), ((int)(((byte)(10)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.personCircularPictureBox);
            this.panel9.Controls.Add(this.empName);
            this.panel9.Controls.Add(this.empRole);
            this.panel9.Controls.Add(this.empID);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(-2, -2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1095, 57);
            this.panel9.TabIndex = 6;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.White;
            this.empName.Location = new System.Drawing.Point(484, 19);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(51, 20);
            this.empName.TabIndex = 5;
            this.empName.Text = "None";
            // 
            // empRole
            // 
            this.empRole.AutoSize = true;
            this.empRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRole.ForeColor = System.Drawing.Color.White;
            this.empRole.Location = new System.Drawing.Point(886, 19);
            this.empRole.Name = "empRole";
            this.empRole.Size = new System.Drawing.Size(51, 20);
            this.empRole.TabIndex = 4;
            this.empRole.Text = "None";
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.ForeColor = System.Drawing.Color.White;
            this.empID.Location = new System.Drawing.Point(232, 19);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(51, 20);
            this.empID.TabIndex = 3;
            this.empID.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(821, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.indexContentPannel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 625);
            this.panel2.TabIndex = 1;
            // 
            // indexContentPannel
            // 
            this.indexContentPannel.BackColor = System.Drawing.Color.White;
            this.indexContentPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indexContentPannel.Location = new System.Drawing.Point(0, 0);
            this.indexContentPannel.Name = "indexContentPannel";
            this.indexContentPannel.Size = new System.Drawing.Size(1283, 625);
            this.indexContentPannel.TabIndex = 2;
            // 
            // indexMenuPannel
            // 
            this.indexMenuPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.indexMenuPannel.Controls.Add(this.employeeMenuBtn);
            this.indexMenuPannel.Controls.Add(this.productMenuBtn);
            this.indexMenuPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexMenuPannel.Location = new System.Drawing.Point(0, 0);
            this.indexMenuPannel.Name = "indexMenuPannel";
            this.indexMenuPannel.Size = new System.Drawing.Size(1283, 43);
            this.indexMenuPannel.TabIndex = 2;
            // 
            // employeeMenuBtn
            // 
            this.employeeMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.employeeMenuBtn.FlatAppearance.BorderSize = 0;
            this.employeeMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeMenuBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.employeeMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeMenuBtn.Location = new System.Drawing.Point(245, 0);
            this.employeeMenuBtn.Name = "employeeMenuBtn";
            this.employeeMenuBtn.Size = new System.Drawing.Size(252, 43);
            this.employeeMenuBtn.TabIndex = 1;
            this.employeeMenuBtn.Text = "Employees";
            this.employeeMenuBtn.UseVisualStyleBackColor = false;
            this.employeeMenuBtn.Click += new System.EventHandler(this.employeeMenuBtn_Click);
            // 
            // productMenuBtn
            // 
            this.productMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.productMenuBtn.FlatAppearance.BorderSize = 0;
            this.productMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMenuBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.productMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.productMenuBtn.Name = "productMenuBtn";
            this.productMenuBtn.Size = new System.Drawing.Size(252, 43);
            this.productMenuBtn.TabIndex = 0;
            this.productMenuBtn.Text = "Products";
            this.productMenuBtn.UseVisualStyleBackColor = false;
            this.productMenuBtn.Click += new System.EventHandler(this.productMenuBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.indexMenuPannel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1283, 668);
            this.panel4.TabIndex = 3;
            // 
            // personCircularPictureBox
            // 
            this.personCircularPictureBox.Image = global::ProductStock.Properties.Resources.Neovim_Logo;
            this.personCircularPictureBox.Location = new System.Drawing.Point(20, 6);
            this.personCircularPictureBox.Name = "personCircularPictureBox";
            this.personCircularPictureBox.Size = new System.Drawing.Size(46, 46);
            this.personCircularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personCircularPictureBox.TabIndex = 1;
            this.personCircularPictureBox.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.DarkRed;
            this.logoutBtn.BackgroundColor = System.Drawing.Color.DarkRed;
            this.logoutBtn.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.BorderRadius = 5;
            this.logoutBtn.BorderSize = 0;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(1099, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(168, 40);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextColor = System.Drawing.Color.White;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 725);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_FormClosed);
            this.Load += new System.EventHandler(this.Index_load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.indexMenuPannel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personCircularPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel indexContentPannel;
        private CustomControls.RJControls.RJButton logoutBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empRole;
        private System.Windows.Forms.Label empID;
        private CircularPictureBox personCircularPictureBox;
        private System.Windows.Forms.Panel indexMenuPannel;
        private System.Windows.Forms.Button productMenuBtn;
        private System.Windows.Forms.Button employeeMenuBtn;
        private System.Windows.Forms.Panel panel4;
    }
}