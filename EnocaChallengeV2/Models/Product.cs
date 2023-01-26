using System.ComponentModel.DataAnnotations.Schema;

namespace EnocaChallengeV2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int stock { get; set; }
        public float price { get; set; }
        
        [ForeignKey("Firm")]
        public int FirmId { get; set; }
    }
}
