namespace QuanLyCafe
{
    partial class CashierMainForm
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
            this.closeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierLogin_closeBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashier_logoutBtn = new System.Windows.Forms.Button();
            this.cashierLogin_customersBtn = new System.Windows.Forms.Button();
            this.cashierLogin_addProdBtn = new System.Windows.Forms.Button();
            this.cashierLogin_addUserBtn = new System.Windows.Forms.Button();
            this.cashierLogin_dashboardBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardForm1 = new QuanLyCafe.DashboardForm();
            this.addProductForm1 = new QuanLyCafe.AddProductForm();
            this.orderForm1 = new QuanLyCafe.OrderForm();
            this.allCustomersForm1 = new QuanLyCafe.AllCustomersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierLogin_closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 46);
            this.panel1.TabIndex = 4;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(854, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cafe Shop Management System";
            // 
            // cashierLogin_closeBtn
            // 
            this.cashierLogin_closeBtn.AutoSize = true;
            this.cashierLogin_closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierLogin_closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogin_closeBtn.Location = new System.Drawing.Point(1070, 9);
            this.cashierLogin_closeBtn.Name = "cashierLogin_closeBtn";
            this.cashierLogin_closeBtn.Size = new System.Drawing.Size(18, 18);
            this.cashierLogin_closeBtn.TabIndex = 2;
            this.cashierLogin_closeBtn.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.cashier_logoutBtn);
            this.panel2.Controls.Add(this.cashierLogin_customersBtn);
            this.panel2.Controls.Add(this.cashierLogin_addProdBtn);
            this.panel2.Controls.Add(this.cashierLogin_addUserBtn);
            this.panel2.Controls.Add(this.cashierLogin_dashboardBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 600);
            this.panel2.TabIndex = 5;
            // 
            // cashier_logoutBtn
            // 
            this.cashier_logoutBtn.AllowDrop = true;
            this.cashier_logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashier_logoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_logoutBtn.ForeColor = System.Drawing.Color.White;
            this.cashier_logoutBtn.Location = new System.Drawing.Point(18, 504);
            this.cashier_logoutBtn.Name = "cashier_logoutBtn";
            this.cashier_logoutBtn.Size = new System.Drawing.Size(176, 38);
            this.cashier_logoutBtn.TabIndex = 15;
            this.cashier_logoutBtn.Text = "Logout";
            this.cashier_logoutBtn.UseVisualStyleBackColor = true;
            this.cashier_logoutBtn.Click += new System.EventHandler(this.cashier_logoutBtn_Click);
            // 
            // cashierLogin_customersBtn
            // 
            this.cashierLogin_customersBtn.AllowDrop = true;
            this.cashierLogin_customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierLogin_customersBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogin_customersBtn.ForeColor = System.Drawing.Color.White;
            this.cashierLogin_customersBtn.Location = new System.Drawing.Point(18, 397);
            this.cashierLogin_customersBtn.Name = "cashierLogin_customersBtn";
            this.cashierLogin_customersBtn.Size = new System.Drawing.Size(176, 38);
            this.cashierLogin_customersBtn.TabIndex = 14;
            this.cashierLogin_customersBtn.Text = "Customers";
            this.cashierLogin_customersBtn.UseVisualStyleBackColor = true;
            this.cashierLogin_customersBtn.Click += new System.EventHandler(this.cashierLogin_customersBtn_Click);
            // 
            // cashierLogin_addProdBtn
            // 
            this.cashierLogin_addProdBtn.AllowDrop = true;
            this.cashierLogin_addProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierLogin_addProdBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogin_addProdBtn.ForeColor = System.Drawing.Color.White;
            this.cashierLogin_addProdBtn.Location = new System.Drawing.Point(18, 343);
            this.cashierLogin_addProdBtn.Name = "cashierLogin_addProdBtn";
            this.cashierLogin_addProdBtn.Size = new System.Drawing.Size(176, 38);
            this.cashierLogin_addProdBtn.TabIndex = 13;
            this.cashierLogin_addProdBtn.Text = "Order";
            this.cashierLogin_addProdBtn.UseVisualStyleBackColor = true;
            this.cashierLogin_addProdBtn.Click += new System.EventHandler(this.cashierLogin_addProdBtn_Click);
            // 
            // cashierLogin_addUserBtn
            // 
            this.cashierLogin_addUserBtn.AllowDrop = true;
            this.cashierLogin_addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierLogin_addUserBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogin_addUserBtn.ForeColor = System.Drawing.Color.White;
            this.cashierLogin_addUserBtn.Location = new System.Drawing.Point(18, 288);
            this.cashierLogin_addUserBtn.Name = "cashierLogin_addUserBtn";
            this.cashierLogin_addUserBtn.Size = new System.Drawing.Size(176, 38);
            this.cashierLogin_addUserBtn.TabIndex = 14;
            this.cashierLogin_addUserBtn.Text = "Products";
            this.cashierLogin_addUserBtn.UseVisualStyleBackColor = true;
            this.cashierLogin_addUserBtn.Click += new System.EventHandler(this.cashierLogin_addUserBtn_Click);
            // 
            // cashierLogin_dashboardBtn
            // 
            this.cashierLogin_dashboardBtn.AllowDrop = true;
            this.cashierLogin_dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierLogin_dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogin_dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.cashierLogin_dashboardBtn.Location = new System.Drawing.Point(18, 234);
            this.cashierLogin_dashboardBtn.Name = "cashierLogin_dashboardBtn";
            this.cashierLogin_dashboardBtn.Size = new System.Drawing.Size(176, 38);
            this.cashierLogin_dashboardBtn.TabIndex = 13;
            this.cashierLogin_dashboardBtn.Text = "Dashboard";
            this.cashierLogin_dashboardBtn.UseVisualStyleBackColor = true;
            this.cashierLogin_dashboardBtn.Click += new System.EventHandler(this.cashierLogin_dashboardBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 184);
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
            this.label3.Location = new System.Drawing.Point(15, 184);
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
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cashier\'s Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCafe.Properties.Resources.Cafe_2;
            this.pictureBox1.Location = new System.Drawing.Point(50, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(216, 46);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(884, 554);
            this.dashboardForm1.TabIndex = 9;
            // 
            // addProductForm1
            // 
            this.addProductForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductForm1.Location = new System.Drawing.Point(216, 46);
            this.addProductForm1.Name = "addProductForm1";
            this.addProductForm1.Size = new System.Drawing.Size(884, 554);
            this.addProductForm1.TabIndex = 8;
            // 
            // orderForm1
            // 
            this.orderForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderForm1.Location = new System.Drawing.Point(216, 46);
            this.orderForm1.Name = "orderForm1";
            this.orderForm1.Size = new System.Drawing.Size(884, 554);
            this.orderForm1.TabIndex = 7;
            // 
            // allCustomersForm1
            // 
            this.allCustomersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCustomersForm1.Location = new System.Drawing.Point(216, 46);
            this.allCustomersForm1.Name = "allCustomersForm1";
            this.allCustomersForm1.Size = new System.Drawing.Size(884, 554);
            this.allCustomersForm1.TabIndex = 6;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.addProductForm1);
            this.Controls.Add(this.orderForm1);
            this.Controls.Add(this.allCustomersForm1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.Load += new System.EventHandler(this.CashierMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierLogin_closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cashier_logoutBtn;
        private System.Windows.Forms.Button cashierLogin_customersBtn;
        private System.Windows.Forms.Button cashierLogin_addProdBtn;
        private System.Windows.Forms.Button cashierLogin_addUserBtn;
        private System.Windows.Forms.Button cashierLogin_dashboardBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeBtn;
        private AllCustomersForm allCustomersForm1;
        private OrderForm orderForm1;
        private AddProductForm addProductForm1;
        private DashboardForm dashboardForm1;
    }
}