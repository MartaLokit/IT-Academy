namespace Library.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinReaderAge { get; set; }
        public Genre()
        {
                
        }
        public Genre(string name,int minAge)
        {
            Name = name;
            MinReaderAge = minAge;
        }
    }
}
