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
           if( CashiersDAO.Instance.Login(userName, passWord))
            {
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
