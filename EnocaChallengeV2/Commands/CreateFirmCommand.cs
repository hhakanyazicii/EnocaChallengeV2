using EnocaChallengeV2.Handlers;
using EnocaChallengeV2.Models;
using MediatR;

namespace EnocaChallengeV2.Commands
{
    public class CreateFirmCommand : IRequest<Firm>
    {
        public string FirmName { get; set; }
        public int isVerified { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public CreateFirmCommand(string firmName, int IsVerified, DateTime StartTime, DateTime EndTime)
        {
            FirmName = firmName;
            isVerified = IsVerified;
            startTime = StartTime; ;
            endTime = EndTime;
        }
    }
}
