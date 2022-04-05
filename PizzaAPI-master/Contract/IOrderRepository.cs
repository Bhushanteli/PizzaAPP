using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
   public interface IOrderRepository
    {
        Task<string> CretaeOrder(Order order);
        Task<IEnumerable<Order>> GetOrders();
    }
}
