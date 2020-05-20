using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BootCamp.Chapter.Exceptions;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class CredentialsManagerTests
    {
        private const string EmptyFile = @"Input/Files/EmptyCredentials.txt";
        private const string FileWithSingleCredentials = @"Input/Files/TomTom123Credentials.txt";

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
            var credentialsManager = new CredentialsManager(FileWithSingleCredentials);
            var credentials = new Credentials("Tom", "Tom123");

            var isLoggedIn = credentialsManager.Login(credentials);

            isLoggedIn.Should().BeTrue();
        }

        [Fact]
        public void Register_When_Credentials_File_Empty_Appends_Comma_Separated_Credentials()
        {
            var credentialsManager = new CredentialsManager(EmptyFile);
            var credentials = new Credentials("Hello", "Kai");
            var encodedCredentials = new Credentials(credentials.Username, Encoder.Encode(credentials.Password));
 
            credentialsManager.Register(credentials);

            GetCredentials(EmptyFile)
                .Should().Contain(encodedCredentials)
                .And.HaveCount(1);
        }

        [Fact]
        public void Register_Appends_Comma_Separated_Credentials()
        {
            var credentialsManager = new CredentialsManager(FileWithSingleCredentials);
            var credentials = new Credentials("Hello", "Kai");
            var encodedCredentials = new Credentials(credentials.Username, Encoder.Encode(credentials.Password));
            var oldContents = GetCredentials(FileWithSingleCredentials);

            credentialsManager.Register(credentials);

            GetCredentials(FileWithSingleCredentials)
                .Should().Contain(encodedCredentials)
                .And.HaveCount(oldContents.Count + 1);
        }

        private List<Credentials> GetCredentials(string credentialsFile)
        {
            var credentialsList = new List<Credentials>();

            using (StreamReader streamReader = new StreamReader(credentialsFile))
            {
                string currentLine;
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (Credentials.TryParse(currentLine, out Credentials credentials))
                        credentialsList.Add(credentials);
                }
            }

            return credentialsList;
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
