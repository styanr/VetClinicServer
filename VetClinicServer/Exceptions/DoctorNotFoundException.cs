namespace VetClinicServer.Exceptions
{
    public class DoctorNotFoundException : ResourceNotFoundException
    {
        public DoctorNotFoundException(int doctorId) 
            : base($"Doctor with ID {doctorId} not found")
        {
        }
    }
}
