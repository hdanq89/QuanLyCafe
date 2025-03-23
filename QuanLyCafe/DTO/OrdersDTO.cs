using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public  class OrdersDTO
    {


		public OrdersDTO(DataRow row)
		{
            this.OrderID = (int)row["Order_ID"];
            this.Total_Price = Convert.ToDouble(row["Total"]);
			this.Date_Create =(DateTime) row["Create_date"];
            this.Cashier_Create =(int) row["Fullname"];
        }
		public OrdersDTO() { }

		private int orderID;

		public int OrderID
        {
			get { return orderID; }
			set { orderID = value; }
		}

		private double total_Price ;

		public double Total_Price
        {
			get { return total_Price ; }
			set { total_Price  = value; }
		}

		private DateTime date_Create;

		public DateTime Date_Create
		{
			get { return date_Create; }
			set { date_Create = value; }
		}

		private int cashier_Create;

		public int Cashier_Create
        {
			get { return cashier_Create; }
			set { cashier_Create = value; }
		}

		private int status;
		public int Status
		{
			get { return status; }
			set { status = value; }
		}


		private int customer_ID;
		public int Customer_ID
		{
			get { return customer_ID; }
			set { customer_ID = value; }
		}





	}
}
