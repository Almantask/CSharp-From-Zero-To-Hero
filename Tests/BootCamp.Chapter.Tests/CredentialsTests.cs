using BootCamp.Chapter.Tests.Input.ClassData;
using FluentAssertions;
using System;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class CredentialsTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("", null)]
        [InlineData(null, null)]
        public void New_Credentials_Given_Username_NullOrEmpty_Throws_ArgumentException(string username, string password)
        {
            Action action = () => new Credentials(username, password);

            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Equals_On_Different_Type_Returns_False()
        {
            int objectOfDifferentType = default;
            var credentials = new Credentials("Tom", "123455");

            var areEqual = credentials.Equals(objectOfDifferentType);

            areEqual.Should().BeFalse("Credentials must be compared to credentials, otherwise it's not equal.");
        }

        [Fact]
        public void Equals_On_Credentials_With_Matching_Fields_Returns_True()
        {
            var credentials1 = new Credentials("Tom", "Tom123");
            var credentials2 = new Credentials("Tom", "Tom123");

            var areEqual = credentials1.Equals(credentials2);

            areEqual.Should().BeTrue();
        }

        [Theory]
        [ClassData(typeof(UnequalCredentialPairs))]
        public void Equals_On_Credentials_With_Different_Fields_Returns_False(Credentials credentials1, Credentials credentials2)
        {
            var areEqual = credentials1.Equals(credentials2);

            areEqual.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData("sdajlkj")]
        [InlineData("sdaj lkj")]
        public void TryParse_Given_Invalid_Credentials_String_Returns_False(string credentialsString)
        {
            var isCredentials = Credentials.TryParse(credentialsString, out var credentials);

            isCredentials.Should().BeFalse();
        }

        [Fact]
        public void TryParse_Given_2_Command_Separated_Words_Returns_True()
        {
            const string credentialsString = "Hello,World";

            var isCredentials = Credentials.TryParse(credentialsString, out var credentials);

            isCredentials.Should().BeTrue();
        }
    }
}