using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class AddressTests
    {
        [Fact]
        public void Address1_EqualityOperator_On_Address2_When_Both_Have_Same_Values_Returns_True()
        {
            var address1 = new Address("asd6", "asd1", "aa2", "aa3", "aa4", "aa5");
            var address2 = new Address("asd6", "asd1", "aa2", "aa3", "aa4", "aa5");

            var areEqual = address2 == address2;

            areEqual.Should().BeTrue();
        }

        [Fact]
        public void Address1_NotEqualityOperator_On_Address2_When_Both_Have_Same_Values_Returns_False()
        {
            var address1 = new Address("asd6", "asd1", "aa2", "aa3", "aa4", "aa5");
            var address2 = new Address("asd6", "asd1", "aa2", "aa3", "aa4", "aa5");

            var areEqual = address1 != address2;

            areEqual.Should().BeFalse();
        }

        [Fact]
        public void Address1_EqualityOperator_On_Address2_When_Both_Have_Different_Values_Returns_False()
        {
            var address1 = new Address("asd6", "asd1", "aa2", "aa3", "aa4", "aa5");
            var address2 = new Address("asd0", "asd1", "aa2", "aa3", "aa4", "aa5");

            var areEqual = address1 == address2;

            areEqual.Should().BeFalse();
        }

        [Fact]
        public void TryParse_When_Valid_AddressString_Returns_True_Out_Address()
        { 
            var addressString = "Nildram Ltd" + Environment.NewLine +
                                "Ardenham Court" + Environment.NewLine +
                                "Oxford Road" + Environment.NewLine +
                                "AYLESBURY" + Environment.NewLine +
                                "BUCKINGHAMSHIRE" + Environment.NewLine +
                                "HP19 3EQ" + Environment.NewLine +
                                "UNITED KINGDOM";

            var isAddress = Address.TryParse(addressString, out var address);

            isAddress.Should().BeTrue();
            using (new AssertionScope())
            {
                address.Recipient.Should().Be("Nildram Ltd");
                address.Street.Should().Be("Ardenham Court");
            }
        }

        [Fact]
        public void TryParse_When_Invalid_AddressString_Returns_False_Out_Default()
        {
            var addressString = "Nildram Ltd" + Environment.NewLine +
                                "Ardenham Court";

            var isAddress = Address.TryParse(addressString, out var address);

            isAddress.Should().BeFalse();
            address.Should().Be(default);
        }
    }
}
