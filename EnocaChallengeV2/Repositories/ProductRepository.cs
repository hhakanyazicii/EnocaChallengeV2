using EnocaChallengeV2;
using EnocaChallengeV2.Models;
using Microsoft.EntityFrameworkCore;

namespace EnocaChallengeV2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextClass _dbContext;

        public ProductRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            var result = _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
