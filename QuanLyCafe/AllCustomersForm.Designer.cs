namespace QuanLyCafe
{
    partial class AllCustomersForm
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
            this.allCustomers_dataTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomers_dataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allCustomers_dataTable
            // 
            this.allCustomers_dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCustomers_dataTable.Location = new System.Drawing.Point(16, 37);
            this.allCustomers_dataTable.Margin = new System.Windows.Forms.Padding(2);
            this.allCustomers_dataTable.Name = "allCustomers_dataTable";
            this.allCustomers_dataTable.RowHeadersWidth = 51;
            this.allCustomers_dataTable.RowTemplate.Height = 24;
            this.allCustomers_dataTable.Size = new System.Drawing.Size(841, 475);
            this.allCustomers_dataTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.allCustomers_dataTable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 526);
            this.panel1.TabIndex = 2;
            // 
            // AllCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AllCustomersForm";
            this.Size = new System.Drawing.Size(892, 540);
            ((System.ComponentModel.ISupportInitialize)(this.allCustomers_dataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allCustomers_dataTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
