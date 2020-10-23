using System;
using System.Collections.Generic;
using System.Linq;
using BootCamp.Chapter.Examples.AppointmentService;
using FluentAssertions;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class AppointmentsServiceTests
    {
        private readonly Mock<IAppointmentsRepository> _repository;
        private readonly AppointmentsService _service;

        public AppointmentsServiceTests()
        {
            _repository = new Mock<IAppointmentsRepository>();
            _service = new AppointmentsService(_repository.Object);
        }
        
        // Main requirements - first.
        [Fact]
        public void Create_When_NoAppointmentsAtTime_Creates_Appointment()
        {
            DateTime start = new DateTime();
            DateTime end = start.AddHours(1);
            long anyId = 1;
            var appointmentCandidate = new Appointment(anyId, start, end);

            _repository
                .Setup(r => r.Get(start, end))
                .Returns(Enumerable.Empty<Appointment>);

            _service.Create(appointmentCandidate);

            _repository.Verify(r => r.Create(appointmentCandidate), Times.Once);
        }

        [Fact]
        public void Create_When_AppointmentsExistAtTime_Throws_AppointmentUnavailableException()
        {
            var appointmentCandidate = new Appointment(
                It.IsAny<long>(),
                It.IsAny<DateTime>(),
                It.IsAny<DateTime>());
            SetupRepositoryStub(new[] { It.IsAny<Appointment>() });

            _repository
                .Setup(r => r.Get(appointmentCandidate.From, appointmentCandidate.To))
                .Returns(new [] {It.IsAny<Appointment>()});

            Action create = () => _service.Create(appointmentCandidate);

            create.Should()
                .ThrowExactly<AppointmentUnavailableException>()
                .Which.Message.Should().Be(
                    $"Person with id {appointmentCandidate.PersonId} cannot book an appointment." +
                    $"Time [{appointmentCandidate.From}-{appointmentCandidate.To}] for appointment is reserved.");
        }

        // Details- after
        [Fact]
        public void New_When_NullArg_Throws_ArgumentNullException()
        {
            IAppointmentsRepository repo = null;

            void Create() => new AppointmentsService(repo);

            Assert.Throws<ArgumentNullException>(Create);
        }

        [Fact]
        public void Create_When_AppointmentNull_Throws_ArgumentNullException()
        {
            Appointment appointmentCandidate = null;

            void Create() => _service.Create(appointmentCandidate);

            Assert.Throws<ArgumentNullException>(Create);
        }

        private void SetupRepositoryStub(IEnumerable<Appointment> appointments)
        {
            _repository.Setup(r => 
                    r.Get(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .Returns(appointments);
        }

        private static Appointment AnyNotNullAppointment()
        {
            return new Appointment(It.IsAny<long>(), It.IsAny<DateTime>(), It.IsAny<DateTime>());
        }
    }
}
