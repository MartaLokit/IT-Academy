using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? BookName { get; set; }
        Author Author;
        Genre Genres;
        public Book(string bookName,Author author,Genre genre)
        {
            BookName = bookName;
            Author = author;
            Genres = genre;
        }
    }
}
