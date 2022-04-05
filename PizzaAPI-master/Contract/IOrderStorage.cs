using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IOrderStorage
    {
        Task<string> CreateOrder(Order order);
        Task<IEnumerable<Order>> GetOrders();
    }
}
