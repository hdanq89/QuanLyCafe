using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DTO;
using QuanLyCafe.BLL;
using QuanLyCafe.DAO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace QuanLyCafe
{
    public  partial class OrderForm: UserControl
    {
        public OrderFormBLL orderBLL=new OrderFormBLL();

        //Dung quan ly panle anh xa den product
        private Dictionary<Panel, ProductsDTO> pr = new Dictionary<Panel, ProductsDTO>();
        public Panel clickPanel;
        //gia trong oder
        public Label labelGia;
        public NumericUpDown numericUpDown;

        //gia duoc su dung nhieu nen khai bao dung cho no tien

        private float  gia = 0;
        public OrderForm()
        {
            InitializeComponent();
            panel_Products.Controls.Clear();
            displayPlane();
        }

        //them cac san pham vao trong panel
        public void displayPlane()
        {
            List<ProductsDTO> listGetAll = orderBLL.getAllProducts();
            panel_Products.AutoScroll = true;
            int x = 10, y = 10; // Tọa độ ban đầu
            int maxWidth = panel_Products.Width; // Chiều rộng tối đa
            int productWidth = 100, productHeight = 150; // Kích thước mỗi sản phẩm
            int padding = 20; // Khoảng cách giữa các sản phẩm

            foreach (ProductsDTO product in listGetAll)
            {
                ProductsDTO productsDTOs = new ProductsDTO
                {
                    Product_ID = product.Product_ID,
                    Price = product.Price,
                };
                // Tạo panel chứa từng sản phẩm
                Panel panel = new Panel
                {
                    Size = new Size(productWidth, productHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(x, y),
                    Cursor = Cursors.Hand, // Biểu tượng chuột khi hover
                    Tag=productsDTOs
                };

                pr[panel] = product; // Lưu vào Dictionary

                // Label hiển thị tên sản phẩm
                Label label_Name = new Label
                {
                    Text = product.Name,
                    AutoSize = false,
                    Size = new Size(100, 25),
                    Location = new Point(0, 80),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };

                // Label hiển thị giá tiền
                Label label_Gia = new Label
                {
                    Text = $"{product.Price}$",
                    AutoSize = false,
                    Size = new Size(100, 25),
                    Location = new Point(0, 110),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Green,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };

                // PictureBox hiển thị ảnh sản phẩm
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(100, 80),
                    Location = new Point(0, 0),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
                };

                // Gán hình ảnh từ file, nếu không có thì dùng ảnh mặc định
                string image = "C:\\Users\\kiett\\Pictures\\z6337302386797_58585d0bb4c0d34feb813a26f329680f.jpg";
                pictureBox.Image = Image.FromFile(image);

                // Thêm sự kiện Click cho tất cả thành phần
                panel.Click += Product_Click;
                pictureBox.Click += Product_Click;
                label_Name.Click += Product_Click;
                label_Gia.Click += Product_Click;

                // Thêm vào Panel sản phẩm
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label_Name);
                panel.Controls.Add(label_Gia);
                panel_Products.Controls.Add(panel);

                // Cập nhật vị trí X cho sản phẩm tiếp theo
                x += productWidth + padding;

                // Nếu vượt quá chiều rộng panel thì xuống dòng
                if (x + productWidth > maxWidth)
                {
                    x = 10;
                    y += productHeight + padding;
                }
            }

        }

        // Xử lý khi Click vào sản phẩm
        public void Product_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;

            // Tìm Panel chứa sản phẩm 
            // vd khi nguoi dung bam vao anh thi no se lui lai tim panel cha va panel do duoc luu vao Directory
            while (clickedControl != null && !(clickedControl is Panel))
            {
                clickedControl = clickedControl.Parent;
            }
            if (clickedControl is Panel panel)
            {
                ProductsDTO product = pr[panel];
                label_NameProduct.Text = product.Name;
                cashierOrderForm_quantily.Value = 1;
                cashierOrderForm_price.Text=product.Price.ToString();
                this.gia=float.Parse(product.Price.ToString());

                this.clickPanel=PanelExtensions.Clone(panel);
                pr[this.clickPanel] = pr[panel];
            }
        }
        ////copy Panel
        //public Panel Clone(this Panel original)
        //{
        //    Panel newPanel = new Panel
        //    {
        //        Size = original.Size,
        //        Location = original.Location,
        //        BorderStyle = original.BorderStyle,
        //        BackColor = original.BackColor,
        //        Tag = original.Tag,
        //        Cursor = original.Cursor
        //    };

        //    foreach (Control control in original.Controls)
        //    {
        //        Control newControl = (Control)Activator.CreateInstance(control.GetType());
        //        newControl.Size = control.Size;
        //        newControl.Location = control.Location;
        //        newControl.Text = control.Text;
        //        newControl.Font = control.Font;
        //        newControl.BackColor = control.BackColor;
        //        newControl.ForeColor = control.ForeColor;
        //        newControl.Cursor = control.Cursor;

        //        if (control is PictureBox pictureBox)
        //        {
        //            ((PictureBox)newControl).Image = new Bitmap(pictureBox.Image);
        //            ((PictureBox)newControl).SizeMode = pictureBox.SizeMode;
        //        }

        //        newPanel.Controls.Add(newControl);
        //    }

        //    return newPanel;
        //}


        //xu ly su kien thay doi gia tri numeric
        private void numericUpDownOrder_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numUpDown = sender as NumericUpDown;
            if (numUpDown != null)
            {
               Panel parentPanel = numericUpDown.Parent as Panel;
                if (parentPanel!=null)
                {
                    ProductsDTO products = parentPanel.Tag as ProductsDTO;
                    float newGia = products.Price;
                    Label newLabel=parentPanel.Controls.OfType<Label>().FirstOrDefault(lbl=>lbl.Name=="labelGia" );
                    if (newLabel != null)
                    {
                        newLabel.Text =((float)this.numericUpDown.Value*newGia).ToString();
                    }
                }
            }

            if (panel_Order.Controls.Count > 0)
            {
                float a = 0;
                List<Dictionary<string, object>> list = orderBLL.getOrderPanel(panel_Order);
                foreach (Dictionary<string, object> pair in list)
                {
                    if (pair.ContainsKey("Price") && pair["Price"] is float price)
                    {
                        a += price;
                    }
                    else
                    {
                        MessageBox.Show("no");
                    }
                }

                cashierOrderForm_orderPrice.Text = a.ToString();
            }
        }


        //
        private void cashierOrderForm_quantily_ValueChanged(object sender, EventArgs e)
        {
            cashierOrderForm_price.Text=(gia*(float)cashierOrderForm_quantily.Value).ToString();
        }



        public Panel checkProduct(string name, Panel oldPanel)
        {
            foreach (Panel panel in oldPanel.Controls)
            {
                Label label = panel.Controls.OfType<Label>().FirstOrDefault();
                NumericUpDown numericUpDown = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (label != null && label.Text == name)
                {
                    return panel;
                }
            }
            return null;
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            string productName = label_NameProduct.Text;
            decimal quantity = cashierOrderForm_quantily.Value;
            //panel luu dia chi cua panel khi bam vao, vay nen no se thay doi gia tri cua panel
            Panel existingPanel = checkProduct(productName, panel_Order);
            if (existingPanel != null) // Nếu sản phẩm đã tồn tại
            {
                
                NumericUpDown numericUp = existingPanel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                Label labelGia1 = existingPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "labelGia");

                if (numericUp != null)
                {
                    ProductsDTO productsDTO = existingPanel.Tag as ProductsDTO;
                    numericUp.Value += quantity; // Tăng số lượng
                    float totalPrice = (float)productsDTO.Price*(float)numericUp.Value; // Cập nhật tổng giá
                    labelGia1.Text = totalPrice.ToString("N2");
                }
            }
            else
            {
               ProductsDTO productsDTO = pr[this.clickPanel];
                // Nếu sản phẩm chưa có, thêm mới
                int x = 5;
                int heighPanel = 60;
                int y = panel_Order.Controls.Count * heighPanel;
                if (panel_Order.Controls.Count == 0)
                {
                    y = 5;
                }
                panel_Order.AutoScroll = true;

                Panel panel = this.clickPanel;
                panel.Size = new Size(250, 50);
                panel.Location= new Point(x, y);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Tag = productsDTO;

                //panel.Click += Product_Click;


                Label label = new Label
                {
                    Text = productName,
                    Location = new Point(45, 5),
                };

                this.labelGia = new Label
                {
                    Name= "labelGia",
                    Text = cashierOrderForm_price.Text,
                    Location = new Point(190, 5),
                };

                 this.numericUpDown = new NumericUpDown
                {
                    Value = quantity,
                    Location = new Point(200, 20),
                    Size = new Size(35, 20),
                    Minimum = 1
                };
                this.numericUpDown.ValueChanged += numericUpDownOrder_ValueChanged;
                PictureBox pictureBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
                pictureBox.Size = new Size(45, 40);
                pictureBox.Location = new Point(0, 0);
                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(numericUpDown);
                panel.Controls.Add(labelGia);
                panel_Order.Controls.Add(panel);
            }
            if (panel_Order.Controls.Count > 0)
            {
                float a = 0;
                List<Dictionary<string, object>> list = orderBLL.getOrderPanel(panel_Order);
                foreach (Dictionary<string, object> pair in list)
                {
                    if (pair.ContainsKey("Price") && pair["Price"] is float price)
                    {
                        a += price;
                    }
                    else
                    {
                        MessageBox.Show("no");
                    }
                }

                cashierOrderForm_orderPrice.Text = a.ToString();
            }
               
        }

        private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> list = orderBLL.getOrderPanel(panel_Order);
            string result = "";
            float price = 0;
            DateTime dateTime = DateTime.Now;
            OrdersDTO orders = new OrdersDTO
            {
                Total_Price = price,
                Status = 1,
                Cashier_Create = (int)Properties.Settings.Default.ID,
                Date_Create = dateTime.Date,
                OrderID = 1,
                Customer_ID = 1,

            };

            string query = "insert into Orders(Total,Status,Customer_id,Cashier_ID,Create_date) output inserted.Order_ID Values( @Total , @Status , @Customer_ID , @Cashier_ID , @Create_ID ) ";

            Object ID_insert = DataProvider.Instance.ExecuteScalar(query, new object[] { orders.Total_Price, orders.Status, orders.Customer_ID, orders.Cashier_Create, orders.Date_Create });
            MessageBox.Show(ID_insert.ToString());
            int ID_Order = int.Parse(ID_insert.ToString());
            foreach (Dictionary<string, object> pair in list)
            {
                // result += string.Join("\n", pair.Select(kv => $"{kv.Key}: {kv.Value}"));
                var product = pair["product"] as ProductsDTO;
                //result += $"\n id {product.Product_ID}";
                //result += $"\n gia {product.Price}";
                price += (float)pair["Price"];
                //result += "\n";

                

                
                OrdersDetailDTO ordersDetailDTO = new OrdersDetailDTO
                {
                    Order_ID = ID_Order,
                    Product_ID=product.Product_ID,
                    Quantity = Convert.ToInt32(pair["quantity"]),  // Ép kiểu từ decimal về int
                    Unit = (float)pair["Price"]
                };
                string queryOderDeatails = "insert into OrderDetails(Orders_Id, Product_ID, Quantity, Unit) values( @Order_ID , @Product_ID , @Quantity , @Unit )";
                int n=DataProvider.Instance.ExecuteNonQuery(queryOderDeatails,new object[] {ordersDetailDTO.Order_ID, ordersDetailDTO.Product_ID,ordersDetailDTO.Quantity,ordersDetailDTO.Unit});
            }
            string update = "UPDATE Orders SET Total = @Total WHERE Order_ID = @Order_ID ";
            int m = DataProvider.Instance.ExecuteNonQuery(update, new object[] { price, ID_Order });
            //MessageBox.Show(result, "Thông tin đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //DateTime dateTime = DateTime.Now;
            //OrdersDTO orders = new OrdersDTO
            //{
            //    Total_Price = price,
            //    Status = 1,
            //    Cashier_Create =(int)Properties.Settings.Default.ID,
            //    Date_Create=dateTime.Date,
            //    OrderID = 1,
            //    Customer_ID = 1,

            //};

            //PropertyInfo[] propertyInfos = orders.GetType().GetProperties();
            //foreach (var propertyInfo in propertyInfos) { 
            //    Console.WriteLine(propertyInfo.Name); 
            //}
            //string query = "insert into Orders(Total,Status,Customer_id,Cashier_ID,Create_date) output inserted.Order_ID Values( @Total , @Status , @Customer_ID , @Cashier_ID , @Create_ID ) ";

            //Object ID_insert=DataProvider.Instance.ExecuteScalar(query,new object[] {orders.Total_Price,orders.Status,orders.Customer_ID,orders.Cashier_Create,orders.Date_Create});
            //MessageBox.Show(ID_insert.ToString());
            //int ID_Order=int.Parse(ID_insert.ToString());

        }
    }
}
