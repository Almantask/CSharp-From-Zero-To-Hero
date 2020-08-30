using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {

        public DesktopComputer Assemble()
        {
            DesktopComputer desktopComputer = new DesktopComputer(new Body(), new Ram(), new Cpu(), new Gpu(), new HardDisk(), new Motherboard());

            Body(desktopComputer);
            Cpu(desktopComputer);
            Gpu(desktopComputer);
            HardDisk(desktopComputer);
            Motherboard(desktopComputer);
            Ram(desktopComputer);

            return desktopComputer;
        }
        public override void Body(DesktopComputer desktop)
        {
            desktop.GetBody();
        }
        public override void Cpu(DesktopComputer desktop)
        {
            desktop.GetCpu();
        }
        public override void Gpu(DesktopComputer desktop)
        {
            desktop.GetGpu();
        }
        public override void HardDisk(DesktopComputer desktop)
        {
            desktop.GetHard();
        }
        public override void Motherboard(DesktopComputer desktop)
        {
            desktop.GetMotherboard();
        }
        public override void Ram(DesktopComputer desktop)
        {
            desktop.GetRam();
        }




    }
}
