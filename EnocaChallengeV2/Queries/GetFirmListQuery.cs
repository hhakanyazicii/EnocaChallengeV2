using EnocaChallengeV2.Models;
using MediatR;

namespace EnocaChallengeV2.Queries
{
    public class GetFirmListQuery : IRequest<List<Firm>>
    {
    }
}
