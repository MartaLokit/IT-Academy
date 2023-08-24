using System.ComponentModel.DataAnnotations.Schema;

namespace Bankk2.Models
{
    public class DaraCard
    {
        public string CardNumber { get; set; }
        public int CVV { get; set; }
        public string BeforeDate { get; set; }
        public string UserEmail { get; set; }
        public double Balance { get; set; }
    }
}
