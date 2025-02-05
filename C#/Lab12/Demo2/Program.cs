using System.Security.Cryptography.X509Certificates;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("123A", "C# Fundamentals", ["Abdallah Mostafa", "Mohamed Ahmd"], new DateTime(2012, 11, 25), 1500m),
                new Book("456B", "Object Oreintd Programming", ["Ibrahim", "Khaled"], new DateTime(2015, 12, 1), 2000m),
                new Book("789B", "Data Structure", ["Abdelrahman", "Mohamed Ali"], new DateTime(2020, 2, 28), 2500m)
            };

            Console.WriteLine("All Books: ");
            LibraryEngine.ProcessBooks(books, (book) => book.ToString());
            Console.WriteLine("----------------------");
            Console.WriteLine("ISBNs: ");
            LibraryEngine.ProcessBooks(books, delegate (Book book) { return BookFunctions.GetISBN(book); });
            Console.WriteLine("----------------------");

            Console.WriteLine("Publication Dates: ");
            LibraryEngine.ProcessBooks(books, (book) => BookFunctions.GetPublicationDate(book));
            Console.WriteLine("----------------------");

            Console.WriteLine("Titles: ");
            LibraryEngine.ProcessBooks(GetBookTitles, books);

        }

        static string GetBookTitles(Book book)
        {
            return book.Title;
        }
    }
}
