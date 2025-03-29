using System.Text.Json;


namespace Library_Management_System
{
    public class Member : Person
    {
        public static Member LoggedInMember { get; set; }

        public List<LibraryItem> BorrowedItems { get; set; } = new List<LibraryItem>();
        public static void LoadMemberData()
        {
            if (LoggedInMember == null)
            {
                MessageBox.Show("No user is logged in.");
                return;
            }

            string filePath = "library_data.json";
            try
            {
                string jsonString = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() }
                };

                var data = JsonSerializer.Deserialize<LibraryData>(jsonString, options);

                var loggedInMember = data.Members.FirstOrDefault(m => m.ID == LoggedInMember.ID);
                if (loggedInMember != null)
                {
                    LoggedInMember.BorrowedItems = loggedInMember.BorrowedItems;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading login details {ex.Message}");
            }
        }

  
  


        public bool BorrowItem(LibraryItem item)
        {
            if (LoggedInMember == null)
            {
                MessageBox.Show("Please log in first.");
                return false;
            }

         
            if (LoggedInMember.BorrowedItems.Any(borrowedItem => borrowedItem.Id == item.Id))
            {
                MessageBox.Show("You have already borrowed this item");
                return false;
            }

           
            if (item is Book book && book.AvailableCopies > 0)
            {
                book.AvailableCopies--; 
                LoggedInMember.BorrowedItems.Add(book); 
                UpdateJson(); 
                MessageBox.Show("Item borrowed successfully");
                return true; 
            }
            else if (item is Magazine magazine && magazine.AvailableCopies > 0)
            {
                magazine.AvailableCopies--; 
                LoggedInMember.BorrowedItems.Add(magazine); 
                UpdateJson(); 
                MessageBox.Show("Item borrowed successfully");
                return true; 
            }
            else
            {
                MessageBox.Show("Item is unavailable.");
                return false;
            }
        }

        public bool ReturnItem(LibraryItem item)
        {
            if (LoggedInMember == null)
            {
                MessageBox.Show("Please log in first.");
                return false;
            }

            var borrowedItem = LoggedInMember.BorrowedItems.FirstOrDefault(b => b.Id == item.Id);
            if (borrowedItem == null)
            {
                MessageBox.Show("You haven't borrowed this item.");
                return false;
            }

            
            if (item is Book book)
            {
                book.AvailableCopies++; 
                LoggedInMember.BorrowedItems.Remove(book); 
            }
            else if (item is Magazine magazine)
            {
                magazine.AvailableCopies++; 
                LoggedInMember.BorrowedItems.Remove(magazine); 
            }

            UpdateJson(); 
            MessageBox.Show("Item returned successfully!");
            return true;
        }

        private void UpdateJson()
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

               
                var loggedInMember = data.Members.FirstOrDefault(m => m.ID == Member.LoggedInMember.ID);
                if (loggedInMember != null)
                {
                 
                    loggedInMember.BorrowedItems = Member.LoggedInMember.BorrowedItems.Select(item => item).ToList();

              
                    foreach (var borrowedItem in loggedInMember.BorrowedItems)
                    {
                        if (borrowedItem is Book borrowedBook)
                        {
                            var originalBook = data.Items.OfType<Book>().FirstOrDefault(i => i.Id == borrowedBook.Id);
                            if (originalBook != null)
                            {
                                originalBook.AvailableCopies = borrowedBook.AvailableCopies; 
                            }
                        }
                        else if (borrowedItem is Magazine borrowedMagazine)
                        {
                            var originalMagazine = data.Items.OfType<Magazine>().FirstOrDefault(i => i.Id == borrowedMagazine.Id);
                            if (originalMagazine != null)
                            {
                                originalMagazine.AvailableCopies = borrowedMagazine.AvailableCopies; 
                            }
                        }
                    }
                }

              
                string updatedJsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, updatedJsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating json {ex.Message}");
            }
        }


    }

}


    



