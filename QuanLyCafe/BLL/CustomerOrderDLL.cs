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
    class CustomerOrderDLL
    {
        public List<OrdersDTO> getCustomerOrder(int id)
        {
            return OrdersDAO.Instance.getCustomerOrder(id);
        }


        public List<OrdersDetailDTO> getOrderDetail(int id)
        {
            return OrdersDetailDAO.Instance.getOrderDetail(id);
        }
    }
}
