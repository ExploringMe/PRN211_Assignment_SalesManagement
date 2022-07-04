using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetail f = new frmOrderDetail();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtFreight.Text = string.Empty;
            mtxtOrderDate.Text = string.Empty;
            mtxtRequiredDate.Text = string.Empty;
            mtxtShippedDate.Text = string.Empty;
        }

        public void LoadOrderList()
        {
            var orders = orderRepository.GetOrders();
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                mtxtOrderDate.DataBindings.Clear();
                mtxtRequiredDate.DataBindings.Clear();
                mtxtShippedDate.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                mtxtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                mtxtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                mtxtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                if (orders.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load order list");
            }
        }
    }
}
