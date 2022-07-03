using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Search(Expression<Func<Order, bool>> ex);
    }
}
