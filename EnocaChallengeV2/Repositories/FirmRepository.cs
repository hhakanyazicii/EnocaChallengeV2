using EnocaChallengeV2;
using EnocaChallengeV2.Models;
using Microsoft.EntityFrameworkCore;

namespace EnocaChallengeV2.Repositories
{
    public class FirmRepository : IFirmRepository
    {
        private readonly DbContextClass _dbContext;

        public FirmRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Firm> AddFirmAsync(Firm firm)
        {
            var result = _dbContext.Firms.Add(firm);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Firm> GetFirmByIdAsync(int Id)
        {
            return await _dbContext.Firms.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<Firm>> GetFirmListAsync()
        {
            return await _dbContext.Firms.ToListAsync();
        }

        public async Task<int> UpdateFirmDateAsync(Firm firm)
        {
            _dbContext.Firms.Update(firm);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateFirmVerificationAsync(Firm firm)
        {
            _dbContext.Firms.Update(firm);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
