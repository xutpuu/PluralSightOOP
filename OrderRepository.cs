using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrive(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
                order.OrderDate = new DateTimeOffset(2014, 5, 1, 8, 6, 32,
                                 new TimeSpan(1, 0, 0));
            return order;
        }

        public bool Save()
        {
            return true;
        }

    }
}
