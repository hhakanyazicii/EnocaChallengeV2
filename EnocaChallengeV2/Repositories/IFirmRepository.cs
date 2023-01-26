using EnocaChallengeV2.Models;

namespace EnocaChallengeV2.Repositories
{
    public interface IFirmRepository
    {
        public Task<List<Firm>> GetFirmListAsync();
        public Task<Firm> GetFirmByIdAsync(int Id);
        public Task<Firm> AddFirmAsync(Firm firm);
        public Task<int> UpdateFirmDateAsync(Firm firm);
        public Task<int> UpdateFirmVerificationAsync(Firm firm);
    }
}
