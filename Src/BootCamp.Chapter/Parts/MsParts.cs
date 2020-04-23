using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter.Parts
{
    public static class MsParts
    {
        public static Body MsBody = new Body(87, "Generic Case");
        public static Ram MsRam = new Ram(20, "HyperX Fury DDR4 2666mhz");
        public static Cpu MsCpu = new Cpu(1, "AMD Ryzen 5 2600");
        public static Gpu MsGpu = new Gpu(32, "Nvidia GTX 1080");
        public static HardDisk MsHardDisk = new HardDisk(6, "SSD Kingston A400 240GB");
        public static Motherboard MsMotherboard = new Motherboard(54, "Gigabyte B450M DS3H");
    }
}