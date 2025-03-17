using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.BLL
{
    class AddUserDLL
    {
        public List<CashiersDTO> listUser()
        {
           return CashiersDAO.Instance.getAllUsers();
        }

        public bool checkUser(string username)
        {

            return CashiersDAO.Instance.checkUser(username);

        }

        public bool checkEmail(string email)
        {

            return CashiersDAO.Instance.checkEmail(email);

        }

        public bool insertUser(string username, string pass, string fullname, string role, string status, string birthday, string email, string Profile_Image)
        {
           return  CashiersDAO.Instance.insertUser(username, pass, fullname, role, status, birthday, email, Profile_Image);
        }

        public bool updateUser(string username, string pass, string fullname, string role, string status, string birthday, string email, int id, string Profile_Image)
        {
            return CashiersDAO.Instance.updateUser(username, pass, fullname, role, status, birthday, email, id, Profile_Image);
        }

        public bool deleteUser(int id)
        {
            return CashiersDAO.Instance.deleteUser(id);
        }

        public int getIDUser(string usern)
        {
            return CashiersDAO.Instance.getIDUser(usern);
        }
    }
}
