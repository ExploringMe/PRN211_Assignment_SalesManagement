using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Search(Expression<Func<Product, bool>> ex)
        {
            return EntityDAO.Instance.context.Products.Where(ex);
        }
    }
}
