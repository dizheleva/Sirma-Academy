using _03.BankAccount;

internal class Program
{
    private static void Main(string[] args)
    {
        List<BankAccount> accounts = [];

        string commandLine;
        while ((commandLine = Console.ReadLine()) != "End")
        {
            string[] commandArgs = commandLine.Split(" ");
            string output = "";
            BankAccount account = null;
            switch (commandArgs[0])
            {
                case "Create":
                    account = new BankAccount();
                    accounts.Add(account);
                    Console.WriteLine($"Account ID{account.Id} created");
                    break;
                case "Deposit":
                    int depositId = int.Parse(commandArgs[1]);
                    account = accounts.FirstOrDefault(account => account.Id == depositId);
                    if (account != null)
                    {
                        double amount = double.Parse(commandArgs[2]);
                        account.Deposit(amount);
                        Console.WriteLine($"Deposited {amount} to ID{account.Id}");
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
                case "SetInterest":
                    double newInterest = double.Parse(commandArgs[1]);
                    BankAccount.SetInterestRate(newInterest);
                    break;
                case "GetInterest":
                    int interestId = int.Parse(commandArgs[1]);
                    account = accounts.FirstOrDefault(account => account.Id == interestId);
                    if (account != null)
                    {
                        int years = int.Parse(commandArgs[2]);
                        double interest = account.GetInterest(years);
                        Console.WriteLine($"{interest:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
            }            
        }
    }
}