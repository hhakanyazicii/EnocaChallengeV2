namespace EnocaChallengeV2.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public int isVerified { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
