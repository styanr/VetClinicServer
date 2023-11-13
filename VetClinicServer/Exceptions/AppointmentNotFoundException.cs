namespace VetClinicServer.Exceptions
{
    public class AppointmentNotFoundException : ResourceNotFoundException
    {
        public AppointmentNotFoundException(int appointmentId)
            : base($"Appointment with ID {appointmentId} not found.")
        {
        }
    }
}
