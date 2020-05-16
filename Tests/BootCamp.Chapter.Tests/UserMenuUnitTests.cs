using BootCamp.Chapter.Examples.UserMenu.v1;
using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class UserMenuUnitTests : ConsoleTests
    {
        [Fact]
        public void Display_When_Option1_Prints_Items()
        {
            ConsoleInput = "1";

            UserMenu.Display();

            ConsoleOutput.Should().Be("Items");
        }

        [Fact]
        public void Display_WhenOption2_Prints_Users()
        {
            ConsoleInput = "2";

            UserMenu.Display();

            ConsoleOutput.Should().Be("Users");
        }

        [Fact]
        public void Display_WhenOptionOther_Ignores()
        {
            ConsoleInput = "other";

            UserMenu.Display();

            ConsoleOutput.Should().Be("Users");
        }
    }
}
