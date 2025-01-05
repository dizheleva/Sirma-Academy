namespace _03.LiskovSubstitutionPrinciple.Engine
{
    public class ElectricEngine : Engine
    {
        public override void Start()
        {
            throw new InvalidOperationException("Electric engines don't start traditionally.");
        }
    }
}
