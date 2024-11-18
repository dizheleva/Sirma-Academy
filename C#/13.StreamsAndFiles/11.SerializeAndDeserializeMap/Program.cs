using System.Text;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> map = new Dictionary<string, int>
        {
            { "Sofia", 1 },
            { "Varna", 2 },
            { "Plovdiv", 3 },
            { "Shumen", 10 }
        };

        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\11.SerializeAndDeserializeMap\\map.dat";

        var jsonText = JsonSerializer.Serialize(map);

        using var stream = new FileStream(outputPath, FileMode.Create);
        //Obsolete!!!
        //var formatter = new BinaryFormatter();
        //formatter.Serialize(stream, map);
        //stream.Position = 0; // Needed as the stream is at the end after serialization
        //var deserialized = (Dictionary<string, int>)formatter.Deserialize(stream);

        byte[] bytes = Encoding.UTF8.GetBytes(jsonText);
        stream.Write(bytes, 0, bytes.Length);
        stream.Close();

        using var readingStream = new FileStream(outputPath, FileMode.Open);
        byte[] buffer = new byte[readingStream.Length];

        while (true)
        {
            int bytesRead = readingStream.Read(buffer);
            if (bytesRead == 0)
            {
                break;
            }
        }
        
        var jsonDeserializedText = Encoding.ASCII.GetString(buffer);
        var deserializedMap = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonDeserializedText);
        foreach (var item in deserializedMap)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}