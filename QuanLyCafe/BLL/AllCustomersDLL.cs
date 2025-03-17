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
    class AllCustomersDLL
    {
        public List<CustomersDTO> getAllCus()
        {
            return CustomerDAO.Instance.getAllCus();
        }

        public int getIDCus(string email, string phone)
        {
            

            return CustomerDAO.Instance.getIDCus(email,phone);
        }
    }
}
