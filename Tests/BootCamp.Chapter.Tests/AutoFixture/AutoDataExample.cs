using System;
using AutoFixture.Xunit2;
using BootCamp.Chapter.Dummies;
using Xunit;

namespace BootCamp.Chapter.Tests.AutoFixture
{
    public class AutoDataExample
    {
        [Theory]
        [InlineAutoData("")]
        [InlineAutoData("Tom", null)]
        public void New_Person_When_InvalidArgs_Throws_ArgumentException(string name, DateTime birthday)
        {
            void Create() => new Person(name, birthday);

            Assert.Throws<ArgumentException>(Create);
        }

        [Theory, AutoData]
        public void New_Person_When_ValidArgs_DoesNotThrow(string name, DateTime birthday)
        {
            void Create() => new Person(name, birthday);

            Create();
        }
    }
}
