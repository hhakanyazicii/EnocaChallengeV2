using EnocaChallengeV2.Models;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnocaChallengeV2.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string ProductName { get; set; }
        public int stock { get; set; }
        public float price { get; set; }
        public int FirmId { get; set; }

        public CreateProductCommand(string productName, int Stock, float Price, int firmId)
        {
            ProductName = productName;
            stock = Stock;
            price = Price;
            FirmId = firmId;
        }
    }
}
