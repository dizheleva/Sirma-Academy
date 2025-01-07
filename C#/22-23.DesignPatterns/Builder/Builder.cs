namespace Builder
{
    public class Builder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer GetComputer() => _computer;

        public void AddCPU(string cpu) => _computer.CPU = cpu;
        public void AddGPU(string gpu) => _computer.GPU = gpu;
        public void AddMotherboard(string motherboard) => _computer.Motherboard = motherboard;
        public void AddPowerSupply(string powerSupply) => _computer.PowerSupply = powerSupply;
        public void AddRAM(string ram) => _computer.RAM = ram;
        public void AddStorage(string storage) => _computer.Storage = storage;
    }
}
