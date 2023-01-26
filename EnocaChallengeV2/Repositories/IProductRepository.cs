using EnocaChallengeV2.Models;

namespace EnocaChallengeV2.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductListAsync();
        public Task<Product> AddProductAsync(Product product);
    }
}
