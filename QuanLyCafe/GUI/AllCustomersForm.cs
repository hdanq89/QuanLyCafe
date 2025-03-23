using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using QuanLyCafe.BLL;

namespace QuanLyCafe
{
    public partial class AllCustomersForm: UserControl
    {
        AllCustomersDLL allCus = new AllCustomersDLL();
        public AllCustomersForm()
        {
            InitializeComponent();
            displayAllCus();
        }

        #region Method
        void displayAllCus()
        {
            allCustomers_dataTable.DataSource =  allCus.getAllCus();
        }
        #endregion

       

        private void allCustomers_dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = allCustomers_dataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                string email = allCustomers_dataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string phone = allCustomers_dataTable.Rows[e.RowIndex].Cells[1].Value.ToString();

                int id =  allCus.getIDCus(email, phone);

                CustomerOrdersForm orderForm = new CustomerOrdersForm(id,name);
                orderForm.ShowDialog();

            }
        }
    }
}
