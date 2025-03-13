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
        void DisplayTotalCashier()
        {
            lbl_countCashier.Text =  DashboardDAO.Instance.ToTalCashier().ToString();
        }

        void DisplayTotalCustomers()
        {
            lbl_countCus.Text = DashboardDAO.Instance.TotalCustomer().ToString();
        }

        void DisplayTodayIncome()
        {
            lbl_todayIncome.Text = DashboardDAO.Instance.TodayIncome().ToString("0.00");
        }
        void DisplayMonthIncome()
        {
            lbl_monthIncome.Text = DashboardDAO.Instance.MonthIncome().ToString("0.00");
        }
        #endregion
    }
}
