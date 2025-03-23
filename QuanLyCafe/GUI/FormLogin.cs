using QuanLyCafe.BLL;
using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Method
        private bool checkEmpty()
        {
            if (string.IsNullOrWhiteSpace(login_userName.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Events
        private void login_loginBtn_Click(object sender, EventArgs e)
        {
            string userName = login_userName.Text;
            string passWord = login_password.Text;

            if (checkEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                LoginDLL login = new LoginDLL();
                if (login.checkLogin(userName, passWord))
                {
                    MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (login.role(userName, passWord) == "Admin")
                    {
                        AdminMainForm admin = new AdminMainForm();
                        admin.Show();
                        this.Hide();

                    }
                    else
                    {
                        CashierMainForm cashier = new CashierMainForm();
                        cashier.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản/Mật khẩu không chính xác.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dangnhap_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }
        #endregion


    }
}
