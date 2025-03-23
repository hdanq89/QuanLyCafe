namespace QuanLyCafe
{
    partial class AddUsersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminAddUsers_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddUsers_imgView = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddUsers_clearBtn = new System.Windows.Forms.Button();
            this.AddUsers_deleteBtn = new System.Windows.Forms.Button();
            this.AddUsers_updateBtn = new System.Windows.Forms.Button();
            this.AddUsers_addBtn = new System.Windows.Forms.Button();
            this.AddUsers_status = new System.Windows.Forms.ComboBox();
            this.AddUsers_role = new System.Windows.Forms.ComboBox();
            this.AddUsers_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUsers_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddUsers_fullname = new System.Windows.Forms.TextBox();
            this.AddUsers_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imgView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Users";
            // 
            // adminAddUsers_importBtn
            // 
            this.adminAddUsers_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.adminAddUsers_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUsers_importBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_importBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_importBtn.Location = new System.Drawing.Point(82, 117);
            this.adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            this.adminAddUsers_importBtn.Size = new System.Drawing.Size(97, 28);
            this.adminAddUsers_importBtn.TabIndex = 14;
            this.adminAddUsers_importBtn.Text = "Import";
            this.adminAddUsers_importBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_importBtn.Click += new System.EventHandler(this.adminAddUsers_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.adminAddUsers_imgView);
            this.panel3.Location = new System.Drawing.Point(82, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 13;
            // 
            // adminAddUsers_imgView
            // 
            this.adminAddUsers_imgView.Location = new System.Drawing.Point(0, 0);
            this.adminAddUsers_imgView.Name = "adminAddUsers_imgView";
            this.adminAddUsers_imgView.Size = new System.Drawing.Size(100, 100);
            this.adminAddUsers_imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddUsers_imgView.TabIndex = 0;
            this.adminAddUsers_imgView.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(289, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 519);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 476);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddUsers_clearBtn
            // 
            this.AddUsers_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddUsers_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUsers_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.AddUsers_clearBtn.Location = new System.Drawing.Point(148, 474);
            this.AddUsers_clearBtn.Name = "AddUsers_clearBtn";
            this.AddUsers_clearBtn.Size = new System.Drawing.Size(78, 32);
            this.AddUsers_clearBtn.TabIndex = 12;
            this.AddUsers_clearBtn.Text = "CLEAR";
            this.AddUsers_clearBtn.UseVisualStyleBackColor = false;
            this.AddUsers_clearBtn.Click += new System.EventHandler(this.AddUsers_clearBtn_Click);
            // 
            // AddUsers_deleteBtn
            // 
            this.AddUsers_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddUsers_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUsers_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.AddUsers_deleteBtn.Location = new System.Drawing.Point(42, 474);
            this.AddUsers_deleteBtn.Name = "AddUsers_deleteBtn";
            this.AddUsers_deleteBtn.Size = new System.Drawing.Size(78, 32);
            this.AddUsers_deleteBtn.TabIndex = 11;
            this.AddUsers_deleteBtn.Text = "DELETE";
            this.AddUsers_deleteBtn.UseVisualStyleBackColor = false;
            this.AddUsers_deleteBtn.Click += new System.EventHandler(this.AddUsers_deleteBtn_Click);
            // 
            // AddUsers_updateBtn
            // 
            this.AddUsers_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddUsers_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUsers_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.AddUsers_updateBtn.Location = new System.Drawing.Point(148, 430);
            this.AddUsers_updateBtn.Name = "AddUsers_updateBtn";
            this.AddUsers_updateBtn.Size = new System.Drawing.Size(78, 32);
            this.AddUsers_updateBtn.TabIndex = 10;
            this.AddUsers_updateBtn.Text = "UPDATE";
            this.AddUsers_updateBtn.UseVisualStyleBackColor = false;
            this.AddUsers_updateBtn.Click += new System.EventHandler(this.AddUsers_updateBtn_Click);
            // 
            // AddUsers_addBtn
            // 
            this.AddUsers_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddUsers_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUsers_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.AddUsers_addBtn.Location = new System.Drawing.Point(42, 430);
            this.AddUsers_addBtn.Name = "AddUsers_addBtn";
            this.AddUsers_addBtn.Size = new System.Drawing.Size(78, 32);
            this.AddUsers_addBtn.TabIndex = 9;
            this.AddUsers_addBtn.Text = "ADD";
            this.AddUsers_addBtn.UseVisualStyleBackColor = false;
            this.AddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // AddUsers_status
            // 
            this.AddUsers_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddUsers_status.FormattingEnabled = true;
            this.AddUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddUsers_status.Location = new System.Drawing.Point(106, 283);
            this.AddUsers_status.Name = "AddUsers_status";
            this.AddUsers_status.Size = new System.Drawing.Size(143, 21);
            this.AddUsers_status.TabIndex = 8;
            // 
            // AddUsers_role
            // 
            this.AddUsers_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddUsers_role.FormattingEnabled = true;
            this.AddUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.AddUsers_role.Location = new System.Drawing.Point(106, 240);
            this.AddUsers_role.Name = "AddUsers_role";
            this.AddUsers_role.Size = new System.Drawing.Size(143, 21);
            this.AddUsers_role.TabIndex = 7;
            // 
            // AddUsers_Pass
            // 
            this.AddUsers_Pass.Location = new System.Drawing.Point(106, 203);
            this.AddUsers_Pass.Name = "AddUsers_Pass";
            this.AddUsers_Pass.Size = new System.Drawing.Size(143, 20);
            this.AddUsers_Pass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // AddUsers_username
            // 
            this.AddUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers_username.Location = new System.Drawing.Point(106, 165);
            this.AddUsers_username.Name = "AddUsers_username";
            this.AddUsers_username.Size = new System.Drawing.Size(143, 20);
            this.AddUsers_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.adminAddUsers_importBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AddUsers_clearBtn);
            this.panel1.Controls.Add(this.AddUsers_deleteBtn);
            this.panel1.Controls.Add(this.AddUsers_updateBtn);
            this.panel1.Controls.Add(this.AddUsers_addBtn);
            this.panel1.Controls.Add(this.AddUsers_status);
            this.panel1.Controls.Add(this.AddUsers_role);
            this.panel1.Controls.Add(this.AddUsers_fullname);
            this.panel1.Controls.Add(this.AddUsers_email);
            this.panel1.Controls.Add(this.BirthDay);
            this.panel1.Controls.Add(this.AddUsers_Pass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddUsers_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 519);
            this.panel1.TabIndex = 3;
            // 
            // AddUsers_fullname
            // 
            this.AddUsers_fullname.Location = new System.Drawing.Point(106, 356);
            this.AddUsers_fullname.Name = "AddUsers_fullname";
            this.AddUsers_fullname.Size = new System.Drawing.Size(143, 20);
            this.AddUsers_fullname.TabIndex = 6;
            // 
            // AddUsers_email
            // 
            this.AddUsers_email.Location = new System.Drawing.Point(106, 319);
            this.AddUsers_email.Name = "AddUsers_email";
            this.AddUsers_email.Size = new System.Drawing.Size(143, 20);
            this.AddUsers_email.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "FullName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay.Location = new System.Drawing.Point(19, 395);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(77, 17);
            this.BirthDay.TabIndex = 3;
            this.BirthDay.Text = "BirthDay:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 392);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUsersForm";
            this.Size = new System.Drawing.Size(892, 540);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminAddUsers_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox adminAddUsers_imgView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddUsers_clearBtn;
        private System.Windows.Forms.Button AddUsers_deleteBtn;
        private System.Windows.Forms.Button AddUsers_updateBtn;
        private System.Windows.Forms.Button AddUsers_addBtn;
        private System.Windows.Forms.ComboBox AddUsers_status;
        private System.Windows.Forms.ComboBox AddUsers_role;
        private System.Windows.Forms.TextBox AddUsers_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddUsers_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddUsers_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddUsers_fullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label BirthDay;
    }
}
