using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        public override string Brand()
        {
            return "Mac";
        }

        public override Body InstallBody(string brand)
        {
            PrintAddMsg("Body", brand);
            return new Body(brand + "Body");
        }
        public override Cpu InstallCpu(string brand)
        {
            PrintAddMsg("Cpu", brand);
            return new Cpu(brand + "Cpu");
        }
        public override Gpu InstallGpu(string brand)
        {
            PrintAddMsg("Gpu", brand);
            return new Gpu(brand + "Gpu");
        }
        public override HardDisk InstallHardDisk(string brand)
        {
            PrintAddMsg("HardDisk", brand);
            return new HardDisk(brand + "HardDisk");
        }
        public override Motherboard InstallMotherboard(string brand)
        {
            PrintAddMsg("Motherboard", brand);
            return new Motherboard(brand + "Motherboard");
        }
        public override Ram InstallRam(string brand)
        {
            PrintAddMsg("Ram", brand);
            return new Ram(brand + "Ram");
        }
        public override void PrintAddMsg(string component, string brand)
        {
            Console.WriteLine($"Adding {component} to {brand}PC.");
        }
    }
}
