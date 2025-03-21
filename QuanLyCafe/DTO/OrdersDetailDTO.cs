﻿using System;
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
            this.Product_Name = row["ProductName"].ToString();
            this.Quantity = (int)row["Quantity"];
            this.Unit = Convert.ToDouble(row["Unit"]);
        }

        private string product_Name;

        public string Product_Name
        {
            get { return product_Name; }
            set { product_Name = value; }
        }


        private int quantily;

        public int Quantity
        {
            get { return quantily; }
            set { quantily = value; }
        }

        private double unit;

        public double Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
