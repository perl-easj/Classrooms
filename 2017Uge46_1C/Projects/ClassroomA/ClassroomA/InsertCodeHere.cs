namespace ClassroomA
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            BookCatalog books = new BookCatalog();
            books.Add(new Book("ISBN123", "War and Peace", "Tolstoj", 882));
            books.Add(new Book("ISBN456", "It", "King", 587));
            // books.AddBook(new Book("ISBN456", "It", "King", 587));

            Catalog<int, DVD> dvds = new Catalog<int, DVD>();
            dvds.Add(new DVD(17, "Heat", 153));
            dvds.Add(new DVD(32, "Se7en", 110));
        }
    }
}