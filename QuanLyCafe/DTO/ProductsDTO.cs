using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class ProductsDTO
    {

        public ProductsDTO(DataRow row)
        {
            
            this.Name = row["ProductName"].ToString();
            this.Product_ID = (int)row["product_ID"];
            this.Stock = (int)row["Stock"];
            this.Price = (float)Convert.ToDouble(row["Price"]);
            this.Status = row["Status"].ToString();
            this.DesCription = row["Description"].ToString();
            this.Type = (int)row["Category_id"];
        }
        public ProductsDTO()
        {

        }
        private int product_ID;
        public int Product_ID
        {
            get { return product_ID; }
            set { product_ID = value; }
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

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
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


    }
}
