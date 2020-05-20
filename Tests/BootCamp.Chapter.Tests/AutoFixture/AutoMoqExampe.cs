using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using BootCamp.Chapter.Dummies;
using BootCamp.Chapter.Dummies.Orders;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests.AutoFixture
{
    public class AutoMoqExample
    {
        [Theory, AutoData]
        public void DemoAutoMoq_Basic(Order order, string address)
        {
            // AutoMoqCustomization enables resolution of mocked interfaces
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            // Create with all interfaces mocked
            var result = fixture.Create<DeliveryService>();

            result.Deliver(order, address);
        }

        [Theory, AutoData]
        public void DemoAutoMoq_YourMock(Order order, string address)
        {
            // Ready to automock
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            // Inject a specific kind of mock
            var couriersRepositoryMock = fixture.Freeze<Mock<ICouriersRepository>>();
            couriersRepositoryMock.Setup(c =>
                    c.GetAllAvailable(It.IsAny<string>()))
                .Returns(fixture.Create<Courier[]>());

            // Create with injected mock above
            var result = fixture.Create<DeliveryService>();

            result.Deliver(order, address);
        }

        [Theory, AutoData]      
        public void DemoMoq_Frozen([Frozen] Mock<ICouriersRepository> couriersRepo,
            Order order, string address)
        {
            // Enabled injecting mocked interfaces
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            // The same mock that was injected will be used + setup
            couriersRepo.Setup(c =>
                    c.GetAllAvailable(It.IsAny<string>()))
                .Returns(fixture.Create<Courier[]>());

            // Create with injected mock above
            var result = fixture.Create<DeliveryService>();

            result.Deliver(order, address);
        }

        [Theory, AutoMoqData]
        public void DemoMoq_AutomoqAttribute1(
            [Frozen] Mock<ICouriersRepository> couriersRepo,
            Courier[] couriersToBeReturned,
            Order order,
            string address,
            DeliveryService deliveryService)
        {
            // AutoData by default creates all that is passed
            // By inheriting and overriding the default fixture,
            // we specify that it will auto-resolve mocked dependencies

            // The same mock that was injected will be used + setup
            couriersRepo.Setup(c =>
                    c.GetAllAvailable(It.IsAny<string>()))
                .Returns(couriersToBeReturned);

            deliveryService.Deliver(order, address);
        }
            
        [Theory, AutoMoqDeliveryService]
        public void DemoMoq_AutomoqAttribute2(
            Order order,
            string address,
            DeliveryService deliveryService)
        {
            deliveryService.Deliver(order, address);
        }
    }

    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(Setup)
        {
        }

        private static IFixture Setup() => new Fixture()
            .Customize(new AutoMoqCustomization());
    }

    public class AutoMoqDeliveryServiceAttribute : AutoDataAttribute
    {
        public AutoMoqDeliveryServiceAttribute() : base(Setup)
        {       
        }

        // Do all the injections for DeliveryService here
        private static IFixture Setup()
        {
            // Ready to automock
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            // Inject a specific kind of mock
            var couriersRepositoryMock = fixture.Freeze<Mock<ICouriersRepository>>();
            couriersRepositoryMock.Setup(c =>
                    c.GetAllAvailable(It.IsAny<string>()))
                .Returns(fixture.Create<Courier[]>());

            return fixture;
        }
    }
}
