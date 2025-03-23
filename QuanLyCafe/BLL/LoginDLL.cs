using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.BLL
{
    public class LoginDLL
    {
        public bool checkLogin(string userName, string passWord)
        {
            int id = CashiersDAO.Instance.Login(userName, passWord);
            if (id > 0) // Nếu tìm thấy tài khoản hợp lệ
            {
                Properties.Settings.Default.ID = id;
                Properties.Settings.Default.Save(); // Lưu lại Settings
                return true;
            }
            return false;
        }

        public string role(string userName, string passWord)
        {
           return  CashiersDAO.Instance.getRole(userName, passWord);
           
        }
    }
}
