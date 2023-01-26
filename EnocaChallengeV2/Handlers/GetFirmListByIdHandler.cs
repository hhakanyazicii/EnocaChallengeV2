using EnocaChallengeV2.Models;
using EnocaChallengeV2.Queries;
using EnocaChallengeV2.Repositories;
using MediatR;

namespace EnocaChallengeV2.Handlers
{
    public class GetFirmListByIdHandler : IRequestHandler<GetFirmByIdQuery, Firm>
    {
        private readonly IFirmRepository _firmRepository;

        public GetFirmListByIdHandler(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }

        public async Task<Firm> Handle(GetFirmByIdQuery query, CancellationToken cancellationToken)
        {
            return await _firmRepository.GetFirmByIdAsync(query.Id);
        }
    }
}
