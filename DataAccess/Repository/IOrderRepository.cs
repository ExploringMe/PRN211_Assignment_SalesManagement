using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(int orderID);
        void InsertOrder(Order order);
        void DeleteOrder(int orderID);
        void UpdateOrder(Order order);
        void DeleteOrderByMemberID(int memberID);
        dynamic GetMemberID();
    }
}
