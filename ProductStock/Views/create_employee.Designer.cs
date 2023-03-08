namespace ProductStock.Views
{
    partial class create_employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circularPictureBox1 = new ProductStock.CircularPictureBox();
            this.circularPictureBox2 = new ProductStock.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(100, 50);
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.Image = global::ProductStock.Properties.Resources.f90c088166002941f6e1006b654cef12;
            this.circularPictureBox2.Location = new System.Drawing.Point(477, 132);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(200, 200);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPictureBox2.TabIndex = 1;
            this.circularPictureBox2.TabStop = false;
            // 
            // create_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.Name = "create_employee";
            this.Size = new System.Drawing.Size(1280, 580);
            this.Load += new System.EventHandler(this.create_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
    }
}
