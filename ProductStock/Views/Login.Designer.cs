namespace ProductStock
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empIDTextBox = new CustomControls.RJControls.RJTextBox();
            this.empPasswordTextBox = new CustomControls.RJControls.RJTextBox();
            this.loginBtn = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(419, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empIDTextBox);
            this.panel1.Controls.Add(this.empPasswordTextBox);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 292);
            this.panel1.TabIndex = 16;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.BorderColor = System.Drawing.Color.White;
            this.exitBtn.BorderRadius = 5;
            this.exitBtn.BorderSize = 0;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(518, 218);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 40);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextColor = System.Drawing.Color.White;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(72, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.empIDTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.empIDTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.empIDTextBox.BorderRadius = 16;
            this.empIDTextBox.BorderSize = 2;
            this.empIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empIDTextBox.Location = new System.Drawing.Point(213, 86);
            this.empIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empIDTextBox.Multiline = false;
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.empIDTextBox.PasswordChar = false;
            this.empIDTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empIDTextBox.PlaceholderText = "";
            this.empIDTextBox.Size = new System.Drawing.Size(271, 39);
            this.empIDTextBox.TabIndex = 19;
            this.empIDTextBox.Texts = "";
            this.empIDTextBox.UnderlinedStyle = false;
            // 
            // empPasswordTextBox
            // 
            this.empPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.empPasswordTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.empPasswordTextBox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.empPasswordTextBox.BorderRadius = 16;
            this.empPasswordTextBox.BorderSize = 2;
            this.empPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empPasswordTextBox.Location = new System.Drawing.Point(213, 153);
            this.empPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empPasswordTextBox.Multiline = false;
            this.empPasswordTextBox.Name = "empPasswordTextBox";
            this.empPasswordTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.empPasswordTextBox.PasswordChar = false;
            this.empPasswordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.empPasswordTextBox.PlaceholderText = "";
            this.empPasswordTextBox.Size = new System.Drawing.Size(271, 39);
            this.empPasswordTextBox.TabIndex = 20;
            this.empPasswordTextBox.Texts = "";
            this.empPasswordTextBox.UnderlinedStyle = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(23)))));
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(23)))));
            this.loginBtn.BorderColor = System.Drawing.Color.Yellow;
            this.loginBtn.BorderRadius = 20;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(518, 86);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(145, 102);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(157)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(710, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox empIDTextBox;
        private CustomControls.RJControls.RJTextBox empPasswordTextBox;
        private CustomControls.RJControls.RJButton loginBtn;
        private CustomControls.RJControls.RJButton exitBtn;
    }
}

