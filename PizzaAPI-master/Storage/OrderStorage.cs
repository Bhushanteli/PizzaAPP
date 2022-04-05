using Contract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
   public class OrderStorage: IOrderStorage
    {
        readonly List<Order> orders = new List<Order>();

 
       
        

        public async Task<string> CreateOrder(Order order)
        {
              orders.Add(order);
            return await Task.FromResult(order.OrderId.ToString());
        }

      public async  Task<IEnumerable<Order>> GetOrders()
        {
            return await Task.FromResult(orders);
        }
    }
}
