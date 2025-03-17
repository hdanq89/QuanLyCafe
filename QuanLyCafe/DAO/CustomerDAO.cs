using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }


        #region AllCustomer
        public List<CustomersDTO> getAllCus()
        {
            List<CustomersDTO> listUser = new List<CustomersDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select Fullname, Email, Phone, Address, TotalSpend from Customers ");
            foreach (DataRow item in data.Rows)
            {
                CustomersDTO info = new CustomersDTO(item);
                listUser.Add(info);
            }
            return listUser;
        }

        public int getIDCus(string email, string phone)
        {
            object data = DataProvider.Instance.ExecuteScalar($"select Customer_ID from Customers where Email= @email and phone= @phone ", new object[] { email, phone });

            int result = (data != null && data != DBNull.Value) ? Convert.ToInt32(data) : 0;

            return result;
        }
        #endregion

        #region Dashboard 
        public int TotalCustomer()
        {
            string query = "select count(*) from Customers";
            object obj = DataProvider.Instance.ExecuteScalar(query);
            int result = (obj != null && obj != DBNull.Value) ? Convert.ToInt32(obj) : 0;
            return result;
        }
        #endregion
    }
}
