using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Ms;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputersFactory
    {

        public override Body InstallBody()
        {
            MsBody body = new MsBody();
            return body;
        }
        public override Cpu InstallCpu()
        {
            MsCpu cpu = new MsCpu();
            return cpu;
        }

        public override Ram InstallRam()
        {
            MsRam ram = new MsRam();
            return ram;
        }

        public override Gpu InstallGpu()
        {
            MsGpu gpu = new MsGpu();
            return gpu;
        }

        public override HardDisk InstallHardDisk()
        {
            MsHardDisk hardDisk = new MsHardDisk();
            return hardDisk;
        }

        public override Motherboard InstallMotherboard()
        {
            MsMotherboard motherboard = new MsMotherboard();
            return motherboard;
        }

    }
}

