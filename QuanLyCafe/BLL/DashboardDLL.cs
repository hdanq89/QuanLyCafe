using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.BLL
{
    public class DashboardDLL
    {
        public int allCashier()
        {
          return  CashiersDAO.Instance.ToTalCashier();
        }

        public int allCustomer()
        {
            return CustomerDAO.Instance.TotalCustomer();
        }

        public double todayIncome()
        {
            return OrdersDAO.Instance.TodayIncome();
        }


        public double monthIncome()
        {
            return OrdersDAO.Instance.MonthIncome();
        }
    }
}
