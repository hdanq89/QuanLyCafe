using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class OrdersDetailDTO
    {


        public OrdersDetailDTO(DataRow row)
        {
            this.Order_ID= (int)row["Order_ID"];
            this.Product_ID =(int) row["ProductName"];
            this.Quantity = (int)row["Quantity"];
            this.Unit = (float)row["Unit"];
        }
        public OrdersDetailDTO() { }
        private int product_Name;

        public int Product_ID
        {
            get { return product_Name; }
            set { product_Name = value; }
        }

        private int order_ID;
        public int Order_ID
        {
            get { return order_ID; }
            set { order_ID = value; }
        }

        private int quantily;

        public int Quantity
        {
            get { return quantily; }
            set { quantily = value; }
        }

        private float unit;

        public float Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
