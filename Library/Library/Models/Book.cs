using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int IDAuthor { get; set; }
        public int IDGenre { get; set; }
        public string BookName { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
