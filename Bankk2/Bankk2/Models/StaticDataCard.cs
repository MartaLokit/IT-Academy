using System.ComponentModel.DataAnnotations;

namespace Bankk2.Models
{
    public static class StaticDataCard
    {
        public static string CardNumber { get; set; }
        [MaxLength(4)]
        public static int CVV { get; set; }
        public static string BeforeDate { get; set; }
        public static string UserEmail { get; set; }
    }
}
