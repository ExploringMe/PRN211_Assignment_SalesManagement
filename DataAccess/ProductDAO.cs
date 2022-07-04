using BusinessObject;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data;

namespace DataAccess
{
    public class ProductDAO
    {
        FStoreContext FStoreDB;
        public ProductDAO()
        {
            FStoreDB = new FStoreContext();
        }

        public static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }

            }
        }
        
        public Product GetProductByID(int ProductID)
        {
            Product product = null;
            foreach (Product p in FStoreDB.Products)
            {
                if(p.ProductId == ProductID)
                    product = p;
            }
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            foreach (var p in FStoreDB.Products)
            {
                products.Add(p);
            }
            return products;
        }

        public void AddProduct(Product product)
        {

        }
        public void UpdateProduct(Product product)
        {

        }
        public void DeleteProduct(int productID)
        {
            Product product = GetProductByID(productID);
            try
            {
                if (product != null)
                {
                    FStoreDB.Products.Remove(product);
                }
                else
                {
                    throw new Exception("The car is not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
