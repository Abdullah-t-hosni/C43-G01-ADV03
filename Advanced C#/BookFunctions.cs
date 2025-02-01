namespace Advanced_C_
{
    public static class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthors(Book b)
        {
            return string.Join(", ", b.Authors);
        }

        public static string GetISBN(Book b)
        {
            return b.ISBN;
        }

        public static DateTime GetPublicationDate(Book b)
        {
            return b.PublicationDate;
        }
    }
}
