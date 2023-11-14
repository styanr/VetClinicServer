namespace VetClinicServer.Exceptions
{
    public class MedicationNotFoundException : ResourceNotFoundException
    {
        public MedicationNotFoundException(int medicationId)
            : base($"Medication with ID {medicationId} not found")
        {
        }
    }
}
