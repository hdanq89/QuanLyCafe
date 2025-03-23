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
    public partial class CashierMainForm: Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        #region Method

        #endregion


        #region Events
        private void CashierMainForm_Load(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addProductForm1.Visible = false;
            orderForm1.Visible = false;
            allCustomersForm1.Visible = false;
            profileCashier1.Visible = false;
        }
        private void cashierLogin_dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addProductForm1.Visible = false;
            orderForm1.Visible = false;
            allCustomersForm1.Visible = false;
            profileCashier1.Visible = false;
        }

        private void cashierLogin_addUserBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = true;
            orderForm1.Visible = false;
            allCustomersForm1.Visible = false;
            profileCashier1.Visible = false;

        }

        private void cashierLogin_addProdBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = false;
            orderForm1.Visible = true;
            allCustomersForm1.Visible = false;
            profileCashier1.Visible = false;

        }


        private void cashierLogin_customersBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = false;
            orderForm1.Visible = false;
            allCustomersForm1.Visible = true;
            profileCashier1.Visible = false;
        }

        private void cashierLogin_profileBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addProductForm1.Visible = false;
            orderForm1.Visible = false;
            allCustomersForm1.Visible = false;
            profileCashier1.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cashier_logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();

                this.Hide();
            }
        }
        



        #endregion
    }
}
