using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class OrdersDetailDAO
    {
        private static OrdersDetailDAO instance;

        public static OrdersDetailDAO Instance
        {
            get { if (instance == null) instance = new OrdersDetailDAO(); return OrdersDetailDAO.instance; }
            private set { OrdersDetailDAO.instance = value; }
        }



        #region CustomerOrder
        public List<OrdersDetailDTO> getOrderDetail(int id)
        {
            List<OrdersDetailDTO> listOrderDetail = new List<OrdersDetailDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from OrderDetails a,Orders b,Products c where a.Order_ID = @id and a.Order_ID = b.Order_ID and a.Product_ID = c.Product_ID ", new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                OrdersDetailDTO info = new OrdersDetailDTO(item);


                listOrderDetail.Add(info);
            }
            return listOrderDetail;
        }
        #endregion



    }
}
