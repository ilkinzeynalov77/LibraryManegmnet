using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryOOPnew
{
    public class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        private bool isEnd;
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"********###### WELCOME TO {Name.ToUpper()} ********######");

            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n1. Add book information");
            Console.WriteLine("2. Display book information");
            Console.WriteLine("3. List all books of given author");
            Console.WriteLine("4. List counts of books");
            Console.WriteLine("5. List of all books print");
            Console.WriteLine("6. Exit\n");

        

            while (true)
            {
                Console.Write("Select operation : ");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        this.AddBook();
                        break;
                    case "2":
                        this.DisplayBookInformation();
                        break;
                    case "3":
                        this.DisplayBookInformationAuthor();
                        break;
                    case "4":
                        this.DisplayCountOfBooks();
                        break;
                    case "5":
                        this.PrintAllBooks();
                        break;
                    case "6":
                        this.Exit();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There is no operation like this!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
                if (isEnd == true)
                    break;
                
            }
            
                

        }

        public void AddBook()
        {
            Console.Write("\nBook name : ");
            string bookName = Console.ReadLine();

            Console.Write("Book type : ");
            string bookType = Console.ReadLine();

            Console.Write("Book page count : ");
            if (int.TryParse(Console.ReadLine(), out int bookPageCount))
            {
            }
            else
                bookPageCount = 0;

            Console.Write("Book author name : ");
            string bookAuthorName = Console.ReadLine();

            Book book = new Book() 
            {
                Name = bookName,
                BookType = bookType,
                PageCount = bookPageCount,
                Author = new Author 
                {
                    NameSurname = bookAuthorName,
                    Birthday = DateTime.Now

                }
            };

            Books.Add(book);
        }

        private void Print(Book book)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"Book name : {book.Name}");
            Console.WriteLine($"Book type : {book.BookType}");
            Console.WriteLine($"Book author name : {book.Author.NameSurname}");
            Console.WriteLine($"Book page count : {book.PageCount}");
            Console.WriteLine("\n");
        }

        public void DisplayBookInformation()
        {
            Console.Write("Write book name that you want : ");
            string bookName = Console.ReadLine();
            bool a = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.ToLower().Contains(bookName.ToLower()))
                {
                    a = true;
                    Print(Books[i]);
                }
                //Eger yoxdusa cixarstin yoxdubele bir kitab
            }
            if (a == false)
            {
                Console.WriteLine("Bele bir kitab yoxdur!");
            }
        }

        public void DisplayBookInformationAuthor()
        {
            Console.Write("Write author name that you want : ");
            string authorName = Console.ReadLine();
            bool b = false;
            for (int i = 0; i < this.Books.Count; i++)
            {
                if (this.Books[i].Author.NameSurname.ToLower().Contains(authorName.ToLower()))
                {
                    b = true;
                    Print(Books[i]);
                }
               
            }
            if (b == false)
            {
                Console.WriteLine("Bele bir yazici yoxdur!");
            }
        }
        public void PrintAllBooks()
        {
            foreach(var item in Books)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void DisplayCountOfBooks()
        {
            Console.WriteLine($"Current count books in the library is {this.Books.Count}");
        }
        public void Exit()
        {
            isEnd = true;
            Console.WriteLine("Good bye");
        }
    }
}
