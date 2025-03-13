namespace QuanLyCafe
{
    partial class OrderForm
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
            this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_addBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrderForm_quantily = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrderForm_productName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_payBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_change = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierOrderForm_orderTable
            // 
            this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(14, 30);
            this.cashierOrderForm_orderTable.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            this.cashierOrderForm_orderTable.RowHeadersWidth = 51;
            this.cashierOrderForm_orderTable.RowTemplate.Height = 24;
            this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(571, 204);
            this.cashierOrderForm_orderTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrderForm_orderTable);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 245);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(392, 182);
            this.cashierOrderForm_clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(137, 28);
            this.cashierOrderForm_clearBtn.TabIndex = 15;
            this.cashierOrderForm_clearBtn.Text = "CLEAR";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrderForm_quantily);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrderForm_productName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrderForm_productID);
            this.panel2.Controls.Add(this.cashierOrderForm_type);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 275);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 254);
            this.panel2.TabIndex = 7;
            // 
            // cashierOrderForm_removeBtn
            // 
            this.cashierOrderForm_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(209, 182);
            this.cashierOrderForm_removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(137, 28);
            this.cashierOrderForm_removeBtn.TabIndex = 14;
            this.cashierOrderForm_removeBtn.Text = "REMOVE";
            this.cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_addBtn
            // 
            this.cashierOrderForm_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cashierOrderForm_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(32, 182);
            this.cashierOrderForm_addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(137, 28);
            this.cashierOrderForm_addBtn.TabIndex = 13;
            this.cashierOrderForm_addBtn.Text = "ADD";
            this.cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.Location = new System.Drawing.Point(97, 124);
            this.cashierOrderForm_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(35, 17);
            this.cashierOrderForm_price.TabIndex = 12;
            this.cashierOrderForm_price.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price ($):";
            // 
            // cashierOrderForm_quantily
            // 
            this.cashierOrderForm_quantily.Location = new System.Drawing.Point(364, 75);
            this.cashierOrderForm_quantily.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_quantily.Name = "cashierOrderForm_quantily";
            this.cashierOrderForm_quantily.Size = new System.Drawing.Size(122, 19);
            this.cashierOrderForm_quantily.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantily:";
            // 
            // cashierOrderForm_productName
            // 
            this.cashierOrderForm_productName.AutoSize = true;
            this.cashierOrderForm_productName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_productName.Location = new System.Drawing.Point(139, 77);
            this.cashierOrderForm_productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrderForm_productName.Name = "cashierOrderForm_productName";
            this.cashierOrderForm_productName.Size = new System.Drawing.Size(101, 17);
            this.cashierOrderForm_productName.TabIndex = 7;
            this.cashierOrderForm_productName.Text = "Test Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product ID:";
            // 
            // cashierOrderForm_productID
            // 
            this.cashierOrderForm_productID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cashierOrderForm_productID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_productID.FormattingEnabled = true;
            this.cashierOrderForm_productID.Location = new System.Drawing.Point(364, 34);
            this.cashierOrderForm_productID.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            this.cashierOrderForm_productID.Size = new System.Drawing.Size(144, 20);
            this.cashierOrderForm_productID.TabIndex = 4;
            // 
            // cashierOrderForm_type
            // 
            this.cashierOrderForm_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cashierOrderForm_type.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_type.FormattingEnabled = true;
            this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Meal",
            "Drink"});
            this.cashierOrderForm_type.Location = new System.Drawing.Point(70, 31);
            this.cashierOrderForm_type.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_type.Name = "cashierOrderForm_type";
            this.cashierOrderForm_type.Size = new System.Drawing.Size(138, 20);
            this.cashierOrderForm_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // cashierOrderForm_orderPrice
            // 
            this.cashierOrderForm_orderPrice.AutoSize = true;
            this.cashierOrderForm_orderPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(119, 274);
            this.cashierOrderForm_orderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(35, 17);
            this.cashierOrderForm_orderPrice.TabIndex = 13;
            this.cashierOrderForm_orderPrice.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price ($):";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(218, 204);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_change);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cashierOrderForm_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(635, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 517);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Invoice";
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(43, 445);
            this.cashierOrderForm_receiptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(167, 28);
            this.cashierOrderForm_receiptBtn.TabIndex = 19;
            this.cashierOrderForm_receiptBtn.Text = "RECEIPT";
            this.cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_payBtn
            // 
            this.cashierOrderForm_payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_payBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(43, 403);
            this.cashierOrderForm_payBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(167, 28);
            this.cashierOrderForm_payBtn.TabIndex = 18;
            this.cashierOrderForm_payBtn.Text = "PAY";
            this.cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_change
            // 
            this.cashierOrderForm_change.AutoSize = true;
            this.cashierOrderForm_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_change.Location = new System.Drawing.Point(120, 345);
            this.cashierOrderForm_change.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrderForm_change.Name = "cashierOrderForm_change";
            this.cashierOrderForm_change.Size = new System.Drawing.Size(17, 17);
            this.cashierOrderForm_change.TabIndex = 17;
            this.cashierOrderForm_change.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 345);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Change ($):";
            // 
            // cashierOrderForm_amount
            // 
            this.cashierOrderForm_amount.Location = new System.Drawing.Point(120, 311);
            this.cashierOrderForm_amount.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            this.cashierOrderForm_amount.Size = new System.Drawing.Size(99, 20);
            this.cashierOrderForm_amount.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount ($):";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "OrderForm";
            this.Size = new System.Drawing.Size(892, 540);
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cashierOrderForm_removeBtn;
        private System.Windows.Forms.Button cashierOrderForm_addBtn;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantily;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cashierOrderForm_productName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Windows.Forms.Button cashierOrderForm_payBtn;
        private System.Windows.Forms.Label cashierOrderForm_change;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label11;
    }
}
