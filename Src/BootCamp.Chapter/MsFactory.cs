using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
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
            Console.WriteLine("the ms computer is ready to be shipped");
            return computer;
        }

        public static void PlaceRam(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard ram");
            var ram = new Ram("a  standard cpu");
            computer.SetRam(ram);
        }

        public static void PlaceGpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard gpu");
            var gpu = new Gpu("a  standard cpu");
            computer.SetGpu(gpu);
        }

        public static void PlaceCpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a MS cpu");
            var cpu = new Cpu("a  MS cpu");
            computer.SetCpu(cpu);
        }

        private static void PlaceHarddisk(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a MS HardDisk");
            var hardDisk = new HardDisk("a MS harddisk");
            computer.SetHardDisk(hardDisk);
        }

        public static void TakeBody(DesktopComputer computer)
        {
            Console.WriteLine("Im going to take a MS Body");
            var body = new Body("a ms body");
            computer.SetBody(body);
        }

        public static void PlaceMotherBoard(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a MS motherboard");
            var motherboard = new Motherboard("a  MS motherboard");
            computer.SetMotherboad(motherboard);
        }
    }
}
