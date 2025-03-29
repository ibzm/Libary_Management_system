namespace Library_Management_System
{
    using System;
    using System.Windows.Forms;
    using Libary_Management_System;

    public partial class Form1 : Form
    {
        public Library library;

        public Form1() 
        {
            library = new Library();
            InitializeComponent();

            var items = library.Reading(); 
            dataGridView1.Rows.Clear(); 

            foreach (var item in items)
            {
                if (item is Book book)
                {
                
                    dataGridView1.Rows.Add(
                        book.Id,
                        "Book",  
                        book.Title,
                        book.Author,
                        book.Genre,
                        book.AvailableCopies,
                        book.TotalCopies
                    );
                }
                else if (item is Magazine magazine)
                {
           
                    dataGridView1.Rows.Add(
                        magazine.Id,
                        "Magazine", 
                        magazine.Title,
                        magazine.Publisher,
                        magazine.Category,
                        magazine.AvailableCopies,
                        magazine.TotalCopies
                    );
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
           
                var selectedRow = dataGridView1.SelectedRows[0];

                int id = 0;
                int availableCopies = 0;
                int totalCopies = 0;

                if (selectedRow.Cells[0].Value != null)
                {
                    int.TryParse(selectedRow.Cells[0].Value.ToString(), out id);
                }

                if (selectedRow.Cells[4].Value != null)
                {
                    int.TryParse(selectedRow.Cells[5].Value.ToString(), out availableCopies);
                }

                if (selectedRow.Cells[5].Value != null)
                {
                    int.TryParse(selectedRow.Cells[6].Value.ToString(), out totalCopies);
                }

                string type = selectedRow.Cells[1].Value?.ToString(); 

                LibraryItem itemToEdit = null;

                if (type == "Book")
                {
                    itemToEdit = new Book
                    {
                        Id = id,
                        Title = selectedRow.Cells[2].Value?.ToString(),
                        Author = selectedRow.Cells[3].Value?.ToString(),
                        Genre = selectedRow.Cells[4].Value?.ToString(),
                        AvailableCopies = availableCopies,
                        TotalCopies = totalCopies
                    };
                }
                else if (type == "Magazine")
                {
                    itemToEdit = new Magazine
                    {
                        Id = id,
                        Title = selectedRow.Cells[2].Value?.ToString(),
                        Publisher = selectedRow.Cells[3].Value?.ToString(),
                        Category = selectedRow.Cells[4].Value?.ToString(),
                        AvailableCopies = availableCopies,
                        TotalCopies = totalCopies
                    };
                }

                if (itemToEdit != null)
                {
                    EditItem editForm = new EditItem(itemToEdit, library);
                    editForm.ShowDialog();
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Invalid item type.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }



        public void RefreshDataGrid()
        {
            var items = library.Reading(); 

            dataGridView1.Rows.Clear(); 

            foreach (var item in items)
            {
                if (item is Book book)
                {
           
                    dataGridView1.Rows.Add(book.Id, "Book", book.Title, book.Author, book.Genre, book.AvailableCopies, book.TotalCopies);
                }
                else if (item is Magazine magazine)
                {
                  
                    dataGridView1.Rows.Add(magazine.Id, "Magazine", magazine.Title, magazine.Publisher, magazine.Category, magazine.AvailableCopies, magazine.TotalCopies);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                
                if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int id))
                {
           
                    Librarian librarian = new Librarian();

                    librarian.DeleteItem(id);

                   
                    dataGridView1.Rows.Remove(selectedRow);
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Invalid Id for the selected row");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
            RefreshDataGrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserAdd UserAdd = new UserAdd(); 
            UserAdd.Show();
            RefreshDataGrid();

        }
    }
}
