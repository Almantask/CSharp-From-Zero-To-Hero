using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        private const string manufacturer = "Microsoft Corporation";

        public MsFactory() { }

        protected override void PrepareBody(DesktopComputer computer)
        {
            Body body = new Body("CA-H710B-B1", "NZXT", "H710 Matte Black", CaseDesign.ATX);
            Console.WriteLine($"Preparing body with ID: {body.GetID()}, and ModelName: {body.GetModelName()} for assembly.");
            computer.SetBody(body);
        }

        protected override void InstallMotherboard(DesktopComputer computer)
        {
            Motherboard motherboard = new Motherboard("ARC-7-CR-HERO", "Asus", "ASUS ROG Crosshair VIII Hero (Wi-Fi)", "X570", "AMD", SocketType.AM4);
            Console.WriteLine($"Installing {motherboard.GetModelName()} onto body.");
            computer.SetMotherboard(motherboard);
        }

        protected override void InstallCpu(DesktopComputer computer)
        {
            Cpu cpu = new Cpu("AMD-RZ-3950X", "AMD", "AMD Ryzen™ 9 3950X", SocketType.AM4, 16, 32, 3500);
            Console.WriteLine($"Installing {cpu.GetModelName()} onto motherboard.");
            computer.SetCpu(cpu);
        }

        protected override void InstallGpu(DesktopComputer computer)
        {
            Gpu gpu = new Gpu("ROG-STRIX-RTX2080TI-A11G-GAMING", "Asus", "Asus RoG Strix - RTX 2080TI Advanced", "NVIDIA", GPUMemoryType.GDDR6, 11, 14000, 1350);
            Console.WriteLine($"Installing {gpu.GetModelName()} onto motherboard.");
            computer.SetGpu(gpu);
        }

        protected override void InstallRam(DesktopComputer computer)
        {
            Ram ram = new Ram("F4-3600C16Q-64GTZNC", "G.Skill", "G.SKILL 64GB Trident Z Neo", RamType.DDR4, 3600, "CL16");
            Console.WriteLine($"Installing {ram.GetModelName()} onto motherboard.");
            computer.SetRam(ram);
        }

        protected override void InstallHardDisk(DesktopComputer computer)
        {
            HardDisk hardDisk = new HardDisk("MZ-76Q1T0BW", "Samsung", "SAMSUNG 1TB 860 QVO", 550, 1024);
            Console.WriteLine($"Installing {hardDisk.GetModelName()} onto body and connecting it to the motherboard.");
            computer.SetHard(hardDisk);
        }

        protected override void TagManufacturer(DesktopComputer computer)
        {
            computer.SetManufacturer(manufacturer);
            Console.WriteLine($"Computer assembly has been completed. Assembly done by: {computer.GetManufacturer()}");
        }
    }
}
