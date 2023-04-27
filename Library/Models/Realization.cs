namespace Library.Models
{
    public class Realization
    {
        public List<Author> author;
        public List<Genre> genre;
        public List<Book> book;
        public Realization()
        {
            RealizationBook();
        }
        private void RealizationAuthor()
        {
            author = new List<Author>
            {
                new Author("Пушкин", "Александр","Сергеевич"),//0
                new Author("Петров", "Александр","Андреевич"),//1
                new Author("Ахматова", "Анна","Андреевна"),//2
                new Author("Есенин", "Сергей","Алевсандрович"),//3
                new Author("Джоан", "Роулинг",null),//4
                new Author("Рик", "Риордан",null)//5
            };
        }
        public void RealizationBook()
        {
            RealizationGenre();
            RealizationAuthor();
            book = new List<Book>
            {
                new Book("Сказка о царе Салтане", author[0],genre[5]),
                new Book("Зановородиться", author[1],genre[0]),
                new Book("Жди меня", author[2],genre[1]),
                new Book("Я последний поэт деревни", author[3],genre[1]),
                new Book("Гарри Поттер", author[4],genre[2]),                
                new Book("Перси Джексон", author[5],genre[2])
            };
        }
        private void RealizationGenre()
        {
            genre = new List<Genre>
            {
                new Genre("Сказка в стихах",0),
                new Genre("Современная литература",14),
                new Genre("Стихотворение",12),
                new Genre("Драмматургия",10),
                new Genre("Фантастика",16),
                new Genre("Подростковая литература",16),
                
            };
        }
    }
}
