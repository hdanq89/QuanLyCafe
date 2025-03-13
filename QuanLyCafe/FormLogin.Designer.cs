namespace QuanLyCafe
{
    partial class FormLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.login_loginBtn = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dangnhap_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 484);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCafe.Properties.Resources.Cafe_2;
            this.pictureBox1.Location = new System.Drawing.Point(108, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cafe Shop Management System";
            // 
            // login_loginBtn
            // 
            this.login_loginBtn.AutoSize = true;
            this.login_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.login_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_loginBtn.ForeColor = System.Drawing.Color.White;
            this.login_loginBtn.Location = new System.Drawing.Point(379, 344);
            this.login_loginBtn.Name = "login_loginBtn";
            this.login_loginBtn.Size = new System.Drawing.Size(122, 33);
            this.login_loginBtn.TabIndex = 12;
            this.login_loginBtn.Text = "LOGIN";
            this.login_loginBtn.UseVisualStyleBackColor = false;
            this.login_loginBtn.Click += new System.EventHandler(this.login_loginBtn_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.Location = new System.Drawing.Point(380, 303);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(136, 22);
            this.login_showPass.TabIndex = 11;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(380, 258);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(252, 26);
            this.login_password.TabIndex = 10;
            this.login_password.Text = "123456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // login_userName
            // 
            this.login_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_userName.Location = new System.Drawing.Point(380, 181);
            this.login_userName.Name = "login_userName";
            this.login_userName.Size = new System.Drawing.Size(252, 26);
            this.login_userName.TabIndex = 9;
            this.login_userName.Text = "admin01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "SIGN IN";
            // 
            // dangnhap_close
            // 
            this.dangnhap_close.AutoSize = true;
            this.dangnhap_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangnhap_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_close.Location = new System.Drawing.Point(651, 9);
            this.dangnhap_close.Name = "dangnhap_close";
            this.dangnhap_close.Size = new System.Drawing.Size(20, 20);
            this.dangnhap_close.TabIndex = 13;
            this.dangnhap_close.Text = "X";
            this.dangnhap_close.Click += new System.EventHandler(this.dangnhap_close_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.login_loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_loginBtn);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dangnhap_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button login_loginBtn;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dangnhap_close;
    }
}

