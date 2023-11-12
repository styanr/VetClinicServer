namespace VetClinicServer.Exceptions
{
    public class PatientNotFoundException : ResourceNotFoundException
    {
        public PatientNotFoundException(int patientId)
            : base($"Patient with ID {patientId} not found.")
        {
        }
    }
}
