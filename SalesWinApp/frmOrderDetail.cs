using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        BindingSource source;

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetailList();
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        public void LoadOrderDetailList()
        {
            var orderDetails = OrderDetailRepository.GetOrderDetails();
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;
                if (orderDetails.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load orderDetail list");
            }
        }

    }
}
