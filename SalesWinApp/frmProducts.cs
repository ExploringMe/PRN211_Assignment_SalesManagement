using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            List<String> options = new List<String>()
            {
                "Price", "Quantity"
            };
            comboBox1.DataSource = options;
            comboBox1.SelectedIndex = 0;
        }
        IProductRepository productRepository;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String name = txtSearch.Text;
            dgvProductList.DataSource = productRepository.Search(x=> x.ProductName.Contains(name)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int num1 = int.Parse(txt1.Text);
                int num2 = int.Parse(txt2.Text);
                dgvProductList.DataSource = productRepository.Search(x => x.UnitPrice >= num1 && x.UnitPrice <= num2).ToList();

            }
            else
            {
                int num1 = int.Parse(txt1.Text);
                int num2 = int.Parse(txt2.Text);
                dgvProductList.DataSource = productRepository.Search(x=> x.UnitInStock>= num1 && x.UnitInStock <= num2).ToList();
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
