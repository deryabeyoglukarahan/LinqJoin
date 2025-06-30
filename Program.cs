namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yazarlar listesi
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "George Orwell" },
                new Author { AuthorId = 2, Name = "J.K. Rowling" },
                new Author { AuthorId = 3, Name = "Fyodor Dostoevsky" }
            };

            // Kitaplar listesi
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "1984", AuthorId = 1 },
                new Book { BookId = 2, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 2 },
                new Book { BookId = 3, Title = "Crime and Punishment", AuthorId = 3 },
                new Book { BookId = 4, Title = "Animal Farm", AuthorId = 1 }
            };

            // LINQ join sorgusu
            var query = from book in books
                        join author in authors on book.AuthorId equals author.AuthorId
                        select new
                        {
                            BookTitle = book.Title,
                            AuthorName = author.Name
                        };

            // Sonuçları yazdır
            Console.WriteLine("Kitaplar ve Yazarları:");
            Console.WriteLine("-----------------------");
            foreach (var item in query)
            {
                Console.WriteLine($"Kitap: {item.BookTitle} | Yazar: {item.AuthorName}");
            }
        }
    }
}