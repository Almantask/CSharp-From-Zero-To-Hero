using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class HowToEscapeRandom
    {
        [Fact]
        public void AdaptRandom()
        {
            var adapterRandom = new AdaptedRandom();

            var number = adapterRandom.Next(10000);

            Assert.Equal(1, number);
        }

        [Fact]
        public void MockRandom()
        {
            var randomMock = new Mock<Random>();
            randomMock.Setup(r => r.Next(It.IsAny<int>()))
                .Returns(1);

            var number = randomMock.Object.Next(10000);

            Assert.Equal(1, number);
        }

        [Fact]
        public void OverrideRandom()
        {
            var randomStub = new MyRandom();

            var number = randomStub.Next(10000);

            Assert.Equal(1, number);
        }

        // Override in custom class
        public class MyRandom : Random
        {
            public override int Next(int max) => 1;
        }

        public class AdaptedRandom : IRandomiser
        {
            private readonly Random _random;

            public AdaptedRandom()
            {
                _random = new Random();
            }

            public int Next(int maxValue) => 1;
        }
    }
}
