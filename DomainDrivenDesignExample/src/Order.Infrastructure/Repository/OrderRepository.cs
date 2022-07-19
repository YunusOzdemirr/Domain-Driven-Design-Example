using System;
using Order.Application.Repository;

namespace Order.Infrastructure.Repository
{
    public class OrderRepository:IOrderRepository
    {
        public OrderRepository()
        {
        }

        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(0);
        }
    }
}

