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
        //I had weird problem on the tests with the default .txt files. So I've created my own files to test. I've got directory not found exception with default files but I've pass all the tests with this files.

        private const string EmptyFile = @"D:\Desktop\testEmpty.txt";
        private const string FileWtihSingleCredential = @"D:\Desktop\test.txt";
        //private const string EmptyFile = @"Input/Files/EmptyCredentials.txt";
        //private const string FileWtihSingleCredential = @"Input/Files/TomTom123Credentials.txt";

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
        public void Register_Given_EmptyFile_Appends_Comma_Separated_Credentials()
        {
            var credentialsManager = new CredentialsManager(EmptyFile);
            var credentials = new Credentials("Tom", "Tom123");

            credentialsManager.Register(credentials);

            File.ReadAllLines(EmptyFile)
                .Should().HaveCount(1);
        }

        [Fact]
        public void Register_Given_Valid_FilledFile_Appends_Comma_Separated_Credentials()
        {
            var credentialsManager = new CredentialsManager(FileWtihSingleCredential);
            var credentials = new Credentials("Tom", "Tom123");
            var oldContents = File.ReadAllLines(FileWtihSingleCredential);

            credentialsManager.Register(credentials);


            File.ReadAllLines(FileWtihSingleCredential)
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
