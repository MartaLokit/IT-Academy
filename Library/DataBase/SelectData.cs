
using Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DataBase
{
    public class SelectData : ConnectionString
    {
        private SqlCommand command;
        private DataTable table;
        public SqlDataReader reader;
        public List<Book> datas = new List<Book>();
        public IEnumerator<string> GetEnumerator()
        {
            command = new SqlCommand("Select Author.LastName,Author.[Name],Author.FirstName,Book.[BookName],Genre.[Name]" +
            " From Book" +
            " join Author on Author.ID = Book.IDAuthor" +
            " join Genre on Genre.ID = Book.IDGenre", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                var author = new Author()
                {
                    LastName = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2)
                };
                var genre = new Genre()
                {
                    Name = reader.GetString(4),
                    //MinReaderAge = reader.GetInt32(5),
                };
                datas = new List<Book>()
                {
                    new Book(reader.GetValue(3).ToString(),author,genre)
                };

                foreach (var data in datas)
                {
                    yield return $"{author.FirstName} " +
                        $"{author.LastName} " +
                        $"{author.Surname} " +
                        $"{data.BookName} " +
                        $"{genre.Name} ";
                }

            }
            reader.Close();
        }
    }
}
