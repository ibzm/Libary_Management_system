using Libary_Management_System;
using System.Security.Policy;
using System.Text.Json.Nodes;

namespace Library_Management_System
{

    public partial class UserAdd : Form
    {
       
        private Librarian Librarian;

        public UserAdd(JsonObject? item = null)
        {
            Librarian = new Librarian();
            InitializeComponent();

            option.Items.AddRange(new[] { "Book", "Magazine" }); 
            option.SelectedIndex = 0; 

            
            AvailableCopies.Minimum = 0;
            TotalCopies.Minimum = 0;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (option.SelectedItem.ToString() == "Book")
            {
              
                if (int.TryParse(AvailableCopies.Text, out int availableCopies) &&
                    int.TryParse(TotalCopies.Text, out int totalCopies))
                {
                    Book book = new Book()
                    {
                        Id = 0, 
                        Type = option.SelectedItem.ToString(),
                        Title = Title.Text,
                        Author = Author.Text,
                        Genre = Genre.Text,
                        AvailableCopies = availableCopies,
                        TotalCopies = totalCopies
                    };

                    Librarian.AddBook(book);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Available Copies and Total Copies.");
                }
            }
            else if (option.SelectedItem.ToString() == "Magazine")
       
                if (int.TryParse(AvailableCopies.Text, out int availableCopies) &&
                    int.TryParse(TotalCopies.Text, out int totalCopies))
                {
                    Magazine magazine = new Magazine()
                    {
                        Id = 0, 
                        Type = option.SelectedItem.ToString(),
                        Title = Title.Text,
                        Publisher = Author.Text,
                        Category = Genre.Text,
                        AvailableCopies = availableCopies,
                        TotalCopies = totalCopies
                    };

                    Librarian.AddMagazine(magazine);
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Available Copies and Total Copies.");
                }
            }
        }
    }

