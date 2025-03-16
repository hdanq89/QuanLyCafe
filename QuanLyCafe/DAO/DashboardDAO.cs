using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class DashboardDAO
    {
		private DashboardDAO() { }

        private static DashboardDAO instance;		

		public static DashboardDAO Instance
        {
			get { if (instance == null) instance = new DashboardDAO(); return DashboardDAO.instance; }
            private set {  DashboardDAO.instance = value; }
		}


        public int ToTalCashier()
        {
            string query = "select count(*) from Employees where role = 'Cashier' and status = 'Active'";
            object obj =  DataProvider.Instance.ExecuteScalar(query);
            int result = (obj != null && obj != DBNull.Value) ? Convert.ToInt32(obj) : 0;
            return result;
        }

        public int TotalCustomer()
        {
            string query = "select count(*) from Customers";
            object obj = DataProvider.Instance.ExecuteScalar(query);
            int result = (obj!=null && obj != DBNull.Value) ? Convert.ToInt32(obj) : 0;
            return result;
        }

        public float TodayIncome()
        {
            DateTime today = DateTime.Today;
            string getToday = today.ToString("yyyy-MM-dd");
            string query = "select sum(Total)  from Orders where Create_date = @date" ;
            object obj = DataProvider.Instance.ExecuteScalar(query,new object[] { getToday }) ;
            float result = (obj != null && obj != DBNull.Value) ? (float)Convert.ToDouble(obj) : 0;
            return result;
        }

        public float MonthIncome()
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            string query = "SELECT SUM(Total) FROM Orders WHERE Create_date BETWEEN @startDate AND @endDate";

            object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { firstDayOfMonth, lastDayOfMonth });

            float result = (obj != null && obj != DBNull.Value) ? Convert.ToSingle(obj) : 0;
            return result;
        }
	}
}
