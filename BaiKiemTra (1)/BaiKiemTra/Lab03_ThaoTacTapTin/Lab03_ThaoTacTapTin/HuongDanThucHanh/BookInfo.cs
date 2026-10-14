namespace HuongDanThucHanh
{
    public class BookInfo
    {
        public string ISBN { get; set; }
        public int YearPublished { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }

        public BookInfo(string isbn, int yearPublished, string title, string author, string publisher, double price)
        {
            ISBN = isbn;
            YearPublished = yearPublished;
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
        }
    }
}
