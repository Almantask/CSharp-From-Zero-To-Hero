using FluentAssertions;
using System;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class TextBoxPrinterTests
    {
        [Fact]
        public void Print_Object_Without_Attributes_Returns_ToString()
        {
            var item = new Item("Test");

            var text = TextBoxPrinter.Print(item);

            text.Should().Be("Test");
        }

        [Fact]
        public void Print_Object_With_Default_TextBox_Attribute_ToString_Formatted_Using_Attribute()
        {
            var item = new Car("BMW", "X6");

            var text = TextBoxPrinter.Print(item);

            text.Should().Be("+------+" + Environment.NewLine +
                                    "|BMW X6|" + Environment.NewLine +
                                    "+------+");
        }

        [Fact]
        public void Print_Object_With_Custom_TextBox_Attribute_ToString_Formatted_Using_Attribute()
        {
            var item = new Person("Bill", 12);

            var text = TextBoxPrinter.Print(item);

            text.Should().Be("*===========*" + Environment.NewLine +
                                    "x           x" + Environment.NewLine +
                                    "x Bill - 12 x" + Environment.NewLine +
                                    "x           x" + Environment.NewLine +
                                    "*===========*");
        }
    }
}