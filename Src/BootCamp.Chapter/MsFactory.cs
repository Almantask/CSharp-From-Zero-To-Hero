using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        public override string Brand()
        {
            return "Ms";
        }
        public override Body InstallBody()
        {
            PrintAddMsg("Body");
            return new Body(Brand() + "Body");
        }
        public override Cpu InstallCpu()
        {
            PrintAddMsg("Cpu");
            return new Cpu(Brand() + "Cpu");
        }
        public override Gpu InstallGpu()
        {
            PrintAddMsg("Gpu");
            return new Gpu(Brand() + "Gpu");
        }
        public override HardDisk InstallHardDisk()
        {
            PrintAddMsg("HardDisk");
            return new HardDisk(Brand() + "HardDisk");
        }
        public override Motherboard InstallMotherboard()
        {
            PrintAddMsg("Motherboard");
            return new Motherboard(Brand() + "Motherboard");
        }
        public override Ram InstallRam()
        {
            PrintAddMsg("Ram");
            return new Ram(Brand() + "Ram");
        }
        public override void PrintAddMsg(string component)
        {
            Console.WriteLine($"Installing {component} to {Brand()}PC.");
        }
    }
}
