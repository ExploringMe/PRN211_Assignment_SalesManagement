using BusinessObject;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        FStoreContext FStoreDB;
        public OrderDetailDAO()
        {
            FStoreDB = new FStoreContext();
        }
        public static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }

            }
        }


        public OrderDetail GetOrderDetailByID(int OrderDetailID)
        {
            OrderDetail orderDetail = null;
            return orderDetail;
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            var orderDetails = new List<OrderDetail>();
            foreach (var od in FStoreDB.OrderDetails)
            {
                orderDetails.Add(od);
            }
            return orderDetails;
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {

        }
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {

        }
        public void DeleteOrderDetail(int orderDetailID)
        {

        }
    }
}