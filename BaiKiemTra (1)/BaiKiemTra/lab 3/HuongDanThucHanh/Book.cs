namespace HuongDanThucHanh
{
    public class Book
    {
        public string ISBN { get; set; } = "";
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public Book() { }

        public Book(string isbn, string title, string author, decimal price, int yearPublished)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
            YearPublished = yearPublished;
        }
    }
}
