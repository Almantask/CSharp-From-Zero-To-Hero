using System;
using System.Linq;

namespace BootCamp.Chapter.Examples.AppointmentService
{
    public class AppointmentsService
    {
        private readonly IAppointmentsRepository _repo;

        public AppointmentsService(IAppointmentsRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(IAppointmentsRepository));
        }

        public void Create(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }

            var appointments = _repo.Get(appointment.From, appointment.To);

            if (appointments.Any())
            {
                throw new AppointmentUnavailableException(appointment);
            }

            _repo.Create(appointment);
        }
    }
}