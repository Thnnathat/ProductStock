namespace ProductStock.Views.Compunents
{
    partial class EmployeeSubMenu
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
            this.empDetailBtn = new System.Windows.Forms.Button();
            this.empListBtn = new System.Windows.Forms.Button();
            this.empMenuContainerPanel = new System.Windows.Forms.Panel();
            this.indexMenuPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // indexMenuPannel
            // 
            this.indexMenuPannel.BackColor = System.Drawing.Color.Green;
            this.indexMenuPannel.Controls.Add(this.empDetailBtn);
            this.indexMenuPannel.Controls.Add(this.empListBtn);
            this.indexMenuPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexMenuPannel.Location = new System.Drawing.Point(0, 0);
            this.indexMenuPannel.Name = "indexMenuPannel";
            this.indexMenuPannel.Size = new System.Drawing.Size(800, 33);
            this.indexMenuPannel.TabIndex = 3;
            // 
            // empDetailBtn
            // 
            this.empDetailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.empDetailBtn.BackColor = System.Drawing.Color.Green;
            this.empDetailBtn.FlatAppearance.BorderSize = 0;
            this.empDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.empDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empDetailBtn.Location = new System.Drawing.Point(245, 0);
            this.empDetailBtn.Name = "empDetailBtn";
            this.empDetailBtn.Size = new System.Drawing.Size(252, 33);
            this.empDetailBtn.TabIndex = 1;
            this.empDetailBtn.Text = "Employees Detail";
            this.empDetailBtn.UseVisualStyleBackColor = false;
            this.empDetailBtn.Click += new System.EventHandler(this.empDetailBtn_Click);
            // 
            // empListBtn
            // 
            this.empListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.empListBtn.BackColor = System.Drawing.Color.Green;
            this.empListBtn.FlatAppearance.BorderSize = 0;
            this.empListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empListBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.empListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empListBtn.Location = new System.Drawing.Point(0, 0);
            this.empListBtn.Name = "empListBtn";
            this.empListBtn.Size = new System.Drawing.Size(252, 33);
            this.empListBtn.TabIndex = 0;
            this.empListBtn.Text = "Employees List";
            this.empListBtn.UseVisualStyleBackColor = false;
            this.empListBtn.Click += new System.EventHandler(this.empListBtn_Click);
            // 
            // empMenuContainerPanel
            // 
            this.empMenuContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empMenuContainerPanel.Location = new System.Drawing.Point(0, 33);
            this.empMenuContainerPanel.Name = "empMenuContainerPanel";
            this.empMenuContainerPanel.Size = new System.Drawing.Size(800, 417);
            this.empMenuContainerPanel.TabIndex = 4;
            // 
            // EmployeeSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empMenuContainerPanel);
            this.Controls.Add(this.indexMenuPannel);
            this.Name = "EmployeeSubMenu";
            this.Text = "EmployeeSubMenu";
            this.Load += new System.EventHandler(this.OnEmployeeSubMenuLoad);
            this.indexMenuPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel indexMenuPannel;
        private System.Windows.Forms.Button empDetailBtn;
        private System.Windows.Forms.Button empListBtn;
        private System.Windows.Forms.Panel empMenuContainerPanel;
    }
}