using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyCafe.DAO
{
    public class ProductsDAO
    {

        private static ProductsDAO instance;

        public static ProductsDAO Instance
        {
            get { if (instance == null) instance = new ProductsDAO(); return ProductsDAO.instance; }
            private set { ProductsDAO.instance = value; }
        }

        private ProductsDAO() { }

        #region addProduct
        public List<ProductsDTO> getListProduct()
        {
            List<ProductsDTO> listProduct = new List<ProductsDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Products,Categories where statusDel = 0 and Category_id = ID_Category");

            foreach (DataRow item in data.Rows)
            {
                ProductsDTO info = new ProductsDTO(item);
                listProduct.Add(info);
            }
            return listProduct;
        }

        public bool insertProduct(string name, int stock, float price, int category, string img, string status, string description)
        {
            string insertQuery = "insert into Products(ProductName,Stock,Price,Category_id,Image,Status,Description) values( @ProductName , @Stock , @Price , @Category_id , @Image , @Status , @Description )";
            int result = DataProvider.Instance.ExecuteNonQuery(insertQuery, new object[] { name, stock, price, category, img, status, description });
            return result > 0;
        }

        public bool updateProduct(string name, int stock, float price, int category, string img, string status, string description, int id)
        {
            string udpateQuery = "update Products set ProductName= @ProductName ,Stock= @Stock ,Price= @Price ,Category_id= @Category_id ,Image= @Image ,Status= @Status ,Description= @Description where Product_ID= @Product_ID";
            int result = DataProvider.Instance.ExecuteNonQuery(udpateQuery, new object[] { name, stock, price, category, img, status, description, id });
            return result > 0;
        }

        public bool deleteProduct(int id)
        {
            string udpateQuery = "update Products set statusDel = 1 where Product_ID= @Product_ID ";
            int result = DataProvider.Instance.ExecuteNonQuery(udpateQuery, new object[] { id });
            return result > 0;
        }

        public int getIDProd(string name)
        {
            string query = "select Product_ID from Products where ProductName = @name and statusDel = 0";
            object obj = DataProvider.Instance.ExecuteScalar(query, new object[] { name });
            int id = (obj != null && obj != DBNull.Value) ? (int)obj : 0;
            return id;
        }
        #endregion
    }
}
