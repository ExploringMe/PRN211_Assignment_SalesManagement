using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }
        //private void DgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    frmCarDetails frmCarDetails = new frmCarDetails
        //    {
        //        Text = "Update car",
        //        InsertOrUpdate = true,
        //        CarInfo = GetCarObject(),
        //        CarRepository = carRepository
        //    };
        //    if (frmCarDetails.ShowDialog() == DialogResult.OK)
        //    {
        //        LoadCarList();
        //        //Set focus car updated
        //        source.Position = source.Count - 1;
        //    }
        //}
        //Clear Text on TextBoxes
        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
        }
        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }
        public void LoadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (products.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
