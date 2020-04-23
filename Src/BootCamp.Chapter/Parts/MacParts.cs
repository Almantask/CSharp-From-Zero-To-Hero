using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter.Parts
{
    public static class MacParts
    {
        public static Body MacBody = new Body(147, "Mac Body Pro™");
        public static Ram MacRam = new Ram(23, "Iram Pro");
        public static Cpu MacCpu = new Cpu(2, "Intel Core i7 8th Gen");
        public static Gpu MacGpu = new Gpu(65, "Nvidia RTX 2070");
        public static HardDisk MacHardDisk = new HardDisk(25, "Apple SSD Pro™");
        public static Motherboard MacMotherboard = new Motherboard(85, "Apple Motherboard v98");
    }
}