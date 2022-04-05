using Contract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IOrderStorage orderStorage;

        public OrderRepository(IOrderStorage orderStorage)
        {
            this.orderStorage = orderStorage;
        }
        public async Task<string> CretaeOrder(Order order)
        {
            return await orderStorage.CreateOrder(order);
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await orderStorage.GetOrders();
        }
    }
}
