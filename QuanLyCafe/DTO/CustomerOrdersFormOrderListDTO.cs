using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public  class CustomerOrdersFormOrderListDTO
    {


		public CustomerOrdersFormOrderListDTO(DataRow row)
		{
            this.OrderID = (int)row["Order_ID"];
            this.Total_Price = Convert.ToDouble(row["Total"]);
            this.Date_Create = row["Create_date"].ToString();
            this.Employee_Create = row["Fullname"].ToString();
        }
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

		private string date_Create;

		public string Date_Create
		{
			get { return date_Create; }
			set { date_Create = value; }
		}

		private string employee_Create;

		public string Employee_Create
        {
			get { return employee_Create; }
			set { employee_Create = value; }
		}









	}
}
