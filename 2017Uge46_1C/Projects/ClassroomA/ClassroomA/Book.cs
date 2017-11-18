namespace ClassroomA
{
    public class Book : DomainBase<string>
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _noOfPages;

        public Book(string isbn, string title, string author, int noOfPages) 
            : base(isbn)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
            _noOfPages = noOfPages;
        }

        public string ISBN { get { return _isbn; } }
        public string Title { get { return _title; } }
        public string Author { get { return _author; } }
        public int NoOFPages { get { return _noOfPages; } }
    }
}