namespace Library_Management_System
{
    public  class Person
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual void BorrowItem(LibraryItem item)
        {
           
        }
        public virtual void ReturnItem(LibraryItem item)
        {

        }
        public void DisplayInfo()
        {

        }
    }
}