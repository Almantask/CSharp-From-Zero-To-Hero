using BootCamp.Chapter.Computer;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class Lesson3Tests
    {
        [Fact]
        public void MacFactory_Assemble_Returns_Computer_With_All_Slots_Filled()
        {
            var factory = new MacFactory();

            var computer = factory.Assemble();

            AssertAllPropertiesFilled(computer);
        }

        [Fact]
        public void MsFactory_Assemble_Returns_Computer_With_All_Slots_Filled()
        {
            var factory = new MsFactory();

            var computer = factory.Assemble();

            AssertAllPropertiesFilled(computer);
        }

        private void AssertAllPropertiesFilled(DesktopComputer computer)
        {
            computer.Should().NotBeNull();
            using (new AssertionScope())
            {
                computer.GetCpu().Should().NotBeNull();
                computer.GetMotherboard().Should().NotBeNull();
                computer.GetGpu().Should().NotBeNull();
                computer.GetHard().Should().NotBeNull();
                computer.GetRam().Should().NotBeNull();
            }
        }
    }
}
