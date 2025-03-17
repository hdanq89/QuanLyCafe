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
using QuanLyCafe.BLL;

namespace QuanLyCafe
{
    public partial class DashboardForm: UserControl
    {
        public DashboardForm()
        {
           InitializeComponent();
           DisplayTotalCashier();
            DisplayTotalCustomers();
            DisplayTodayIncome();
            DisplayMonthIncome();
        }


        #region Method
        DashboardDLL dashboard = new DashboardDLL();
        void DisplayTotalCashier()
        {
            lbl_countCashier.Text =  dashboard.allCashier().ToString();
        }

        void DisplayTotalCustomers()
        {
            lbl_countCus.Text = dashboard.allCustomer().ToString();
        }

        void DisplayTodayIncome()
        {
            lbl_todayIncome.Text = dashboard.todayIncome().ToString("0.00");
        }
        void DisplayMonthIncome()
        {
            lbl_monthIncome.Text = dashboard.monthIncome().ToString("0.00");
        }
        #endregion
    }
}
