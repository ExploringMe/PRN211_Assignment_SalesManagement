using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository;
        public frmOrders()
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;
          
            dgvOrderList.DataSource = orderRepository.Search(x => x.OrderDate >= start.AddMinutes(-100) && x.OrderDate <= end).ToList();
        }
    }
}
