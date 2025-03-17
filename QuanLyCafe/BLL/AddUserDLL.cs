using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
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
    }
}
