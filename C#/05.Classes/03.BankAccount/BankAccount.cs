namespace _03.BankAccount
{

    public class BankAccount
    {
        private static int id = 1;
        public int Id { get; set; }
        private double Balance { get; set; }
        private static double InterestRate { get; set; } = 0.02;

        public BankAccount()
        {
            this.Id = id++;
            this.Balance = 0.00;
        }

        public static void SetInterestRate(double interest) => InterestRate = interest;

        public double GetInterest(int years) => InterestRate * this.Balance * years;

        public void Deposit(double amount) => this.Balance += amount;
    }
}