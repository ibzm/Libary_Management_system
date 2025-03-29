
using System.Text.Json;


namespace Library_Management_System
{
    public class Library
    {
        private readonly string _filePath = "library_data.json";

        public List<LibraryItem> SearchBooks(string criteria, string searchTerm)
        {
            List<LibraryItem> searchItems = new List<LibraryItem>();

            try
            {
                string jsonString = File.ReadAllText(_filePath);
                using (JsonDocument document = JsonDocument.Parse(jsonString))
                {
                    var itemsArray = document.RootElement.GetProperty("Items").EnumerateArray();

                    var options = new JsonSerializerOptions
                    {
                        Converters = { new LibraryItemConverter() } 
                    };

                    foreach (var itemJson in itemsArray)
                    {
                        string type = itemJson.GetProperty("Type").GetString();

                        if (type == "Book")
                        {
                            var book = JsonSerializer.Deserialize<Book>(itemJson.GetRawText(), options);
                            if (MatchesCriteria(book, criteria, searchTerm))
                            {
                                searchItems.Add(book);
                            }
                        }
                        else if (type == "Magazine")
                        {
                            var magazine = JsonSerializer.Deserialize<Magazine>(itemJson.GetRawText(), options);
                            if (MatchesCriteria(magazine, criteria, searchTerm))
                            {
                                searchItems.Add(magazine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return searchItems;
        }

        private bool MatchesCriteria(LibraryItem item, string criteria, string searchTerm)
        {
            return criteria.ToLower() switch
            {
                "title" => item.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                "id" when int.TryParse(searchTerm, out int id) => item.Id == id,
                "author/publisher" => item is Book book && book.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                    || item is Magazine magazine && magazine.Publisher.Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                "genre/category" => item is Book b && b.Genre.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                   || item is Magazine m && m.Category.Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                _ => false
            };
        }

        public List<LibraryItem> Reading()
        {
            List<LibraryItem> results = new List<LibraryItem>();

            try
            {
                string jsonString = File.ReadAllText(_filePath);

                var options = new JsonSerializerOptions
                {
                    Converters = { new LibraryItemConverter() } 
                };

                using (JsonDocument document = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = document.RootElement;
                    JsonElement itemsElement = root.GetProperty("Items");

                    foreach (JsonElement item in itemsElement.EnumerateArray())
                    {
                     
                        var libraryItem = JsonSerializer.Deserialize<LibraryItem>(item.GetRawText(), options);
                        results.Add(libraryItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return results;
        }

        public bool Login(string username, string password)
        {
            List<Member> members = new List<Member>();
            bool isAuthenticated = false;

            try
            {
                string jsonString = File.ReadAllText(_filePath);
                var jsonDocument = JsonDocument.Parse(jsonString);
                var root = jsonDocument.RootElement;

                var membersArray = root.GetProperty("Members").EnumerateArray();
                foreach (var memberJson in membersArray)
                {
                    var member = new Member
                    {
                        ID = memberJson.GetProperty("ID").GetInt32(),
                        Username = memberJson.GetProperty("Username").GetString(),
                        Password = memberJson.GetProperty("Password").GetString()
                    };
                    members.Add(member);
                }

       
                var foundMember = members.FirstOrDefault(m => m.Username == username && m.Password == password);

                if (foundMember != null)
                {
                    Member.LoggedInMember = foundMember; 
                    isAuthenticated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in members {ex.Message}");
            }

            return isAuthenticated;  
        }
      
        public LibraryItem GetItemById(int itemId)
        {
            List<LibraryItem> allItems = Reading();

            
            return allItems.FirstOrDefault(item => item.Id == itemId);
        }

    }

   
}
