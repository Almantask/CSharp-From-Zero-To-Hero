using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        public List<Component> components = new List<Component>();
        public Body Body { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
        public HardDisk HardDisk { get; set; }
        public Motherboard Motherboard { get; set; }
        public Ram Ram { get; set; }

        public void PrintAssembledPc()
        {
            foreach (Component component in components)
            {
                Console.WriteLine($"This PC has a {component.Name}.");
            }
        }
    }
    

}
