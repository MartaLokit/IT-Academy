namespace Book.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Author(string firstName, string lastname, string surName)
        {
            LastName = lastname;
            FirstName = firstName;
            Surname = surName;
        }
        public Author()
        {

        }
    }
}
