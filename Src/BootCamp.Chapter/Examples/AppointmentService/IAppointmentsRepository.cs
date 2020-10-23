using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Examples.AppointmentService
{
    public interface IAppointmentsRepository
    {
        IEnumerable<Appointment> Get(DateTime start, DateTime end);
        void Create(Appointment appointmentCandidate);
    }
}

