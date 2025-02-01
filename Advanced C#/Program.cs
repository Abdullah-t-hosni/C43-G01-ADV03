namespace Advanced_C_
{
    public delegate string BookDelegate(Book b);

    internal static class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>
        {
            new Book("123-456", "C# Programming", new string[] { "John Doe" }, new DateTime(2020, 1, 1)),
            new Book("789-012", "Advanced C#", new string[] { "Jane Smith" }, new DateTime(2021, 2, 2))
        };

            Console.WriteLine("Using Custom Delegate:");
            BookDelegate customDelegate = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, b => customDelegate(b));

            Console.WriteLine("\nUsing BCL Delegate:");
            Func<Book, string> bclDelegate = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, bclDelegate);

            Console.WriteLine("\nUsing Anonymous Method:");
            Func<Book, string> anonymousDelegate = delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(books, anonymousDelegate);

            Console.WriteLine("\nUsing Lambda Expression:");
            Func<Book, DateTime> lambdaDelegate = b => b.PublicationDate;
            LibraryEngine.ProcessBooks(books, b => lambdaDelegate(b).ToString());
        }
    }
}

