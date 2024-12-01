namespace InventoryManagmentSystem.JsonIOManager
{
    using InventoryManagmentSystem.Models;
    using System.Text.Json;
    using System.Text;

    public class IOManager
    {

        const string folderName = "Dataset";
        const string fileName = "data.json";

        private static string filePath = GetIOPath(folderName, fileName);
        public static List<InventoryItem> LoadData()
        {
            try
            {
                using var stream = new FileStream(filePath, FileMode.Open);
                byte[] buffer = new byte[stream.Length];

                while (true)
                {
                    int bytesRead = stream.Read(buffer);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                }

                stream.Close();

                var jsonDeserializedText = Encoding.ASCII.GetString(buffer);
                var options = new JsonSerializerOptions() { WriteIndented = true };
                var deserializedItems = JsonSerializer.Deserialize<List<InventoryItem>>(jsonDeserializedText, options);

                return deserializedItems;
            }
            catch (IOException)
            {
                throw new IOException("JSON loading error!");
            }
        }

        public static void SaveData(List<InventoryItem> items)
        {
            var jsonText = JsonSerializer.Serialize(items);
            Console.WriteLine(jsonText);

            using var stream = new FileStream(filePath, FileMode.Create);

            byte[] bytes = Encoding.UTF8.GetBytes(jsonText);
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
        }

        public static string GetIOPath(string folderName, string fileName)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string folderFullName = Path.Combine(projectPath, folderName);
            Directory.CreateDirectory(folderFullName);

            string path = Path.Combine(folderFullName, fileName);

            return path;
        }
    }
}
