namespace Library_Management_System
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }
        public int PageCount { get; set; }

        public Book(int id, string title, string author, string genre, int availableCopies, int totalCopies, int pageCount)
            : base(id, "Book", title)
        {
            Author = author;
            Genre = genre;
            AvailableCopies = availableCopies;
            TotalCopies = totalCopies;
            PageCount = pageCount;
        }

        public Book()
        { 
        }
    }
}

