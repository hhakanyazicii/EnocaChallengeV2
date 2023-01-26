using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Repositories;
using MediatR;
using EnocaChallengeV2.Queries;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnocaChallengeV2.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                ProductName = command.ProductName,
                stock = command.stock,
                price = command.price,
                FirmId = command.FirmId
            };

            return await _productRepository.AddProductAsync(product);
        }
    }
}
