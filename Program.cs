using System;


namespace libraryOOPnew
{
    public class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                NameSurname = "Aaaa Bbbb",

                Birthday = DateTime.Now
            };
            Author author2 = new Author()
            {
                NameSurname = "Cccc Dddd",
                Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(2600))
            };
            Book book1 = new Book()
            {
                Name = "ABC",
                BookType = "A type",
                PageCount = 127,
                Author = author1
            };
            Book book2 = new Book()
            {
                Name = "DFE",
                BookType = "B type",
                PageCount = 333,
                Author = author2
            };
            Book book3 = new Book()
            {
                Name = "GHI",
                BookType = "A type",
                PageCount = 568,
                Author = author1
            };
            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            Library library1 = new Library() 
            { 
                Name = "BestBook",
                Books = books
            };
           
            library1.Start();

          
        }

    }
}
