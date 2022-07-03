using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> Search(Expression<Func<Order, bool>> ex)
        {
            return EntityDAO.Instance.context.Orders.Where(ex);
        }
    }
}
