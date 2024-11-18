using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        var archivePath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\13.ExtractSpecificFilesFromZipArchive\\archive.zip";
        var extractPath = "C:\\Users\\Dilyana\\Documents\\GitHub\\Sirma-Academy\\C#\\13.StreamsAndFiles\\13.ExtractSpecificFilesFromZipArchive\\extracted_files";

        Directory.CreateDirectory(extractPath);
        using ZipArchive archive = ZipFile.OpenRead(archivePath);
        foreach (ZipArchiveEntry entry in archive.Entries)
        {
            if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
            {
                entry.ExtractToFile(Path.Combine(extractPath, entry.Name));
            }
        }
    }
}