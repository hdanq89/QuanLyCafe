using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.DTO;

namespace QuanLyCafe.BLL
{
    public class OrderFormBLL
    {
        public List<ProductsDTO> getAllProducts()
        {
            return ProductsDAO.Instance.getAll();
        }

        //lay tong so tien cua nhung san pham order
        //public float getPriceOrder(Panel panel)
        //{
        //    float price = 0;
        //    foreach (Control n in panel.Controls) {
        //        if(n is Panel newPanel)
        //        {
        //            Label labelGia = newPanel.Controls.OfType<Label>().FirstOrDefault(lbl => (lbl.Name == "labelGia"));
        //            if (labelGia != null && float.TryParse(labelGia.Text.Replace("$",""), out float gia))
        //            {
        //                price += gia;
        //            }

        //        }
        //    }

        //    return price;
        //}
        public List<Dictionary<string,object>> getOrderPanel(Panel panel)
        {
            List<Dictionary<string, object>> listObject = new List<Dictionary<string, object>>();

            foreach (Control n in panel.Controls)
            {
                Dictionary<string,object> item = new Dictionary<string,object>();
                if (n.Tag is ProductsDTO products)
                {
                    item["product"] = products;
                }
                Label labelGia = n.Controls.OfType<Label>().FirstOrDefault(lb => lb.Name == "labelGia");
                if (labelGia != null &&float.TryParse(labelGia.Text,out float pricew)) {
                    item["Price"]=pricew;
                }
                NumericUpDown numericUp = n.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (numericUp != null)
                {
                    item["quantity"]=numericUp.Value;
                }
                listObject.Add(item);
            }

            return listObject;
        }

    }
}
