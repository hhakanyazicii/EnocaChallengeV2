using EnocaChallengeV2.Models;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using EnocaChallengeV2.Repositories;

namespace EnocaChallengeV2.Commands
{
    public class PlaceOrderCommand : IRequest<Order>
    {
        public string orderedBy { get; set; }
        public DateTime orderDate { get; set; }
        public int FirmId { get; set; }
        public int ProductId { get; set; }

        public PlaceOrderCommand(string OrderedBy, DateTime OrderDate, int firmId, int productId)
        {
            
            orderedBy = OrderedBy;
            orderDate = OrderDate;
            FirmId = firmId;
            ProductId = productId;
        }
    }
}
