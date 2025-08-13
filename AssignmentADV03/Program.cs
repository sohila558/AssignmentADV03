namespace AssignmentADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> myBooks = new List<Book>()
            {
                new Book("1", "C# Basics", new[] { "Mahmoud" }, new DateTime(2020, 1, 10), 100),
                new Book("2", "OOP", new[] { "Sara", "Ali" }, new DateTime(2021, 5, 15), 150)
            };

            Console.WriteLine("1. User Defined Delegate");
            LibraryEngine.ProcessBooks(myBooks, BookFunctions.GetTitle);

            Console.WriteLine("2. Built-in Func Delegate");
            Func<Book, string> f = BookFunctions.GetAuthors;
            foreach (var book in myBooks)
                Console.WriteLine(f(book));

            Console.WriteLine("3. Anonymous Method");
            LibraryEngine.ProcessBooks(myBooks, delegate (Book b) { return b.Price.ToString(); });

            Console.WriteLine("4. Lambda Expression");
            LibraryEngine.ProcessBooks(myBooks, b => b.ISBN);
        }
    }
}
