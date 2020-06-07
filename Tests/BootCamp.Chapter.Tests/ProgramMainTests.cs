using BootCamp.Chapter.Examples;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class ProgramMainTests
    {
        [Fact]
        public void ProgramMain_Calls_DummyServiceFoo()
        {
            var dummyService = new Mock<IDummyService>();
            Program.Service = dummyService.Object;

            Program.Main(null);

            dummyService.Verify(s => s.Foo(), Times.Once);
        }
    }
}
