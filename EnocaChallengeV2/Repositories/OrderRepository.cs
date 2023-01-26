using EnocaChallengeV2;
using EnocaChallengeV2.Models;
using Microsoft.EntityFrameworkCore;

namespace EnocaChallengeV2.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        

        private readonly DbContextClass _dbContext;

        public OrderRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> PlaceOrderAsync(Order order)
        {
            var result = _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
