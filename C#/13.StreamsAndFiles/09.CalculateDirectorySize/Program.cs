internal class Program
{
    private static void Main(string[] args)
    {
        var folder = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\09.CalculateDirectorySize";

        var size = GetTotalBytesSize(folder);
        Console.WriteLine($"Total size: {size} bytes");

    }

    private static long GetTotalBytesSize(string folder)
    {
        long size = 0;

        var files = Directory.GetFiles(folder);
        foreach (var fileName in files)
        {
            var file = new FileInfo(fileName);
            size += file.Length;
        }
        
        var subDirs = Directory.GetDirectories(folder);

        if (subDirs.Length > 0)
        {
            foreach (var dir in subDirs)
            {
                size += GetTotalBytesSize(dir);
            }
        }

        return size;
    }
}