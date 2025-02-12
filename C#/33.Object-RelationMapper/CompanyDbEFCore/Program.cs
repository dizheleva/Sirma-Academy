using CompanyDbEFCore.Data;
using CompanyDbEFCore.Data.Model;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        //using var dbContext = new CompanyDbContext();

        //dbContext.Database.EnsureCreated();
        //dbContext.Database.Migrate(); //use migrations for changing db:
        //to migrate database:
        // -> Open NuGet Manager Console
        // -> Run: "Enable-Migrations"
        // -> Run: "Add-Migration InitialCreate"
        // -> Run: "Update-Database"

        // for next migrations repeat last 2 steps

        //var newDepartment = new Department
        //{
        //    Name = "IT",
        //    Description = "Developers department"
        //};

        //dbContext.Departments.Add(newDepartment);

        //var departments = dbContext.Departments
        //    .Where(d => d.Name == "IT")
        //    .Select(d => d)
        //    .OrderBy(d => d.Name)
        //    .ThenBy(d => d.Description)
        //    .Include(d => d.Employee)  // Joins Employees table
        //    .ToList();

        //Console.WriteLine(departments.Count);

        //var departmentsQuery = from department in dbContext.Departments
        //                       where department.Name == "IT"
        //                       orderby department.Description
        //                       select department;

        //var departmentsList = departmentsQuery.ToList();

        //dbContext.SaveChanges();

        /******************************************************************************/
        /** LINQ operations **/

        var dbContext = new CompanyDbContext();

        var employeesTransactions = dbContext.Employees
            .Include(e => e.Transactions)
            .Select(e => new
            {
                Employee = e.FirstName,
                TransactionAmount = e.Transactions
            })
            .ToList();

        var employeesQuery = (from employee in dbContext.Employees
                              join transaction in dbContext.Transactions on employee.Id equals transaction.EmployeeId
                              select new
                              {
                                  Employee = employee.FirstName + " " + employee.LastName,
                                  TransactionAmount = new
                                  {
                                      Date = transaction.TransactionDate,
                                      Amount = transaction.Amount
                                  }
                              }).ToList();

        foreach (var transaction in employeesQuery)
        {
            Console.WriteLine(transaction.ToString());
        }

        foreach (var transaction in employeesTransactions)
        {
            Console.WriteLine(transaction.ToString());
        }

        var employeesWithDepartments = 
            dbContext.Employees.Join(
            dbContext.Departments,
            (e => e.DepartmentId),
            (d => d.Id),
            (e, d) => new
            {
                Employee = e.FirstName + " " + e.LastName,
                e.Position,
                Department = d.Name
            }
            ).ToList();


    }
}
