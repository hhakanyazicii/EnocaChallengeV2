using EnocaChallengeV2.Models;
using MediatR;

namespace EnocaChallengeV2.Commands
{
    public class UpdateFirmDateCommand : IRequest<int> {
        public int Id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public UpdateFirmDateCommand(int id, DateTime StartTime, DateTime EndTime)
        {
            Id = id;
            startTime = StartTime;
            endTime = EndTime;
        }
    }
        
    
}
