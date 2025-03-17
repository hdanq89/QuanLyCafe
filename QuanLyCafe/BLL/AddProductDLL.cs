using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.BLL
{
    class AddProductDLL
    {
        public List<ProductsDTO> getListProduct()
        {
            return ProductsDAO.Instance.getListProduct();
        }

        public bool insertProduct(string name, int stock, float price, int category, string img, string status, string description)
        {
            return ProductsDAO.Instance.insertProduct(name, stock, price, category, img, status, description);
        }

        public bool updateProduct(string name, int stock, float price, int category, string img, string status, string description, int id)
        {
            return ProductsDAO.Instance.updateProduct(name, stock, price, category, img, status, description, id);
        }

        public bool deleteProduct(int id)
        {
            return ProductsDAO.Instance.deleteProduct(id);
        }

        public int getIDProd(string name)
        {
            return ProductsDAO.Instance.getIDProd(name);
        }
    }
}
