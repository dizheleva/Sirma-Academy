using DbFirstEFCore.Models;

public class Program
{
    private static void Main(string[] args)
    {
        // To create Db First Approach EF Core app:

        // Create app

        // Open command line in the app folder / or Visual Studio -> Tools -> Command Line

        // Install pacages with commands:

        // -> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        // -> dotnet add package Microsoft.EntityFrameworkCore.Tools

        // Prepare connection string, provider name //Example:  "Server=.;Database=CompanyDbEFCore;Trusted_Connection=True;TrustServerCertificate=True;" provider: Microsoft.EntityFrameworkCore.SqlServer
        // Run command:

        // -> dotnet ef dbcontext scaffold "Server=.;Database=CompanyDbEFCore;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer - o Models - c AppDbContext

        // -o Models -> the folder where the entities will be created
        // -c AppDbContext -> the name of the dbContext that will be created in the app
    }
}