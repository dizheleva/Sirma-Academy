namespace Builder
{
    public interface IComputerBuilder
    {
        void AddCPU(string cpu);
        void AddGPU(string gpu);
        void AddRAM(string ram);
        void AddStorage(string storage);
        void AddPowerSupply(string powerSupply);
        void AddMotherboard(string motherboard);
        Computer GetComputer();
    }
}
