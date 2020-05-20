using System;
using System.Collections.Generic;
using BootCamp.Chapter.Examples.AppointmentService;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class AppointmentsServiceTests
    {
        private readonly Mock<IAppointmentsRepository> _repositoryMock;

        public AppointmentsServiceTests()
        {
            _repositoryMock = new Mock<IAppointmentsRepository>();
        }

        [Fact]
        public void New_When_NullArg_Throws_ArgumentNullException()
        {
            IAppointmentsRepository repo = null;

            void Create() => new AppointmentsService(repo);

            Assert.Throws<ArgumentNullException>(Create);
        }
        
        [Fact] 
        public void Create_When_NoAppointmentsAtTime_Creates_Appointment()
        {
            var appointmentCandidate = CreateAppointment();
            SetupRepositoryStub(new Appointment[0]);
            var service = new AppointmentsService(_repositoryMock.Object);

            service.Create(appointmentCandidate);

            _repositoryMock.Verify(r => r.Create(appointmentCandidate), Times.Once);
        }

        [Fact]
        public void Create_When_AppointmentsExistAtTime_Throws_AppointmentUnavailableException()
        {
            var appointmentCandidate = CreateAppointment();
            SetupRepositoryStub(new[] { It.IsAny<Appointment>() });
            var service = new AppointmentsService(_repositoryMock.Object);

            void Create() => service.Create(appointmentCandidate);

            Assert.Throws<AppointmentUnavailableException>(Create);
        }

        [Fact]
        public void Create_When_AppointmentNull_Throws_ArgumentNullException()
        {
            Appointment appointmentCandidate = null;
            var service = new AppointmentsService(_repositoryMock.Object);

            void Create() => service.Create(appointmentCandidate);

            Assert.Throws<ArgumentNullException>(Create);
        }

        private void SetupRepositoryStub(IEnumerable<Appointment> appointments)
        {
            _repositoryMock.Setup(r => 
                    r.Get(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .Returns(appointments);
        }

        private static Appointment CreateAppointment()
        {
            return new Appointment(It.IsAny<long>(), It.IsAny<DateTime>(), It.IsAny<DateTime>());
        }
    }
}
