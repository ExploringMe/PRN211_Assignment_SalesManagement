using BusinessObject;

namespace DataAccess
{
    public class OrderDAO
    {
        FStoreContext FStoreDB;
        public OrderDAO()
        {
            FStoreDB = new FStoreContext();
        }

        public static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }

            }
        }


        public Order GetOrderByID(int OrderID)
        {
            Order order = null;
            return order;
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>();
            foreach (var o in FStoreDB.Orders)
            {
                orders.Add(o);
            }
            return orders;
        }

        public void AddOrder(Order order)
        {

        }
        public void UpdateOrder(Order order)
        {

        }
        public void DeleteOrder(int orderID)
        {

        }
    }
}
