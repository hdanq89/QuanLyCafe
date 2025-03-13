using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe
{
    public partial class AddUsersForm : UserControl
    {
        public AddUsersForm()
        {
            InitializeComponent();
            DisplayUser();
        }
        #region Method

        void DisplayUser()
        {
            dataGridView1.DataSource = AddUsersDAO.Instance.getAllUsers();

        }

        public bool emptyFields()
        {
            if (string.IsNullOrWhiteSpace(AddUsers_username.Text) || string.IsNullOrWhiteSpace(AddUsers_Pass.Text)
                || string.IsNullOrWhiteSpace(AddUsers_role.Text) || string.IsNullOrWhiteSpace(AddUsers_status.Text)
                || string.IsNullOrWhiteSpace(AddUsers_fullname.Text) || string.IsNullOrWhiteSpace(AddUsers_email.Text) || adminAddUsers_imgView.Image == null)
            {
                return true;
            }
            return false;
        }

        public void clear()
        {
            AddUsers_username.Text = "";
            AddUsers_Pass.Text = "";
            AddUsers_role.SelectedIndex = -1;
            AddUsers_status.SelectedIndex = -1;
            AddUsers_email.Text = "";
            AddUsers_fullname.Text = "";
            adminAddUsers_imgView.Image = null;


        }


        #endregion


        #region Events
        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.png; *.jpg)|*.png; *.jpg";
                string path = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    adminAddUsers_imgView.ImageLocation = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = AddUsers_username.Text.Trim();
                string email = AddUsers_email.Text.Trim();
                if (AddUsersDAO.Instance.checkUser(username))
                {
                    MessageBox.Show(username + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(AddUsersDAO.Instance.checkEmail(email))
                {
                    MessageBox.Show( "Email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
                else
                {
                    string pass = AddUsers_Pass.Text.Trim();
                    string fullname = AddUsers_fullname.Text.Trim();
                    string role = AddUsers_role.Text.Trim();
                    string status = AddUsers_status.Text.Trim();
                    string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    string User_Directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "User_Directory");
                    string path = Path.Combine(User_Directory, username + ".jpg");
                    string fileImgProfile = Path.GetFileName(path);
                    if (!Directory.Exists(User_Directory))
                    {
                        Directory.CreateDirectory(User_Directory);
                    }
                    if (AddUsersDAO.Instance.insertUser(username, pass, fullname, role, status, birthday, email, fileImgProfile))
                    {

                        File.Copy(adminAddUsers_imgView.ImageLocation, path, true);
                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayUser();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

        } 

        private void AddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = AddUsers_username.Text.Trim();
                DialogResult result = MessageBox.Show("Are you sure you want to Update Username: " +username + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string pass = AddUsers_Pass.Text.Trim();
                    string fullname = AddUsers_fullname.Text.Trim();
                    string role = AddUsers_role.Text.Trim();
                    string status = AddUsers_status.Text.Trim();
                    string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string email = AddUsers_email.Text.Trim();
                    string User_Directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "User_Directory");
                    string path = Path.Combine(User_Directory, username + ".jpg");
                    string fileImgView = Path.GetFileName(adminAddUsers_imgView.ImageLocation);
                    string fileImgProfile = Path.GetFileName(path);

                    if (!Directory.Exists(User_Directory))
                    {
                        Directory.CreateDirectory(User_Directory);
                    }
                    if (AddUsersDAO.Instance.updateUser(username, pass, fullname, role, status, birthday, email, id, fileImgProfile))
                    {
                        if(fileImgProfile != fileImgView)
                        {
                            File.Copy(adminAddUsers_imgView.ImageLocation, path, true);
                        }    
                        

                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayUser();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("update thất bại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            }
        }

        private void AddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string usern = row.Cells[0].Value.ToString();
                AddUsers_username.Text = row.Cells[0].Value.ToString();
                AddUsers_Pass.Text = row.Cells[1].Value.ToString();
                AddUsers_email.Text = row.Cells[2].Value.ToString();
                AddUsers_fullname.Text = row.Cells[3].Value.ToString();
                AddUsers_role.Text = row.Cells[4].Value.ToString();
                AddUsers_status.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value);


                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "User_Directory", usern + ".jpg");
                if (File.Exists(path))
                {
                    adminAddUsers_imgView.ImageLocation = path;
                }
                else
                {
                    adminAddUsers_imgView.ImageLocation = null;
                }

                string query = "select id from Employees where Username = @usern and statusDel = 0";
                object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { usern });
                id = (obj != null && obj != DBNull.Value) ? (int)obj : 0;
            }
        }

        private void AddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = AddUsers_username.Text.Trim();
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Username: " + username + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {                  
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativePath = Path.Combine("User_Directory", username + ".jpg");
                    string path = Path.Combine(baseDirectory, relativePath);
                    string directoryPath = Path.GetDirectoryName(path);

                   
                    if (AddUsersDAO.Instance.deleteUser(id))
                    {
                        if(File.Exists(path))
                        {
                            File.Delete(path);
                        }    

                        MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayUser();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Deleted thất bại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        #endregion


    }
}
