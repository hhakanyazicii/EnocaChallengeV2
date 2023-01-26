using System.ComponentModel.DataAnnotations.Schema;

namespace EnocaChallengeV2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string orderedBy { get; set; }
        public DateTime orderDate { get; set; }
        [ForeignKey("Firm")]
        public int FirmId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
