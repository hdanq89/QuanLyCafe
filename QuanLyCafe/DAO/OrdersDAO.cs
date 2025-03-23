using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class OrdersDAO
    {
        private static OrdersDAO instance;

        public static OrdersDAO Instance
        {
            get { if (instance == null) instance = new OrdersDAO(); return OrdersDAO.instance; }
            private set { OrdersDAO.instance = value; }
        }

        #region Dashboard
        public double TodayIncome()
        {
            DateTime today = DateTime.Today;
            string getToday = today.ToString("yyyy-MM-dd");
            string query = "select sum(Total)  from Orders where Create_date = @date";
            object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { getToday });
            double result = (obj != null && obj != DBNull.Value) ? Convert.ToDouble(obj) : 0;
            return result;
        }

        public double MonthIncome()
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            string query = "SELECT SUM(Total) FROM Orders WHERE Create_date BETWEEN @startDate AND @endDate";

            object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { firstDayOfMonth, lastDayOfMonth });

            double result = (obj != null && obj != DBNull.Value) ? Convert.ToDouble(obj) : 0;
            return result;
        }
        #endregion

        #region CustomerOder
        public List<OrdersDTO> getCustomerOrder(int id)
        {
            List<OrdersDTO> listOrder = new List<OrdersDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from Cashiers,Orders where id = @Cashier_ID and Customer_ID = @CusID ", new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                OrdersDTO info = new OrdersDTO(item);
                listOrder.Add(info);
            }
            return listOrder;
        }
        #endregion

        //public int insertOrder() 
    }
}
