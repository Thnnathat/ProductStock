namespace ProductStock.Views.Compunents
{
    partial class InStock
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchProdText = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inStockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.searchProdText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 55);
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
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "In Stock";
            // 
            // searchProdText
            // 
            this.searchProdText.BackColor = System.Drawing.SystemColors.Window;
            this.searchProdText.BorderColor = System.Drawing.Color.Transparent;
            this.searchProdText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.searchProdText.BorderRadius = 10;
            this.searchProdText.BorderSize = 2;
            this.searchProdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchProdText.Location = new System.Drawing.Point(233, 13);
            this.searchProdText.Margin = new System.Windows.Forms.Padding(4);
            this.searchProdText.Multiline = false;
            this.searchProdText.Name = "searchProdText";
            this.searchProdText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchProdText.PasswordChar = false;
            this.searchProdText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchProdText.PlaceholderText = "";
            this.searchProdText.Size = new System.Drawing.Size(402, 31);
            this.searchProdText.TabIndex = 0;
            this.searchProdText.Texts = "";
            this.searchProdText.UnderlinedStyle = false;
            this.searchProdText._TextChanged += new System.EventHandler(this.OnInStaocSearchChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inStockDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 395);
            this.panel1.TabIndex = 0;
            // 
            // inStockDataGridView
            // 
            this.inStockDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.inStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.stock_id,
            this.dataGridViewTextBoxColumn2,
            this.date_time});
            this.inStockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inStockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inStockDataGridView.Name = "inStockDataGridView";
            this.inStockDataGridView.Size = new System.Drawing.Size(800, 395);
            this.inStockDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // stock_id
            // 
            this.stock_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_id.DataPropertyName = "stock_id";
            this.stock_id.HeaderText = "Stock ID";
            this.stock_id.Name = "stock_id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // date_time
            // 
            this.date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_time.DataPropertyName = "date_time";
            this.date_time.HeaderText = "DateTime";
            this.date_time.Name = "date_time";
            // 
            // InStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "InStock";
            this.Text = "InStock";
            this.Load += new System.EventHandler(this.OnInStockLoad);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox searchProdText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView inStockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
    }
}