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

        [Fact]
        public void Register_Appends_Comma_Separated_Credentials_To_Zero_Length_File()
        {
            var credentialsManager = new CredentialsManager(EmptyFile);
            var credentials = new Credentials("Tom", "Tom123");
            var curentCredentials = new Credentials("Tom", StringOps.Encode("Tom123"));

            credentialsManager.Register(credentials);

            GetCredentials(EmptyFile).Should()
                                           .Contain(curentCredentials).And
                                           .HaveCount(1);
        }

        [Fact]
        public void Register_Appends_Comma_Separated_Credentials_To_File_With_Single_Credential()
        {
            var credentialsManager = new CredentialsManager(EmptyFile);
            var credentials = new Credentials("Kai", "Kai123");
            var oldContents = GetCredentials(EmptyFile);

            credentialsManager.Register(credentials);

            GetCredentials(EmptyFile).Should()
                                           .Contain(oldContents).And
                                           .HaveCount(oldContents.Count + 1);
        }

        private List<Credentials> GetCredentials(string credentialsFile)
        {
            var internalCredentialsList = new List<Credentials>();
            var fileContent = File.ReadAllLines(credentialsFile);

            foreach (var line in fileContent)
            {
                if (Credentials.TryParse(line, out Credentials credentials))
                {
                    internalCredentialsList.Add(credentials);
                }
            }
            return internalCredentialsList;
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