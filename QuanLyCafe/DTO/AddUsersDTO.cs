using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class AddUsersDTO
    {

        public AddUsersDTO(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.Email = row["Email"].ToString();
            this.Fullname = row["Fullname"].ToString();
            this.Role = row["Role"].ToString();
            this.Status = row["Status"].ToString();
            this.BirthDate = row["BirthDate"].ToString();
        }



		private string username;
		public string Username
        {
			get { return username; }
			set { username = value; }
		}

		

		private string password;

		public string Password
        {
			get { return password; }
			set { password = value; }
		}


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string fullname;

		public string Fullname
		{
			get { return fullname; }
			set { fullname = value; }
		}

		private string role;
		public string Role
		{
			get { return role; }
			set { role = value; }
		}

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string birthDate;
		public string BirthDate
        {
			get { return birthDate; }
			set { birthDate = value; }
		}




	}
}
