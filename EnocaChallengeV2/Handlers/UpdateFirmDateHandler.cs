using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Queries;
using EnocaChallengeV2.Repositories;
using MediatR;

namespace EnocaChallengeV2.Handlers
{
    public class UpdateFirmDateHandler : IRequestHandler<UpdateFirmDateCommand, int>
    {
        private readonly IFirmRepository _firmRepository;
        public UpdateFirmDateHandler(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }
        public async Task<int> Handle(UpdateFirmDateCommand command, CancellationToken cancellationToken)
        {
            var firm = await _firmRepository.GetFirmByIdAsync(command.Id);
            if (firm == null)
                return default;

            firm.startTime = command.startTime;
            firm.endTime = command.endTime;

            return await _firmRepository.UpdateFirmDateAsync(firm);
        }
    }
}
