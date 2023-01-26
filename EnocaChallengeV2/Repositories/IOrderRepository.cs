using EnocaChallengeV2.Models;
using Microsoft.EntityFrameworkCore;

namespace EnocaChallengeV2.Repositories
{
    public interface IOrderRepository
    {

        public Task<Order> PlaceOrderAsync(Order order);
    }
}
