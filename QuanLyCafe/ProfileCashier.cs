using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class ProfileCashier : UserControl
    {

       
        public ProfileCashier()
        {
            InitializeComponent();
            
        }

        #region Events

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changPassForm = new ChangePasswordForm();
            changPassForm.ShowDialog();
        }
        #endregion

    }
}

