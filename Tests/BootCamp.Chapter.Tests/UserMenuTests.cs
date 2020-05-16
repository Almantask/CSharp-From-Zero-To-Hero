using System;
using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class UserMenuTests: ConsoleTests
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
    }
}
