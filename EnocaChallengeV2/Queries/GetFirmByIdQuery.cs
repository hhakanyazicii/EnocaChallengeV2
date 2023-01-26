using EnocaChallengeV2.Models;
using MediatR;

namespace EnocaChallengeV2.Queries
{
    public class GetFirmByIdQuery : IRequest<Firm>
    {
        public int Id { get; set; }
    }
}
