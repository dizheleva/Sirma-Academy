internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, List<string>> companyEmployees = [];

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] splitedInput = input.Split(" -> ");

            string companyName = splitedInput[0];
            string employeeId = splitedInput[1];

            if (!companyEmployees.ContainsKey(companyName))
            {
                companyEmployees[companyName] = [];
            }

            if (!companyEmployees[companyName].Contains(employeeId))
            {
                companyEmployees[companyName].Add(employeeId);
            }
        }

        foreach (var company in companyEmployees)
        {
            Console.WriteLine(company.Key);
            foreach (var id in company.Value)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}