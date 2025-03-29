
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Library_Management_System
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }

        public LibraryItem(int id, string type, string title)
        {
            Id = id;
            Type = type;
            Title = title;
        }

  
        public LibraryItem() 
        { 

        }
    }
    public class LibraryData
    {
        public List<LibraryItem> Items { get; set; }
        public List<Member> Members { get; set; }
    }

    public class LibraryItemConverter : JsonConverter<LibraryItem>
    {
        public override LibraryItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;

               
                string type = root.GetProperty("Type").GetString();

               
                LibraryItem item = type switch
                {
                    "Book" => JsonSerializer.Deserialize<Book>(root.GetRawText(), options),
                    "Magazine" => JsonSerializer.Deserialize<Magazine>(root.GetRawText(), options),
                    _ => throw new InvalidOperationException($"Unsupported type: {type}")
                };

                return item;
            }
        }

        public override void Write(Utf8JsonWriter writer, LibraryItem value, JsonSerializerOptions options)
        {
     
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }

}





