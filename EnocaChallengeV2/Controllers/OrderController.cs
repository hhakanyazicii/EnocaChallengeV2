using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaChallengeV2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator mediator;
        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [Route("placeOrder")]
        [HttpPost]
        public async Task<Order> PlaceOrderAsync(Order order)
        {
            var orderDetails = await mediator.Send(new PlaceOrderCommand(order.orderedBy,order.orderDate,order.FirmId,order.ProductId));
                
            return orderDetails;
        }
    }
}
