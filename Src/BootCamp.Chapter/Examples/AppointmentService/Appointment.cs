using System;

namespace BootCamp.Chapter.Examples.AppointmentService
{
    public class Appointment
    {
        public long PersonId { get; }
        public DateTime From { get; }
        public DateTime To { get; }

        public Appointment(long personId, DateTime @from, DateTime to)
        {
            PersonId = personId;
            From = @from;
            To = to;
        }
    }
}