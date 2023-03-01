using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryOOPnew
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }
        public string NameSurname { get; set; }
        public List<Book> Books { get; set; }
        public DateTime Birthday { get; set; }
    }
}
