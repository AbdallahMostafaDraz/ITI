namespace Demo2
{
    public class LibraryEngine
    {
        public delegate string bookDel(Book book);
        public static void ProcessBooks(List<Book> bList, bookDel fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooks(Func<Book, string> fPtr, List<Book> bList)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
