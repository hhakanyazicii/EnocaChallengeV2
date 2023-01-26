using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Queries;
using EnocaChallengeV2.Repositories;
using MediatR;

namespace EnocaChallengeV2.Handlers
{
    public class CreateFirmHandler : IRequestHandler<CreateFirmCommand, Firm>
    {
        private readonly IFirmRepository _firmRepository;
        public CreateFirmHandler(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }
        public async Task<Firm> Handle(CreateFirmCommand command, CancellationToken cancellationToken)
        {
            var firm = new Firm()
            {
                FirmName = command.FirmName,
                isVerified = command.isVerified,
                startTime = command.startTime,
                endTime = command.endTime
            };

            return await _firmRepository.AddFirmAsync(firm);
        }
    }
}
