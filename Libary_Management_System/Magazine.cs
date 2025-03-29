namespace Library_Management_System
{
    public class Magazine : LibraryItem
    {
        public string Publisher { get; set; }
        public string Category { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }

        public Magazine(int id, string title, string publisher, string category, int availableCopies, int totalCopies)
            : base(id, "Magazine", title)
        {
            Publisher = publisher;
            Category = category;
            AvailableCopies = availableCopies;
            TotalCopies = totalCopies;
        }

        public Magazine()
        {
        }
    }
}
