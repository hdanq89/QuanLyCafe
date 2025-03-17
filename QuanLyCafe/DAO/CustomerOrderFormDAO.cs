using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class CustomerOrderFormDAO
    {
        private static CustomerOrderFormDAO instance;

        public static CustomerOrderFormDAO Instance
        {
            get { if (instance == null) instance = new CustomerOrderFormDAO(); return CustomerOrderFormDAO.instance; }
            private set { CustomerOrderFormDAO.instance = value; }
        }

        public List<CustomerOrdersFormOrderListDTO> getCustomerOrder(int id)
        {
            List<CustomerOrdersFormOrderListDTO> listOrder = new List<CustomerOrdersFormOrderListDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from Cashiers,Orders where id = Cashier_ID and Customer_ID = @CusID ", new object[] {id});

            foreach (DataRow item in data.Rows)
            {
                CustomerOrdersFormOrderListDTO info = new CustomerOrdersFormOrderListDTO(item);
                listOrder.Add(info);
            }
            return listOrder;
        }

        public List<CustomerOrderFormListDetailDTO> getOrderDetail(int id)
        {
            List<CustomerOrderFormListDetailDTO> listOrderDetail = new List<CustomerOrderFormListDetailDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from OrderDetails a,Orders b,Products c where a.Order_ID = @id and a.Order_ID = b.Order_ID and a.Product_ID = c.Product_ID ", new object[] {  id });

            foreach (DataRow item in data.Rows)
            {
                CustomerOrderFormListDetailDTO info = new CustomerOrderFormListDetailDTO(item);
                

                listOrderDetail.Add(info);
            }
            return listOrderDetail;
        }


    }
}
