using MediatR;

namespace EnocaChallengeV2.Commands
{
    public class UpdateFirmVerificationCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int isVerified { get; set; }

        public UpdateFirmVerificationCommand(int id, int IsVerified)
        {
            Id = id;
            isVerified = IsVerified;
        }
    }
}
