using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Repositories;
using MediatR;

namespace EnocaChallengeV2.Handlers
{
    public class UpdateFirmVerificationHandler : IRequestHandler<UpdateFirmVerificationCommand, int>
    {
        private readonly IFirmRepository _firmRepository;
        public UpdateFirmVerificationHandler(IFirmRepository firmRepository)
        {
            _firmRepository = firmRepository;
        }
        public async Task<int> Handle(UpdateFirmVerificationCommand command, CancellationToken cancellationToken)
        {
            var firm = await _firmRepository.GetFirmByIdAsync(command.Id);
            if (firm == null)
                return default;

            firm.isVerified = command.isVerified;

            return await _firmRepository.UpdateFirmDateAsync(firm);
        }
    }
}
