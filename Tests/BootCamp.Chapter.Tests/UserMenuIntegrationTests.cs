using BootCamp.Chapter.Examples.UserMenu.v2;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class UserMenuIntegrationTests
    {
        private readonly Mock<IUserPrompt> _promptMock;
        private readonly UserMenu _menu;

        public UserMenuTestsV2()
        {
            _promptMock = new Mock<IUserPrompt>();
            _menu = new UserMenu(_promptMock.Object);
        }

        [Fact]
        public void Display_When_Option1_Prints_Items()
        {
            StubUserInput("1");

            _menu.Display();

            _promptMock.Verify(p => p.WriteLine("Items"), Times.Once);
        }

        [Fact]
        public void Display_WhenOption2_Prints_Users()
        {
            StubUserInput("2");

            _menu.Display();

            _promptMock.Verify(p => p.WriteLine("Items"), Times.Once);
        }

        [Fact]
        public void Display_WhenOptionOther_Ignores()
        {
            StubUserInput("other");

            _menu.Display();

            _promptMock.Verify(
                p => p.WriteLine(It.IsAny<string>()), 
                Times.Once,
                "only intro message should have been printed");
        }

        private void StubUserInput(string input)
        {
            _promptMock
                .Setup(p => p.ReadLine())
                .Returns(input);
        }
    }
}
