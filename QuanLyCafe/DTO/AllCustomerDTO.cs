using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class AllCustomerDTO
    {


        public AllCustomerDTO(DataRow row)
        {

            this.fullName = row["Fullname"].ToString();
            this.phone = row["Phone"].ToString();
            this.email = row["Email"].ToString();
            this.address = row["Address"].ToString();
            this.totalSpend = Convert.ToDouble(row["TotalSpend"]); ;
         
        }

        private string fullName;

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		private string	 phone;

		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private double totalSpend;

		public double TotalSpend
        {
			get { return totalSpend; }
			set { totalSpend = value; }
		}


	}
}
