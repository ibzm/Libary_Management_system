using Libary_Management_System;


namespace Library_Management_System
{
    public partial class EditItem : Form
    {
        private LibraryItem itemToEdit; 
        private Library library;

        public EditItem(LibraryItem item, Library library)
        {
            InitializeComponent();
            this.itemToEdit = item;
            this.library = library;

           
            if (item is Book book)
            {
  
                Id.Text = book.Id.ToString();
                Type.Text = "Book";
                Title.Text = book.Title;
                Author.Text = book.Author;  
                Genre.Text = book.Genre;  
                TotalCopies.Text = book.TotalCopies.ToString();  
                AvailableCopies.Text = book.AvailableCopies.ToString();  
            }
            else if (item is Magazine magazine)
            {
                Id.Text = magazine.Id.ToString();
                Type.Text = "Magazine";
                Title.Text = magazine.Title;
                Author.Text = magazine.Publisher;  
                Genre.Text = magazine.Category;  
                TotalCopies.Text = magazine.TotalCopies.ToString(); 
                AvailableCopies.Text = magazine.AvailableCopies.ToString();  
            }
        }



        private void Save_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Id.Text, out int id) &&
                int.TryParse(AvailableCopies.Text, out int availableCopies) &&
                int.TryParse(TotalCopies.Text, out int totalCopies))
            {
      
                if (itemToEdit is Book book)
                {
                    book.Id = id;
                    book.Title = Title.Text;
                    book.Author = Author.Text;
                    book.Genre = Genre.Text;
                    book.AvailableCopies = availableCopies;
                    book.TotalCopies = totalCopies;
                }
                else if (itemToEdit is Magazine magazine)
                {
                    magazine.Id = id;
                    magazine.Title = Title.Text;
                    magazine.Publisher = Author.Text;
                    magazine.Category = Genre.Text;
                    magazine.AvailableCopies = availableCopies;
                    magazine.TotalCopies = totalCopies;
                }

                Librarian librarian = new Librarian();

                librarian.EditItem(itemToEdit);

                MessageBox.Show("Item updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid number values for Id, Available Copies, and Total Copies.");
            }
        }
    }

}


