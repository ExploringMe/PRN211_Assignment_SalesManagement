using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetails();
        public OrderDetail GetOrderDetailByID(int orderDetailByID) => OrderDetailDAO.Instance.GetOrderDetailByID(orderDetailByID);
        public void InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddOrderDetail(orderDetail);
        public void DeleteOrderDetail(int orderDetailID) => OrderDetailDAO.Instance.DeleteOrderDetail(orderDetailID);
        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
    }
}
