﻿using System;
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
    public partial class ChangePasswordForm: Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btn_exitPass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
