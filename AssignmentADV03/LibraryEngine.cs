using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV03
{
    internal class LibraryEngine
    {
        public delegate string BookDelegate(Book b);

        public static void ProcessBooks(List<Book> books, BookDelegate func)
        {
            foreach (var book in books)
            {
                Console.WriteLine(func(book));
            }
        }
    }
}
