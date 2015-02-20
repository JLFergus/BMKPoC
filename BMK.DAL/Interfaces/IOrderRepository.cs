using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMK.Models;

namespace BMK.DAL
{
    public interface IOrderRepository
    {
        Order SaveOrder(Order order);
        Order GetOrder(int orderId);
        List<Order> GetOrdersByUser(User user);
    }
}
