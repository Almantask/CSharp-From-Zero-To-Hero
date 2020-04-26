using System;
using System.Threading;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        private readonly DesktopComputer _computer = new DesktopComputer();
        protected DesktopComputer GetComputer()
        {
            return _computer;
        }

        public abstract DesktopComputer Assemble();

        protected virtual void InstallBody(Body body)
        {
            PrintAssemblingStatus(body);
            _computer.SetBody(body);
        }

        protected virtual void InstallRam(Ram ram)
        {
            PrintAssemblingStatus(ram);
            _computer.SetRam(ram);
        }

        protected virtual void InstallCpu(Cpu cpu)
        {
            PrintAssemblingStatus(cpu);
            _computer.SetCpu(cpu);
        }

        protected virtual void InstallGpu(Gpu gpu)
        {
            PrintAssemblingStatus(gpu);
            _computer.SetGpu(gpu);
        }

        protected virtual void InstallHard(HardDisk hard)
        {
            PrintAssemblingStatus(hard);
            _computer.SetHard(hard);
        }

        protected virtual void InstallMotherboard(Motherboard motherboard)
        {
            PrintAssemblingStatus(motherboard);
            _computer.SetMotherboard(motherboard);
        }
        
        
        private static void PrintAssemblingStatus(Component component)
        {
            Console.WriteLine($"Assembling: [ID = {component.GetId()}] [NAME = {component.GetName()}]");
            Thread.Sleep(200);
        }
    }
}