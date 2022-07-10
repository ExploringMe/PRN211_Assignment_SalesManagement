using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrders();
        public Order GetOrderByID(int orderID) => OrderDAO.Instance.GetOrderByID(orderID);  
        public void InsertOrder(Order order) => OrderDAO.Instance.AddOrder(order);
        public void DeleteOrder(int orderID) => OrderDAO.Instance.DeleteOrder(orderID);
        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
        public void DeleteOrderByMemberID(int memberID) => OrderDAO.Instance.DeleteOrderByMemberID(memberID);
        public dynamic GetMemberID() => OrderDAO.Instance.GetMemberID();
    }
}
