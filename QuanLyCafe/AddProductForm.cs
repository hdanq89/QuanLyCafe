using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System.Xml.Linq;

namespace QuanLyCafe
{
    public partial class AddProductForm: UserControl
    {
        public AddProductForm()
        {
            InitializeComponent();
            displayListProduct();
        }

        #region Method

        public bool emptyFields()
        {
            if (string.IsNullOrWhiteSpace(adminAddProducts_name.Text) || string.IsNullOrWhiteSpace(adminAddProducts_type.Text)
                || string.IsNullOrWhiteSpace(adminAddProducts_stock.Text) || string.IsNullOrWhiteSpace(adminAddProducts_status.Text)
                || string.IsNullOrWhiteSpace(adminAddProducts_price.Text) || adminAddProducts_imgView.Image == null)
            {
                return true;
            }
            return false;
        }

        void displayListProduct()
        {
            dataGridView1.DataSource =  AddProductsDAO.Instance.getListProduct();
        }
        #endregion


        #region Events
        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Files Image (*.png;*.jpg)|*.png;*.jpg";
                string path = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    adminAddProducts_imgView.ImageLocation = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if(emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = adminAddProducts_name.Text;

                string selectedValue = adminAddProducts_type.SelectedItem.ToString();
                int type = selectedValue == "Cà phê hạt" ? 1 :
                           selectedValue == "Cà phê pha máy" ? 2 :
                           selectedValue == "Phin cà phê" ? 3 :
                           selectedValue == "Cà phê rang xay" ? 4 :
                           selectedValue == "Phụ kiện pha chế" ? 5 : 0;
                string status = adminAddProducts_status.SelectedItem.ToString();
                int stock = Convert.ToInt32( adminAddProducts_stock.Text);
                string des = adminAddProducts_Description.Text;
                float price = (float)Convert.ToDouble(adminAddProducts_price.Text);
                if(AddProductsDAO.Instance.insertProduct(name, stock, price, type, "", status, des))
                {
                    MessageBox.Show("hehe");
                }    
            }
        }


        #endregion
    }
}
