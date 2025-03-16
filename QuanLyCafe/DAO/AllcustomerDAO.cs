using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class AllcustomerDAO
    {
        private static AllcustomerDAO instance;

        public static AllcustomerDAO Instance
        {
            get { if (instance == null) instance = new AllcustomerDAO(); return AllcustomerDAO.instance; }
            private set { AllcustomerDAO.instance = value; }
        }


        public List<AllCustomerDTO> getAllCus()
        {
            List<AllCustomerDTO> listUser = new List<AllCustomerDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select Fullname, Email, Phone, Address, TotalSpend AS TotalSpend from Customers ");
            foreach (DataRow item in data.Rows)
            {
                AllCustomerDTO info = new AllCustomerDTO(item);
                listUser.Add(info);
            }
            return listUser;
        }

        public int getIDCus(string email, string phone)
        {
            object data = DataProvider.Instance.ExecuteScalar($"select Customer_ID from Customers where Email= @email and phone= @phone ",new object[] {email,phone});

            int result = (data != null && data != DBNull.Value) ? Convert.ToInt32(data) : 0;

            return result;
        }
    }
}
