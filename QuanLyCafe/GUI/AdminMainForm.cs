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
    public partial class AdminMainForm: Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        #region Method

        #endregion


        #region Events
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addProductForm1.Visible = false;
            addUsersForm1.Visible = false;
            allCustomersForm1.Visible = false;
        }
        private void adminLogin_dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addProductForm1.Visible = false;
            addUsersForm1.Visible = false;
            allCustomersForm1.Visible = false;
        }

        private void adminLogin_addUserBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = false;
            addUsersForm1.Visible = true;
            allCustomersForm1.Visible = false;
        }

        private void adminLogin_addProdBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = true;
            addUsersForm1.Visible = false;
            allCustomersForm1.Visible = false;
        }

        private void adminLogin_customersBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = false;
            addUsersForm1.Visible = false;
            allCustomersForm1.Visible = true;
        }

        private void adminLogin_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        #endregion

        private void admin_logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();

                this.Hide();
            }

        }
    }
}
