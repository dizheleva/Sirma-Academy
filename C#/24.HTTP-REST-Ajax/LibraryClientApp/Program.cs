using System.Net.Http.Json;
using LibraryClientApp;

public class Program
{    
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string apiUrl = "http://localhost:8080/books";

        var responce = await client.GetAsync(apiUrl);
        var books = await responce.Content.ReadFromJsonAsync<List<Book>>();

        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} - {book.Author}");
        }

        //var newBook = new { title = "Foundation", author = "Isaak Asimov" };
        //var jsonBook = JsonSerializer.Serialize(newBook);
        //var content = new StringContent(jsonBook, Encoding.UTF8, "application/json");
        //var responcePost = await client.PostAsync(apiUrl, content);

        //Console.WriteLine(books);
    }
}