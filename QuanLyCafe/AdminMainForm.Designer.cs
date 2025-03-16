namespace QuanLyCafe
{
    partial class AdminMainForm
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
            this.adminLogin_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogin_closeBtn = new System.Windows.Forms.Label();
            this.admin_logoutBtn = new System.Windows.Forms.Button();
            this.adminLogin_customersBtn = new System.Windows.Forms.Button();
            this.adminLogin_addProdBtn = new System.Windows.Forms.Button();
            this.adminLogin_addUserBtn = new System.Windows.Forms.Button();
            this.adminLogin_dashboardBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.allCustomersForm1 = new QuanLyCafe.AllCustomersForm();
            this.addProductForm1 = new QuanLyCafe.AddProductForm();
            this.addUsersForm1 = new QuanLyCafe.AddUsersForm();
            this.dashboardForm1 = new QuanLyCafe.DashboardForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adminLogin_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminLogin_closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 46);
            this.panel1.TabIndex = 3;
            // 
            // adminLogin_close
            // 
            this.adminLogin_close.AutoSize = true;
            this.adminLogin_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogin_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_close.Location = new System.Drawing.Point(854, 9);
            this.adminLogin_close.Name = "adminLogin_close";
            this.adminLogin_close.Size = new System.Drawing.Size(18, 18);
            this.adminLogin_close.TabIndex = 4;
            this.adminLogin_close.Text = "X";
            this.adminLogin_close.Click += new System.EventHandler(this.adminLogin_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cafe Shop Management System";
            // 
            // adminLogin_closeBtn
            // 
            this.adminLogin_closeBtn.AutoSize = true;
            this.adminLogin_closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogin_closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_closeBtn.Location = new System.Drawing.Point(1070, 9);
            this.adminLogin_closeBtn.Name = "adminLogin_closeBtn";
            this.adminLogin_closeBtn.Size = new System.Drawing.Size(18, 18);
            this.adminLogin_closeBtn.TabIndex = 2;
            this.adminLogin_closeBtn.Text = "X";
            // 
            // admin_logoutBtn
            // 
            this.admin_logoutBtn.AllowDrop = true;
            this.admin_logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_logoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logoutBtn.ForeColor = System.Drawing.Color.White;
            this.admin_logoutBtn.Location = new System.Drawing.Point(18, 504);
            this.admin_logoutBtn.Name = "admin_logoutBtn";
            this.admin_logoutBtn.Size = new System.Drawing.Size(176, 38);
            this.admin_logoutBtn.TabIndex = 15;
            this.admin_logoutBtn.Text = "Logout";
            this.admin_logoutBtn.UseVisualStyleBackColor = true;
            this.admin_logoutBtn.Click += new System.EventHandler(this.admin_logoutBtn_Click);
            // 
            // adminLogin_customersBtn
            // 
            this.adminLogin_customersBtn.AllowDrop = true;
            this.adminLogin_customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin_customersBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_customersBtn.ForeColor = System.Drawing.Color.White;
            this.adminLogin_customersBtn.Location = new System.Drawing.Point(18, 368);
            this.adminLogin_customersBtn.Name = "adminLogin_customersBtn";
            this.adminLogin_customersBtn.Size = new System.Drawing.Size(176, 38);
            this.adminLogin_customersBtn.TabIndex = 14;
            this.adminLogin_customersBtn.Text = "Customers";
            this.adminLogin_customersBtn.UseVisualStyleBackColor = true;
            this.adminLogin_customersBtn.Click += new System.EventHandler(this.adminLogin_customersBtn_Click);
            // 
            // adminLogin_addProdBtn
            // 
            this.adminLogin_addProdBtn.AllowDrop = true;
            this.adminLogin_addProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin_addProdBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_addProdBtn.ForeColor = System.Drawing.Color.White;
            this.adminLogin_addProdBtn.Location = new System.Drawing.Point(18, 314);
            this.adminLogin_addProdBtn.Name = "adminLogin_addProdBtn";
            this.adminLogin_addProdBtn.Size = new System.Drawing.Size(176, 38);
            this.adminLogin_addProdBtn.TabIndex = 13;
            this.adminLogin_addProdBtn.Text = "Products";
            this.adminLogin_addProdBtn.UseVisualStyleBackColor = true;
            this.adminLogin_addProdBtn.Click += new System.EventHandler(this.adminLogin_addProdBtn_Click);
            // 
            // adminLogin_addUserBtn
            // 
            this.adminLogin_addUserBtn.AllowDrop = true;
            this.adminLogin_addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin_addUserBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_addUserBtn.ForeColor = System.Drawing.Color.White;
            this.adminLogin_addUserBtn.Location = new System.Drawing.Point(18, 259);
            this.adminLogin_addUserBtn.Name = "adminLogin_addUserBtn";
            this.adminLogin_addUserBtn.Size = new System.Drawing.Size(176, 38);
            this.adminLogin_addUserBtn.TabIndex = 14;
            this.adminLogin_addUserBtn.Text = "Cashier";
            this.adminLogin_addUserBtn.UseVisualStyleBackColor = true;
            this.adminLogin_addUserBtn.Click += new System.EventHandler(this.adminLogin_addUserBtn_Click);
            // 
            // adminLogin_dashboardBtn
            // 
            this.adminLogin_dashboardBtn.AllowDrop = true;
            this.adminLogin_dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin_dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.adminLogin_dashboardBtn.Location = new System.Drawing.Point(18, 205);
            this.adminLogin_dashboardBtn.Name = "adminLogin_dashboardBtn";
            this.adminLogin_dashboardBtn.Size = new System.Drawing.Size(176, 38);
            this.adminLogin_dashboardBtn.TabIndex = 13;
            this.adminLogin_dashboardBtn.Text = "Dashboard";
            this.adminLogin_dashboardBtn.UseVisualStyleBackColor = true;
            this.adminLogin_dashboardBtn.Click += new System.EventHandler(this.adminLogin_dashboardBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Admin\'s Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCafe.Properties.Resources.Cafe_2;
            this.pictureBox1.Location = new System.Drawing.Point(50, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.admin_logoutBtn);
            this.panel2.Controls.Add(this.adminLogin_customersBtn);
            this.panel2.Controls.Add(this.adminLogin_addProdBtn);
            this.panel2.Controls.Add(this.adminLogin_addUserBtn);
            this.panel2.Controls.Add(this.adminLogin_dashboardBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 600);
            this.panel2.TabIndex = 4;
            // 
            // allCustomersForm1
            // 
            this.allCustomersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCustomersForm1.Location = new System.Drawing.Point(216, 46);
            this.allCustomersForm1.Name = "allCustomersForm1";
            this.allCustomersForm1.Size = new System.Drawing.Size(884, 554);
            this.allCustomersForm1.TabIndex = 5;
            // 
            // addProductForm1
            // 
            this.addProductForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductForm1.Location = new System.Drawing.Point(216, 46);
            this.addProductForm1.Name = "addProductForm1";
            this.addProductForm1.Size = new System.Drawing.Size(884, 554);
            this.addProductForm1.TabIndex = 6;
            // 
            // addUsersForm1
            // 
            this.addUsersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUsersForm1.Location = new System.Drawing.Point(216, 46);
            this.addUsersForm1.Name = "addUsersForm1";
            this.addUsersForm1.Size = new System.Drawing.Size(884, 554);
            this.addUsersForm1.TabIndex = 7;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(216, 46);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(884, 554);
            this.dashboardForm1.TabIndex = 8;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.addUsersForm1);
            this.Controls.Add(this.addProductForm1);
            this.Controls.Add(this.allCustomersForm1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label adminLogin_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adminLogin_closeBtn;
        private System.Windows.Forms.Button admin_logoutBtn;
        private System.Windows.Forms.Button adminLogin_customersBtn;
        private System.Windows.Forms.Button adminLogin_addProdBtn;
        private System.Windows.Forms.Button adminLogin_addUserBtn;
        private System.Windows.Forms.Button adminLogin_dashboardBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private AllCustomersForm allCustomersForm1;
        private AddProductForm addProductForm1;
        private AddUsersForm addUsersForm1;
        private DashboardForm dashboardForm1;
    }
}