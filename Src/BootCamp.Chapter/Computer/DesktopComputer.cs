namespace BootCamp.Chapter.Computer
{
    public abstract class DesktopComputer
    {
        protected DesktopComputer()
        {
            AssemblePC();
        }

        /// <summary>
        /// Must Set the following items:Body, Cpu, Gpu, HardDisk, Motherboard, Ram.
        /// </summary>
        public abstract void AssemblePC();

        public Body Body { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
        public HardDisk HardDisk { get; set; }
        public Motherboard Motherboard { get; set; }
        public Ram Ram { get; set; }
    }
}
