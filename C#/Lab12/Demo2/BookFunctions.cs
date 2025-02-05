namespace Demo2
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }
        public static string GetAuthors(Book B)
        {
            string s = "";
            foreach (var author in B.Authors)
                s += $"{author}, ";
            return s;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString(); 
        }
        public static string GetPublicationDate(Book B)
        {
            return B.PublicationDate.ToString("dd/MM/yyyy");    
        }
    }
}
