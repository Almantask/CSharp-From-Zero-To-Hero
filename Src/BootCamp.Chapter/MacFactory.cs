using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        private const string manufacturer = "Apple Inc.";

        public MacFactory() { }

        protected override void PrepareBody(DesktopComputer computer)
        {
            Body body = new Body("MC-PrC-500", "Apple", "Mac Pro Case 500", CaseDesign.ATX);
            Console.WriteLine($"Preparing body with ID: {body.GetID()}, and ModelName: {body.GetModelName()} for assembly.");
            computer.SetBody(body);
        }

        protected override void InstallMotherboard(DesktopComputer computer)
        {
            Motherboard motherboard = new Motherboard("ARS-Z390-E-G", "Asus", "ASUS ROG STRIX Z390-E GAMING", "Z390-E", "Intel", SocketType.LGA1151_300);
            Console.WriteLine($"Installing motherboard {motherboard.GetModelName()} onto motherboard.");
            computer.SetMotherboard(motherboard);
        }

        protected override void InstallCpu(DesktopComputer computer)
        {
            Cpu cpu = new Cpu("INTEL-I5-9600K", "Intel", "INTEL Core i5-9600K", SocketType.LGA1151_300, 6, 6, 3700);
            Console.WriteLine($"Applying thermal paste to cpu socket... and installing {cpu.GetModelName()} onto motherboard.");
            computer.SetCpu(cpu);
        }

        protected override void InstallGpu(DesktopComputer computer)
        {
            Gpu gpu = new Gpu("ROG-STRIX-RTX2080TI-A11G-GAMING", "Asus", "Asus RoG Strix - RTX 2080TI Advanced", "NVIDIA", GPUMemoryType.GDDR6, 11, 14000, 1350);
            Console.WriteLine($"Installing GPU {gpu.GetModelName()} onto motherboard.");
            computer.SetGpu(gpu);
        }

        protected override void InstallRam(DesktopComputer computer)
        {
            Ram ram = new Ram("F4-3600C16Q-64GTZNC", "G.Skill", "G.SKILL 64GB Trident Z Neo", RamType.DDR4, 3600, "CL16");
            Console.WriteLine($"Installing RAM {ram.GetModelName()} onto motherboard.");
            computer.SetRam(ram);
        }

        protected override void InstallHardDisk(DesktopComputer computer)
        {
            HardDisk hardDisk = new HardDisk("MZ-76Q1T0BW", "Samsung", "SAMSUNG 1TB 860 QVO", 550, 1024);
            Console.WriteLine($"Adding Hard Disk to the case but not connecting it to the motherboard.");
            computer.SetHard(hardDisk);
        }

        protected override void TagManufacturer(DesktopComputer computer)
        {
            computer.SetManufacturer(manufacturer);
            Console.WriteLine($"Computer assembly has been completed. Assembly done by: {computer.GetManufacturer()}");
        }
    }
}
