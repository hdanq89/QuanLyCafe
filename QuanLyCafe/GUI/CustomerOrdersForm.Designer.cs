namespace QuanLyCafe
{
    partial class CustomerOrdersForm
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
            this.adminLogin_close = new System.Windows.Forms.Label();
            this.lbl_cusInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLogin_close
            // 
            this.adminLogin_close.AutoSize = true;
            this.adminLogin_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogin_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_close.Location = new System.Drawing.Point(859, 9);
            this.adminLogin_close.Name = "adminLogin_close";
            this.adminLogin_close.Size = new System.Drawing.Size(18, 18);
            this.adminLogin_close.TabIndex = 5;
            this.adminLogin_close.Text = "X";
            this.adminLogin_close.Click += new System.EventHandler(this.adminLogin_close_Click);
            // 
            // lbl_cusInfo
            // 
            this.lbl_cusInfo.AutoSize = true;
            this.lbl_cusInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cusInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusInfo.Location = new System.Drawing.Point(12, 9);
            this.lbl_cusInfo.Name = "lbl_cusInfo";
            this.lbl_cusInfo.Size = new System.Drawing.Size(95, 18);
            this.lbl_cusInfo.TabIndex = 6;
            this.lbl_cusInfo.Text = "Customer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order List";
            // 
            // orderList
            // 
            this.orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Location = new System.Drawing.Point(25, 59);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(843, 159);
            this.orderList.TabIndex = 7;
            this.orderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderList_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "List of Invoice Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(843, 228);
            this.dataGridView2.TabIndex = 7;
            // 
            // CustomerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cusInfo);
            this.Controls.Add(this.adminLogin_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLogin_close;
        private System.Windows.Forms.Label lbl_cusInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}