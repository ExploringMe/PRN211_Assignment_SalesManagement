using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Search(Expression<Func<Product, bool>> ex);
            IEnumerable<Product> GetProducts();
            Product GetProductByID(int productID);
            void InsertProduct(Product product);
            void DeleteProduct(int productID);
            void UpdateProduct(Product product);
    }
}
