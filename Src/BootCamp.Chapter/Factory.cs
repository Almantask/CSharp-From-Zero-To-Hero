using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract DesktopComputer Assemble();
        public Body AddBody(string brand)
        {
            PrintAddMsg("Body", brand);
            return new Body(brand + "Body");
        }
        public Cpu AddCpu(string brand)
        {
            PrintAddMsg("Cpu", brand);
            return new Cpu(brand + "Cpu");
        }
        public Gpu AddGpu(string brand)
        {
            PrintAddMsg("Gpu", brand);
            return new Gpu(brand + "Gpu");
        }
        public HardDisk AddHardDisk(string brand)
        {
            PrintAddMsg("HardDisk", brand);
            return new HardDisk(brand + "HardDisk");
        }
        public Motherboard AddMotherboard(string brand)
        {
            PrintAddMsg("Motherboard", brand);
            return new Motherboard(brand + "Motherboard");
        }
        public Ram AddRam(string brand)
        {
            PrintAddMsg("Ram", brand);
            return new Ram(brand + "Ram");
        }
        private void PrintAddMsg(string component, string brand)
        {
            Console.WriteLine($"Adding {component} to {brand}PC.");
        }
    }
}
