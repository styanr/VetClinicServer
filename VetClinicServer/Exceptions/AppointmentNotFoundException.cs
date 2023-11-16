namespace VetClinicServer.Exceptions
{
    public class AppointmentNotFoundException : ResourceNotFoundException
    {
        public AppointmentNotFoundException()
            : base("Appointment(s) not found.")
        {
        }
        public AppointmentNotFoundException(int appointmentId)
            : base($"Appointment with ID {appointmentId} not found.")
        {
        }
    }
}
