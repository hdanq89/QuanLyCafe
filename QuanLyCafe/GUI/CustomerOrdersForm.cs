using QuanLyCafe.BLL;
using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class CustomerOrdersForm: Form
    {
        CustomerOrderDLL cusOrder = new CustomerOrderDLL();
        public CustomerOrdersForm(int id,string name)
        {
            InitializeComponent();
            lbl_cusInfo.Text += name ;
            displayOrderList(id);
        }


        public void displayOrderList(int id)
        {
           orderList.DataSource =  cusOrder.getCustomerOrder(id);
        }

        private void adminLogin_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = orderList.Rows[e.RowIndex];
                int idOrder = (int)row.Cells[0].Value;
                dataGridView2.DataSource = cusOrder.getOrderDetail(idOrder);
            }
        }
    }
}
