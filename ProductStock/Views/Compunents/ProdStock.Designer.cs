namespace ProductStock.Views.Compunents
{
    partial class ProdStock
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
            this.stockPanel = new System.Windows.Forms.Panel();
            this.indexMenuPannel = new System.Windows.Forms.Panel();
            this.closeBtn = new CustomControls.RJControls.RJButton();
            this.addProdBtn = new CustomControls.RJControls.RJButton();
            this.outStockBtn = new System.Windows.Forms.Button();
            this.inStockBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.indexMenuPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 645);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stockPanel);
            this.panel2.Controls.Add(this.indexMenuPannel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 645);
            this.panel2.TabIndex = 5;
            // 
            // stockPanel
            // 
            this.stockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockPanel.Location = new System.Drawing.Point(0, 44);
            this.stockPanel.Name = "stockPanel";
            this.stockPanel.Size = new System.Drawing.Size(1019, 601);
            this.stockPanel.TabIndex = 6;
            // 
            // indexMenuPannel
            // 
            this.indexMenuPannel.BackColor = System.Drawing.Color.RoyalBlue;
            this.indexMenuPannel.Controls.Add(this.closeBtn);
            this.indexMenuPannel.Controls.Add(this.addProdBtn);
            this.indexMenuPannel.Controls.Add(this.outStockBtn);
            this.indexMenuPannel.Controls.Add(this.inStockBtn);
            this.indexMenuPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexMenuPannel.Location = new System.Drawing.Point(0, 0);
            this.indexMenuPannel.Name = "indexMenuPannel";
            this.indexMenuPannel.Size = new System.Drawing.Size(1019, 44);
            this.indexMenuPannel.TabIndex = 5;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.closeBtn.BackgroundColor = System.Drawing.Color.DarkGray;
            this.closeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeBtn.BorderRadius = 0;
            this.closeBtn.BorderSize = 0;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(830, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(150, 30);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProdBtn.BackColor = System.Drawing.Color.Orange;
            this.addProdBtn.BackgroundColor = System.Drawing.Color.Orange;
            this.addProdBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addProdBtn.BorderRadius = 0;
            this.addProdBtn.BorderSize = 0;
            this.addProdBtn.FlatAppearance.BorderSize = 0;
            this.addProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Location = new System.Drawing.Point(640, 6);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(150, 30);
            this.addProdBtn.TabIndex = 3;
            this.addProdBtn.Text = "Edit Stock";
            this.addProdBtn.TextColor = System.Drawing.Color.White;
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // outStockBtn
            // 
            this.outStockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outStockBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.outStockBtn.FlatAppearance.BorderSize = 0;
            this.outStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outStockBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.outStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outStockBtn.Location = new System.Drawing.Point(248, 0);
            this.outStockBtn.Name = "outStockBtn";
            this.outStockBtn.Size = new System.Drawing.Size(252, 44);
            this.outStockBtn.TabIndex = 2;
            this.outStockBtn.Text = "Out Stock";
            this.outStockBtn.UseVisualStyleBackColor = false;
            this.outStockBtn.Click += new System.EventHandler(this.outStockBtn_Click);
            // 
            // inStockBtn
            // 
            this.inStockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inStockBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.inStockBtn.FlatAppearance.BorderSize = 0;
            this.inStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.inStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inStockBtn.Location = new System.Drawing.Point(0, 0);
            this.inStockBtn.Name = "inStockBtn";
            this.inStockBtn.Size = new System.Drawing.Size(252, 44);
            this.inStockBtn.TabIndex = 0;
            this.inStockBtn.Text = "In Stock List";
            this.inStockBtn.UseVisualStyleBackColor = false;
            this.inStockBtn.Click += new System.EventHandler(this.inStockBtn_Click);
            // 
            // ProdStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 645);
            this.Controls.Add(this.panel1);
            this.Name = "ProdStock";
            this.Text = "ProdStock";
            this.Load += new System.EventHandler(this.OnProdStockLoad);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.indexMenuPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel indexMenuPannel;
        private System.Windows.Forms.Button outStockBtn;
        private System.Windows.Forms.Button inStockBtn;
        private System.Windows.Forms.Panel stockPanel;
        private CustomControls.RJControls.RJButton addProdBtn;
        private CustomControls.RJControls.RJButton closeBtn;
    }
}