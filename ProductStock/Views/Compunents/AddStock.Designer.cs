namespace ProductStock.Views.Compunents
{
    partial class AddStock
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
            this.stockCountTextBox = new CustomControls.RJControls.RJTextBox();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.addProdBtn = new CustomControls.RJControls.RJButton();
            this.removeStock = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeStock);
            this.panel1.Controls.Add(this.stockCountTextBox);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.addProdBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 246);
            this.panel1.TabIndex = 0;
            // 
            // stockCountTextBox
            // 
            this.stockCountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.stockCountTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.stockCountTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.stockCountTextBox.BorderRadius = 0;
            this.stockCountTextBox.BorderSize = 2;
            this.stockCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockCountTextBox.Location = new System.Drawing.Point(32, 34);
            this.stockCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockCountTextBox.Multiline = false;
            this.stockCountTextBox.Name = "stockCountTextBox";
            this.stockCountTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.stockCountTextBox.PasswordChar = false;
            this.stockCountTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.stockCountTextBox.PlaceholderText = "";
            this.stockCountTextBox.Size = new System.Drawing.Size(250, 31);
            this.stockCountTextBox.TabIndex = 8;
            this.stockCountTextBox.Texts = "";
            this.stockCountTextBox.UnderlinedStyle = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(340, 183);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 30);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.White;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProdBtn.BackColor = System.Drawing.Color.Green;
            this.addProdBtn.BackgroundColor = System.Drawing.Color.Green;
            this.addProdBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addProdBtn.BorderRadius = 0;
            this.addProdBtn.BorderSize = 0;
            this.addProdBtn.FlatAppearance.BorderSize = 0;
            this.addProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Location = new System.Drawing.Point(340, 34);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(150, 30);
            this.addProdBtn.TabIndex = 6;
            this.addProdBtn.Text = "Add Stock";
            this.addProdBtn.TextColor = System.Drawing.Color.White;
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // removeStock
            // 
            this.removeStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeStock.BackColor = System.Drawing.Color.DarkOrange;
            this.removeStock.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.removeStock.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeStock.BorderRadius = 0;
            this.removeStock.BorderSize = 0;
            this.removeStock.FlatAppearance.BorderSize = 0;
            this.removeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStock.ForeColor = System.Drawing.Color.White;
            this.removeStock.Location = new System.Drawing.Point(340, 82);
            this.removeStock.Name = "removeStock";
            this.removeStock.Size = new System.Drawing.Size(150, 30);
            this.removeStock.TabIndex = 9;
            this.removeStock.Text = "Remove Stock";
            this.removeStock.TextColor = System.Drawing.Color.White;
            this.removeStock.UseVisualStyleBackColor = false;
            this.removeStock.Click += new System.EventHandler(this.removeStock_Click);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 246);
            this.Controls.Add(this.panel1);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton cancelBtn;
        private CustomControls.RJControls.RJButton addProdBtn;
        private CustomControls.RJControls.RJTextBox stockCountTextBox;
        private CustomControls.RJControls.RJButton removeStock;
    }
}