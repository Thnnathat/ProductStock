namespace ProductStock.Views.Compunents
{
    partial class ProductSubMenu
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
            this.indexMenuPannel = new System.Windows.Forms.Panel();
            this.prodStockBtn = new System.Windows.Forms.Button();
            this.prodListBtn = new System.Windows.Forms.Button();
            this.prodMenuContainerPanel = new System.Windows.Forms.Panel();
            this.indexMenuPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // indexMenuPannel
            // 
            this.indexMenuPannel.BackColor = System.Drawing.Color.RoyalBlue;
            this.indexMenuPannel.Controls.Add(this.prodStockBtn);
            this.indexMenuPannel.Controls.Add(this.prodListBtn);
            this.indexMenuPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexMenuPannel.Location = new System.Drawing.Point(0, 0);
            this.indexMenuPannel.Name = "indexMenuPannel";
            this.indexMenuPannel.Size = new System.Drawing.Size(800, 33);
            this.indexMenuPannel.TabIndex = 4;
            // 
            // prodStockBtn
            // 
            this.prodStockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prodStockBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.prodStockBtn.FlatAppearance.BorderSize = 0;
            this.prodStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodStockBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.prodStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodStockBtn.Location = new System.Drawing.Point(248, 0);
            this.prodStockBtn.Name = "prodStockBtn";
            this.prodStockBtn.Size = new System.Drawing.Size(252, 33);
            this.prodStockBtn.TabIndex = 2;
            this.prodStockBtn.Text = "Product Stock";
            this.prodStockBtn.UseVisualStyleBackColor = false;
            this.prodStockBtn.Click += new System.EventHandler(this.prodStockBtn_Click);
            // 
            // prodListBtn
            // 
            this.prodListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prodListBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.prodListBtn.FlatAppearance.BorderSize = 0;
            this.prodListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodListBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.prodListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodListBtn.Location = new System.Drawing.Point(0, 0);
            this.prodListBtn.Name = "prodListBtn";
            this.prodListBtn.Size = new System.Drawing.Size(252, 33);
            this.prodListBtn.TabIndex = 0;
            this.prodListBtn.Text = "Product List";
            this.prodListBtn.UseVisualStyleBackColor = false;
            this.prodListBtn.Click += new System.EventHandler(this.prodListBtn_Click);
            // 
            // prodMenuContainerPanel
            // 
            this.prodMenuContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodMenuContainerPanel.Location = new System.Drawing.Point(0, 33);
            this.prodMenuContainerPanel.Name = "prodMenuContainerPanel";
            this.prodMenuContainerPanel.Size = new System.Drawing.Size(800, 417);
            this.prodMenuContainerPanel.TabIndex = 5;
            // 
            // ProductSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodMenuContainerPanel);
            this.Controls.Add(this.indexMenuPannel);
            this.Name = "ProductSubMenu";
            this.Text = "ProductSubMenu";
            this.Load += new System.EventHandler(this.OnProductSubMenuLoad);
            this.indexMenuPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel indexMenuPannel;
        private System.Windows.Forms.Button prodListBtn;
        private System.Windows.Forms.Button prodStockBtn;
        private System.Windows.Forms.Panel prodMenuContainerPanel;
    }
}