using System.ComponentModel.DataAnnotations.Schema;

namespace Bankk2.Models
{
    public class DataUserS
    {
        public int ID { get; set; }
        public string NumberPhone { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bithday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
