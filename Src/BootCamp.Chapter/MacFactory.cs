using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Mac;
namespace BootCamp.Chapter
{
    public class MacFactory : ComputersFactory
    {

        public override Body InstallBody()
        {
            MacBody body = new MacBody();
            return body;
        }
        public override Cpu InstallCpu()
        {
            MacCpu cpu = new MacCpu();
            return cpu;
        }

        public override Ram InstallRam()
        {
            MacRam ram = new MacRam();
            return ram;
        }

        public override Gpu InstallGpu()
        {
            MacGpu gpu = new MacGpu();
            return gpu;
        }

        public override HardDisk InstallHardDisk()
        {
            MacHardDisk hardDisk = new MacHardDisk();
            return hardDisk;
        }

        public override Motherboard InstallMotherboard()
        {
            MacMotherboard motherboard = new MacMotherboard();
            return motherboard;
        }

    }
}
