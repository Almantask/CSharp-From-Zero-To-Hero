using BootCamp.Chapter.Computer;
using System;


namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        public virtual DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();
            TakeBody(computer);
            PlaceMotherBoard(computer);
            PlaceCpu(computer);
            PlaceGpu(computer);
            PlaceRam(computer);
            Console.WriteLine("the ms computer is ready to be shipped");
            return computer;

        }

        public virtual void PlaceRam(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard ram");
            var ram = new Ram("a  standard cpu");
            computer.SetRam(ram);
        }

        public virtual void PlaceGpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard gpu");
            var gpu = new Gpu("a  standard cpu");
            computer.SetGpu(gpu);
        }

        public virtual void PlaceCpu(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard cpu");
            var cpu = new Cpu("a  standard cpu");
            computer.SetCpu(cpu);
        }

        public virtual void TakeBody(DesktopComputer computer)
        {
            Console.WriteLine("Im going to take a standard Body");
            var body = new Body("a  standard body");
            computer.SetBody(body);
        }

        public virtual void PlaceMotherBoard(DesktopComputer computer)
        {
            Console.WriteLine("Im going to place a standard motherboard");
            var motherboard = new Motherboard("a  standard motherboard");
            computer.SetMotherboad(motherboard); 
        }
    }
}
