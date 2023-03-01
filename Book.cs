using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryOOPnew
{
    public class Book
    {
        public string Name { get; set; }

        public int PageCount { get; set; }
        public Author Author { get; set; }
        public string BookType { get; set; }
    }
}
