namespace _03.LiskovSubstitutionPrinciple.Bird
{
    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin moves by swimming");
        }
    }
}
