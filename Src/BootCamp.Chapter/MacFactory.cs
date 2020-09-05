using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Installation
    {

        public override Body InstallBody()
        {
            Body body = new Body();
            return body;
        }
        public override Cpu InstallCpu()
        {
            Cpu cpu = new Cpu();
            return cpu;
        }

        public override Ram InstallRam()
        {
            Ram ram = new Ram();
            return ram;
        }

        public override Gpu InstallGpu()
        {
            Gpu gpu = new Gpu();
            return gpu;
        }

        public override HardDisk InstallHardDisk()
        {
            HardDisk hardDisk = new HardDisk();
            return hardDisk;
        }

        public override Motherboard InstallMotherboard()
        {
            Motherboard motherboard = new Motherboard();
            return motherboard;
        }

    }
}
