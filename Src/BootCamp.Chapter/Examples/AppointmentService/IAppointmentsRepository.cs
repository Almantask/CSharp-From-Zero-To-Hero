using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Examples.AppointmentService
{
    public interface IAppointmentsRepository
    {
        void Create(Appointment appointment);
        IEnumerable<Appointment> Get(DateTime from, DateTime to);
    }
}