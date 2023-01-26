using EnocaChallengeV2.Models;
using EnocaChallengeV2.Queries;
using EnocaChallengeV2.Repositories;
using MediatR;
using System.Numerics;

namespace EnocaChallengeV2.Handlers
{
    public class GetFirmListHandler : IRequestHandler<GetFirmListQuery, List<Firm>>
    {
        private readonly IFirmRepository _firmRepository;

        public GetFirmListHandler(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }

        public async Task<List<Firm>> Handle(GetFirmListQuery query, CancellationToken cancellationToken)
        {
            return await _firmRepository.GetFirmListAsync();
        }
    }
}
