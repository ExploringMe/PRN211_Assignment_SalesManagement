using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByID(int orderDetailByID);
        void InsertOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderDetailID);
        void UpdateOrderDetail(OrderDetail orderDetail);
    }
}
