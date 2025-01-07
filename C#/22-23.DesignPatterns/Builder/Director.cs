namespace Builder
{
    public class Director
    {
        private IComputerBuilder _builder;

        public Director(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildGamingComputer()
        {
            _builder.AddCPU("Intel Core i9");
            _builder.AddGPU("Nvidia RTX 3090");
            _builder.AddRAM("32GB");
            _builder.AddStorage("1TB SSD");
            _builder.AddPowerSupply("1000W");
            _builder.AddMotherboard("ASUS ROG Strix Z490-E");
        }

        public void BuildOfficeComputer()
        {
            _builder.AddCPU("Intel Core i5");
            _builder.AddGPU("Integrated Graphics");
            _builder.AddRAM("16GB");
            _builder.AddStorage("512GB SSD");
            _builder.AddPowerSupply("500W");
            _builder.AddMotherboard("ASUS Prime H410M-E");
        }
    }
}
