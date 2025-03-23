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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using QuanLyCafe.BLL;

namespace QuanLyCafe
{
    public partial class AddProductForm: UserControl
    {
        AddProductDLL addProduct = new AddProductDLL();
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
            dataGridView1.DataSource =  addProduct.getListProduct();
        }

        void clear()
        {
            adminAddProducts_name.Text = "";
            adminAddProducts_stock.Text = "";
            adminAddProducts_price.Text = "";
            adminAddProducts_Description.Text = "";
            adminAddProducts_status.SelectedIndex = -1;
            adminAddProducts_type.SelectedIndex = -1;
            adminAddProducts_imgView.Image = null;
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
                           selectedValue == "Cà phê pha máy" ? 3 :
                           selectedValue == "Phin cà phê" ? 4 :
                           selectedValue == "Cà phê rang xay" ? 2:
                           selectedValue == "Phụ kiện pha chế" ? 5 : 0;
                string status = adminAddProducts_status.SelectedItem.ToString();
                int stock = Convert.ToInt32( adminAddProducts_stock.Text);
                string des = adminAddProducts_Description.Text;
                float price = (float)Convert.ToDouble(adminAddProducts_price.Text);
                string Product_Directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Product_Directory");
                string path = Path.Combine(Product_Directory, name + ".jpg");
                string fileImgView = Path.GetFileName(adminAddProducts_imgView.ImageLocation);
                string fileImgProfile = Path.GetFileName(path);
                if (!Directory.Exists(Product_Directory))
                {
                    Directory.CreateDirectory(Product_Directory);
                }
                if (addProduct.insertProduct(name, stock, price, type, fileImgProfile, status, des))
                {
                    if (fileImgView != fileImgProfile)
                    {
                        File.Copy(adminAddProducts_imgView.ImageLocation, path, true);
                    }
                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    displayListProduct();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                adminAddProducts_name.Text = row.Cells[0].Value.ToString();
                adminAddProducts_type.Text = row.Cells[3].Value.ToString();
                adminAddProducts_price.Text = row.Cells[2].Value.ToString();              
                adminAddProducts_Description.Text = row.Cells[4].Value.ToString();
                adminAddProducts_status.Text = row.Cells[5].Value.ToString();
                adminAddProducts_stock.Text = row.Cells[1].Value.ToString();

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Product_Directory",name + ".jpg");
                if(File.Exists(path))
                {
                    adminAddProducts_imgView.ImageLocation = path;
                }
                else
                {
                    adminAddProducts_imgView.ImageLocation = null;

                }
                id = addProduct.getIDProd(name);
            }
        }

        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string name = adminAddProducts_name.Text;
                DialogResult result = MessageBox.Show("Are you sure you want to Update Username: " + name + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedValue = adminAddProducts_type.SelectedItem.ToString();
                    int type = selectedValue == "Cà phê hạt" ? 1 :
                               selectedValue == "Cà phê pha máy" ? 2 :
                               selectedValue == "Phin cà phê" ? 3 :
                               selectedValue == "Cà phê rang xay" ? 4 :
                               selectedValue == "Phụ kiện pha chế" ? 5 : 0;
                    string status = adminAddProducts_status.SelectedItem.ToString();
                    int stock = Convert.ToInt32(adminAddProducts_stock.Text);
                    string des = adminAddProducts_Description.Text;
                    float price = (float)Convert.ToDouble(adminAddProducts_price.Text);
                    string Product_Directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Product_Directory");
                    string path = Path.Combine(Product_Directory, name + ".jpg");
                    string fileImgView = Path.GetFileName(adminAddProducts_imgView.ImageLocation);
                    string fileImgProfile = Path.GetFileName(path);
                    if (!Directory.Exists(Product_Directory))
                    {
                        Directory.CreateDirectory(Product_Directory);
                    }
                    if (addProduct.updateProduct(name, stock, price, type, fileImgProfile, status, des,id))
                    {
                        if(fileImgView != fileImgProfile)
                        {
                            File.Copy(adminAddProducts_imgView.ImageLocation, path, true);
                        }
                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        displayListProduct();
                    }
                    else
                    {
                        MessageBox.Show("Updated Error!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string name = adminAddProducts_name.Text;
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Username: " + name + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {                  
                    if (addProduct.deleteProduct( id))
                    {
                        
                        MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        displayListProduct();
                    }
                    else
                    {
                        MessageBox.Show("Deleted Error!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    #endregion


}
