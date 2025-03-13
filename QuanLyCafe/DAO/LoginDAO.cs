using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance; // Ctrl + R + E

        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return LoginDAO.instance; }
            private set { LoginDAO.instance = value; }
        }

        public bool Login(string userName, string passWord)
        {
            string query = "select * from Employees where Username = N'" + userName + "' and Password = N'" + passWord + "' and Status = 'Active'";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);
            return results.Rows.Count > 0;
            
        }

        public string getRole(string userName, string passWord)
        {
            string query = "select * from Employees where Username = @usern and Password = @pass ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,passWord});
            AddUsersDTO user = new AddUsersDTO(data.Rows[0]);
            return user.Role;        
        }
    }
}
