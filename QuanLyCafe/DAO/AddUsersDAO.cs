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
    public class AddUsersDAO
    {
        private static AddUsersDAO instance;

        public static AddUsersDAO Instance
        {
            get { if (instance == null) instance = new AddUsersDAO(); return AddUsersDAO.instance; }
            private set { AddUsersDAO.instance = value; }
        }

        private AddUsersDAO() { }

        public List<AddUsersDTO> getAllUsers()
        {
            List<AddUsersDTO> listUser = new List<AddUsersDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Employees where statusDel <> 1");

            foreach(DataRow item in data.Rows)
            {
                AddUsersDTO info = new AddUsersDTO(item);
                listUser.Add(info);
            }    
            return listUser;
        }

        public bool checkUser(string username)
        {
            string selectUsern = "select * from Employees where Username = @user";

            DataTable result = DataProvider.Instance.ExecuteQuery(selectUsern, new object[] { username });

            return result.Rows.Count > 0;
            
                
        }

        public bool checkEmail(string email)
        {
            string selectEmail = "select * from Employees where Email = @email";

            DataTable result = DataProvider.Instance.ExecuteQuery(selectEmail, new object[] { email });

            return result.Rows.Count > 0;
        }

        public bool insertUser(string username, string pass, string fullname, string role,string status, string birthday,string email,string Profile_Image)
        {
            string insert = " INSERT INTO Employees (Username,Password,Fullname,Role,Status,BirthDate,Email,Profile_Image ) VALUES( @usern , @pass , @fullname , @role , @status , @date , @email , @Profile_Image )";

            int result = DataProvider.Instance.ExecuteNonQuery(insert, new object[] { username, pass, fullname, role, status, birthday , email, Profile_Image });

            return result > 0;
        }

        public bool updateUser(string username, string pass, string fullname, string role, string status, string birthday, string email,int id,string Profile_Image)
        {
            string query = "update Employees set Username= @usern ,Email= @email ,Password= @Password ,Fullname= @fname ,Role= @role ,Status= @status ,BirthDate= @date ,Profile_Image= @Profile_Image where ID= @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, email, pass, fullname, role, status, birthday, Profile_Image,id });
            return result > 0;
        }

        public bool deleteUser(int id)
        {
            string query = "update Employees set statusDel= 1 where ID= @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}