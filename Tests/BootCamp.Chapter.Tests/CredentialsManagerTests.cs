using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class CredentialsManagerTests
    {
        private const string EmptyFile = @"Input/Files/EmptyCredentials.txt";
        private const string FileWtihSingleCredential = @"Input/Files/TomTom123Credentials.txt";

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void New_CredentialManager_When_NullOrEmptyString_Throws_ArgumentException(string credentialsFile)
        {
            Action action = () => new CredentialsManager(credentialsFile);

            action.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Login_When_Credentials_File_Empty_Returns_False()
        {
            var credentialsManager = new CredentialsManager(EmptyFile);
            var credentials = new Credentials("Test", "Test");

            var isLoggedIn = credentialsManager.Login(credentials);

            isLoggedIn.Should().BeFalse("No logins exist");
        }

        [Fact]
        public void Login_When_Credentials_File_Contains_The_Credentials_Returns_True()
        {
            var credentialsManager = new CredentialsManager(FileWtihSingleCredential);
            var credentials = new Credentials("Tom", "Tom123");

            var isLoggedIn = credentialsManager.Login(credentials);

            isLoggedIn.Should().BeTrue();
        }

        [Theory]
        [InlineData(EmptyFile)]
        [InlineData(FileWtihSingleCredential)]
        public void Register_Appends_Comma_Separated_Credentials(string credentialsFile)
        {
            var credentialsManager = new CredentialsManager(credentialsFile);
            var credentials = new Credentials("Tom", "Tom123");
            var oldContents = File.ReadAllLines(credentialsFile);

            credentialsManager.Register(credentials);


            File.ReadAllLines(credentialsFile)
                .Should().Contain(oldContents)
                .And.HaveCount(oldContents.Length + 1);
        }
        
        private static string ToHexedString(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append($"{b:X} ");
            }

            return sb.ToString();
        }
    }
}
