using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaChallengeV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [Route("addProduct")]
        [HttpPost]
        public async Task<Product> AddProductAsync(Product product)
        {
            var addedProduct = await mediator.Send(new CreateProductCommand(
                product.ProductName,
                product.stock,
                product.price,
                product.FirmId));
            return addedProduct;
        }
    }
}
