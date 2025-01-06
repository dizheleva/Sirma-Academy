namespace _06.FindViolations.Task5
{
    public class EmployeeService
    {
        private readonly BonusCalculator _bonusCalculator;
        private readonly PaySlipGenerator _paySlipGenerator;
        private readonly DatabaseController _databaseController;

        public EmployeeService(BonusCalculator bonusCalculator, PaySlipGenerator paySlipGenerator, DatabaseController databaseController)
        {
            _bonusCalculator = bonusCalculator;
            _paySlipGenerator = paySlipGenerator;
            _databaseController = databaseController;
        }

        public void ProcessEmployee(Employee employee)
        {
            _bonusCalculator.CalculateBonus(employee);
            _paySlipGenerator.GeneratePaySlip(employee);
            _databaseController.SaveToDatabase(employee);
        }
    }
}
