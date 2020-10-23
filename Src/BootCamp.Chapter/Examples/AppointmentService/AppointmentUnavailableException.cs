using System;

namespace BootCamp.Chapter.Examples.AppointmentService
{
    public class AppointmentUnavailableException : Exception
    {
        public AppointmentUnavailableException(Appointment appointment) 
            : base($"Person with id {appointment.PersonId} cannot book an appointment." +
                   $"Time [{appointment.From}-{appointment.To}] for appointment is reserved.")
        {
            
        }
    }
}
