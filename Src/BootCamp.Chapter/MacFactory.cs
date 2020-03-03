using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : ComputerFactory
    {
        public override DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();
            TakeBody(computer);
            PlaceMotherBoard(computer);
            PlaceHarddisk(computer);
            PlaceCpu(computer);
            PlaceGpu(computer);
            PlaceRam(computer);
            Console.WriteLine("the mac computer is ready to be shipped");
            return computer;
        }

        public override void PlaceRam(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a mac ram");
            var ram = new Ram("a  mac cpu");
            computer.SetRam(ram);
        }

        public override void PlaceGpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a mac gpu");
            var gpu = new Gpu("a  mac cpu");
            computer.SetGpu(gpu);
        }

        public override void PlaceCpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a mac cpu");
            var cpu = new Cpu("a  mac cpu");
            computer.SetCpu(cpu);
        }

        private void PlaceHarddisk(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a mac HardDisk");
            var hardDisk = new HardDisk("a mac harddisk");
            computer.SetHardDisk(hardDisk);
        }

        public override void TakeBody(DesktopComputer computer)
        {
            Console.WriteLine("Im going to take a mac Body");
            var body = new Body("a mac body");
            computer.SetBody(body);
        }

        public override void PlaceMotherBoard(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a mac motherboard");
            var motherboard = new Motherboard("a  mac motherboard");
            computer.SetMotherboad(motherboard);
        }
    }


}

