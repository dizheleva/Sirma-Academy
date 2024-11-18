using System.Text.Json;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = 
        [
            new Person("Kaloyan", 40),
            new Person("Dilyana", 35),
            new Person("Kaliya", 7),
            new Person("Daliya", 5),
            new Person("Liliya", 1)
        ];

        var outputPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\12.SerializeCustomObjectList\\persons.dat";

        var jsonText = JsonSerializer.Serialize(people);

        using var stream = new FileStream(outputPath, FileMode.Create);
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
        var deserializedMap = JsonSerializer.Deserialize<List<Person>>(jsonDeserializedText);
        foreach (var person in deserializedMap)
        {
            Console.WriteLine($"Name: {person.Name}, age: {person.Age}");
        }
    }

    class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }
}