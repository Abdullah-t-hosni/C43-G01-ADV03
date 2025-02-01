namespace Advanced_C_
{
    public static class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }
    }
}
