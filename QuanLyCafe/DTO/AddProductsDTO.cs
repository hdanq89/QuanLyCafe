using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class AddProductsDTO
    {

        public AddProductsDTO(DataRow row)
        {
            
            this.Name = row["ProductName"].ToString();
            this.Stock = (int)row["Stock"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Status = row["Status"].ToString();
            this.DesCription = row["Description"].ToString();
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private string desCription;

        public string DesCription
        {
            get { return desCription; }
            set { desCription = value; }
        }
        

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }




    }
}
