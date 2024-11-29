namespace InventoryManagmentSystem.JsonIOManager
{
    using InventoryManagmentSystem.Models;
    using System.Text.Json;
    using System.Text;

    public class IOManager
    {
        private readonly string folderName;
        private readonly string fileName;
        public string FilePath { get; set; }
        public IOManager(string folderName, string fileName)
        {
            this.folderName = folderName;
            this.fileName = fileName;
            FilePath = GetIOPath(this.folderName, this.fileName);
        }
        public List<InventoryItem> LoadData()
        {
            try
            {
                using var stream = new FileStream(FilePath, FileMode.Open);
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

        public void UpdateData(List<InventoryItem> items)
        {
            var jsonText = JsonSerializer.Serialize(items);
            Console.WriteLine(jsonText);

            using var stream = new FileStream(FilePath, FileMode.Create);

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
