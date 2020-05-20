using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using AutoFixture.Xunit2;
using BootCamp.Chapter.Dummies;
using BootCamp.Chapter.Dummies.Orders;
using BootCamp.Chapter.Tests.AutoFixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests.FluentAssertions
{
    public class CheatSheet
    {
        [Theory]
        [InlineData(2, 3, 5)]
        public void Calculator_Sum_Returns_Sum(int a, int b, int expected)
        {
            var actual = Calculator.Sum(a, b);

            Assert.Equal(expected, actual);
            actual.Should().Be(expected);
        }

        [Fact]
        public void ErrorComaprison_Classics1()
        {
            var actual = new[] {1, 2, 3, 4};
            var expected = new[] {1, 2, 5};

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ErrorComaprison_Classics2()
        {
            var actual = "asdjalskdjasdld";
            var expected = "asdjalskejasdld";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ErrorComaprison_Classics3()
        {
            var fixture = new Fixture();
            fixture.Freeze<int>();
            fixture.Freeze<bool>();
            fixture.Freeze<string>();
            fixture.Freeze<DateTime>();

            var actual = fixture.Create<Order>();
            var expected = fixture.Create<Order>();
            expected.Header.Description = "Unexpected";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ErrorComaprison_Classics4()
        {
            var actual = new List<int>();
            var expectedElement = 5;
            var expectedSize = 2;

            Assert.Contains(expectedElement, actual);
            Assert.True(actual.Count == expectedSize);
        }

        [Fact]
        public void ErrorComaprison_Should1()
        {
            var actual = new[] { 1, 2, 3, 4 };
            var expected = new[] { 1, 2, 5 };

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ErrorComaprison_Should2()
        {
            var actual = "asdjalskdjasdld";
            var expected = "asdjalskejasdld";

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ErrorComaprison_Should3()
        {
            var fixture = new Fixture();
            fixture.Freeze<int>();
            fixture.Freeze<bool>();
            fixture.Freeze<string>();
            fixture.Freeze<DateTime>();

            var actual = fixture.Create<Order>();
            var expected = fixture.Create<Order>();
            expected.Header.Description = "Unexpected";

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ErrorComaprison_Should4()
        {
            var actual = new List<int>();
            var expectedElement = 5;
            var expectedSize = 2;

            actual.Should()
                .Contain(expectedElement)
                .And.HaveCount(expectedSize);
        }

        [Fact]
        public void ErrorComaprison_Should5()
        {
            var actual = new List<int>();
            var expectedElement = 5;
            var expectedSize = 2;

            using (new AssertionScope())
            {
                actual.Should().Contain(expectedElement);
                actual.Should().HaveCount(expectedSize);
            }
        }


        [Theory, AutoMoqData]
        public void DeliveryService_Deliver_Given_NoAvailableCouriers_Throws_Exception(
            [Frozen] Mock<ICouriersRepository> couriersRepoMock,
            Order order,
            string address,
            DeliveryService deliveryService)
        {
            couriersRepoMock
                .Setup(cr => cr.GetAllAvailable(address))
                .Returns(new List<Courier>());

            Action action = () => deliveryService.Deliver(order, address);

            action.Should().Throw<Exception>();
        }

        [Theory, AutoMoqData]
        public void DeliveryService_Deliver_Given_AvailableCouriers_DoesNotThrow(
            [Frozen] Mock<ICouriersRepository> couriersRepoMock,
            Courier[] couriers,
            Order order,
            string address,
            DeliveryService deliveryService)
        {
            couriersRepoMock
                .Setup(cr => cr.GetAllAvailable(address))
                .Returns(couriers);

            Action action = () => deliveryService.Deliver(order, address);

            action.Should().NotThrow("because delivery was sent");
        }
    }
}
