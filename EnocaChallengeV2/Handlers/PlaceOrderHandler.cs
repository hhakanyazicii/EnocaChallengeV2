using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Repositories;
using MediatR;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using EnocaChallengeV2.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace EnocaChallengeV2.Handlers
{
    public class PlaceOrderHandler : IRequestHandler<PlaceOrderCommand, Order>
    {
        private bool isBetween;
        private readonly DbContextClass _dbContext;
        private readonly IOrderRepository _orderRepository;
        public PlaceOrderHandler(IOrderRepository orderRepository, DbContextClass dbContext)
        {
            _orderRepository = orderRepository;
            _dbContext = dbContext;

        }
        public async Task<Order> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
        {
            var IsVerified = await _dbContext.Firms.Where(x => x.Id == request.FirmId).Select(x => x.isVerified).SingleAsync();
            var startDate = await _dbContext.Firms.Where(x => x.Id == request.FirmId).Select(x => x.startTime).SingleAsync();
            var endDate = await _dbContext.Firms.Where(x => x.Id == request.FirmId).Select(x => x.endTime).SingleAsync();
            var requestOrderDate = DateTime.Parse(request.orderDate.ToString("HH:mm"));
            

            if (IsVerified == 1)
            {
                if (DateTime.Parse(startDate.ToString("HH:mm")) < requestOrderDate && DateTime.Parse(endDate.ToString("HH:mm")) > requestOrderDate)
                {
                    var order = new Order()
                    {

                        orderedBy = request.orderedBy,
                        orderDate = request.orderDate,
                        FirmId = request.FirmId,
                        ProductId = request.ProductId
                    };

                    return await _orderRepository.PlaceOrderAsync(order);
                }
                else
                {
                    throw new isBetweenDateException();
                }
            } 
            else
            {
                throw new isVerifiedException();
            }
            
        }
    }
}
