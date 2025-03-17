using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe.DAO
{
    public class CashiersDAO
    {
        private static CashiersDAO instance;

        public static CashiersDAO Instance
        {
            get { if (instance == null) instance = new CashiersDAO(); return CashiersDAO.instance; }
            private set { CashiersDAO.instance = value; }
        }

        private CashiersDAO() { }

        #region AddUser
        public List<CashiersDTO> getAllUsers()
        {
            List<CashiersDTO> listUser = new List<CashiersDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Cashiers where statusDel <> 1");

            foreach (DataRow item in data.Rows)
            {
                CashiersDTO info = new CashiersDTO(item);
                listUser.Add(info);
            }
            return listUser;
        }

        public int getIDUser(string usern)
        {
            string query = "select id from Cashiers where Username = @usern and statusDel = 0";
            object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { usern });
            int id = (obj != null && obj != DBNull.Value) ? (int)obj : 0;
            return id;
        }

        public bool checkUser(string username)
        {
            string selectUsern = "select * from Cashiers where Username = @user";

            DataTable result = DataProvider.Instance.ExecuteQuery(selectUsern, new object[] { username });

            return result.Rows.Count > 0;


        }

        public bool checkEmail(string email)
        {
            string selectEmail = "select * from Cashiers where Email = @email";

            DataTable result = DataProvider.Instance.ExecuteQuery(selectEmail, new object[] { email });

            return result.Rows.Count > 0;
        }

        public bool insertUser(string username, string pass, string fullname, string role, string status, string birthday, string email, string Profile_Image)
        {
            string insert = " INSERT INTO Cashiers (Username,Password,Fullname,Role,Status,BirthDate,Email,Profile_Image ) VALUES( @usern , @pass , @fullname , @role , @status , @date , @email , @Profile_Image )";

            int result = DataProvider.Instance.ExecuteNonQuery(insert, new object[] { username, pass, fullname, role, status, birthday, email, Profile_Image });

            return result > 0;
        }

        public bool updateUser(string username, string pass, string fullname, string role, string status, string birthday, string email, int id, string Profile_Image)
        {
            string query = "update Cashiers set Username= @usern ,Email= @email ,Password= @Password ,Fullname= @fname ,Role= @role ,Status= @status ,BirthDate= @date ,Profile_Image= @Profile_Image where ID= @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, email, pass, fullname, role, status, birthday, Profile_Image, id });
            return result > 0;
        }

        public bool deleteUser(int id)
        {
            string query = "update Cashiers set statusDel= 1 where ID= @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        #endregion

        #region Login
        public bool Login(string userName, string passWord)
        {
            string query = "select * from Cashiers where Username = N'" + userName + "' and Password = N'" + passWord + "' and Status = 'Active'";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);
            return results.Rows.Count > 0;

        }

        public string getRole(string userName, string passWord)
        {
            string query = "select * from Cashiers where Username = @usern and Password = @pass ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            CashiersDTO user = new CashiersDTO(data.Rows[0]);
            return user.Role;
        }
        #endregion

        #region Dashboard
        public int ToTalCashier()
        {
            string query = "select count(*) from Cashiers where role = 'Cashier' and status = 'Active'";
            object obj = DataProvider.Instance.ExecuteScalar(query);
            int result = (obj != null && obj != DBNull.Value) ? Convert.ToInt32(obj) : 0;
            return result;
        }
        #endregion
    }
}