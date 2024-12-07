namespace ShapeAreaCalculator.DataSerialization
{
    using System.Collections.Generic;
    using System.Text.Json;
    using ShapeAreaCalculator.Models;

    public class DataSerializer
    {
        const string folderName = "Data";
        const string fileName = "data.json";

        private static readonly string filePath = GetIOPath(folderName, fileName);
        private static readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            Converters = { new ShapeConverter() }
        };

        public static List<Shape> LoadData()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContent = reader.ReadToEnd();
                var deserialized = JsonSerializer.Deserialize<List<Shape>>(fileContent, options);

                return deserialized;
            }
            catch (IOException)
            {
                throw new IOException("JSON loading error!");
            }
            finally
            {
                reader?.Close();
            }
        }

        public static void SaveData(List<Shape> shapes)
        {
            TextWriter writer = null;
            try
            {
                var jsonText = JsonSerializer.Serialize(shapes, options);
                writer = new StreamWriter(filePath);
                writer.Write(jsonText);
            }
            catch (IOException)
            {
                throw new IOException("JSON saving error!");
            }
            finally
            {
                writer?.Close();
            }
        }

        public static string GetIOPath(string folderName, string fileName)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var folderFullName = Path.Combine(projectPath, folderName);
            Directory.CreateDirectory(folderFullName);

            return Path.Combine(folderFullName, fileName);
        }
    }
}
