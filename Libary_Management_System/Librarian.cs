using Library_Management_System;
using System.Diagnostics;
using System.Text.Json;



namespace Libary_Management_System
{
    public class Librarian : Person
    {
        public void AddBook(Book book)
        {
            string filePath = "library_data.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() }
                };

                var data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);

                int nextId = data.Items.Max(i => i.Id) + 1;

                book.Id = nextId;

                data.Items.Add(book);

                string updatedJsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, updatedJsonString);

                MessageBox.Show("Book added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public void AddMagazine(Magazine magazine)
        {
            string filePath = "library_data.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() }
                };

                var data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);


                int nextId = data.Items.Max(i => i.Id) + 1;

                magazine.Id = nextId;

                data.Items.Add(magazine);

                string updatedJsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, updatedJsonString);

                MessageBox.Show("Magazine added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public void DeleteItem(int id)
        {
            string filePath = "library_data.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() }
                };

                var data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);

                var itemToRemove = data.Items.FirstOrDefault(item => item.Id == id);
                if (itemToRemove != null)
                {

                    data.Items.Remove(itemToRemove);

                    string updatedJsonString = JsonSerializer.Serialize(data, options);
                    File.WriteAllText(filePath, updatedJsonString);

                    MessageBox.Show("item deleted");
                }
                else
                {
                    MessageBox.Show("Item not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public void EditItem(LibraryItem updatedItem)
        {
            string filePath = "library_data.json";
    
            try
            {
                string jsonString = File.ReadAllText(filePath);


                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() },
                    WriteIndented = true
                };

                var data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);

                var itemToEdit = data.Items.FirstOrDefault(item => item.Id == updatedItem.Id);
                if (itemToEdit != null)
                {
                    itemToEdit.Title = updatedItem.Title;

                    if (updatedItem is Book book)
                    {
                        var bookToEdit = itemToEdit as Book;
                        if (bookToEdit != null)
                        {
                            bookToEdit.AvailableCopies = book.AvailableCopies;
                            bookToEdit.TotalCopies = book.TotalCopies;
                            bookToEdit.Author = book.Author;
                            bookToEdit.Genre = book.Genre;
                        }
                    }
                    else if (updatedItem is Magazine magazine)
                    {
                        var magazineToEdit = itemToEdit as Magazine;
                        if (magazineToEdit != null)
                        {
                            magazineToEdit.AvailableCopies = magazine.AvailableCopies;
                            magazineToEdit.TotalCopies = magazine.TotalCopies;
                            magazineToEdit.Publisher = magazine.Publisher;
                            magazineToEdit.Category = magazine.Category;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The item could not be found");
               
                    return;
                }
                string updatedJsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, updatedJsonString);

  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating the item: {ex.Message}");
            }

       
            }
        }
    }
 


