namespace CompanyDbEFCore.Data
{
    using CompanyDbEFCore.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public class CompanyDbContext : DbContext
    {
        private readonly string _sqlServer = "Server=.;Database=CompanyDbEFCore;Trusted_Connection=True;TrustServerCertificate=True;";
        
        // Or can be used configuration file, named App.config

        //<configuration>
        //    <connectionString>
        //        <add name= "CompanyDbEFCore"
        //        connectionString="Server=.;Database=CompanyDbEFCore;Trusted_Connection=True;TrustServerCertificate=True;"
        //        providerName="System.Data.SqlClient" />
        //    </connectionString>
        //</configuration>

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_sqlServer);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t =>t.Employee)
                .WithMany(e => e.Transactions)
                .HasForeignKey(t => t.EmployeeId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Supplier)
                .WithMany(s => s.Transactions)
                .HasForeignKey(t => t.SupplierId);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Client)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.ClientId);
        }
    }
}
