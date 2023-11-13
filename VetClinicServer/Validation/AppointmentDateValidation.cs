using System.ComponentModel.DataAnnotations;

namespace VetClinicServer.Validation
{
    public class AppointmentDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dt = Convert.ToDateTime(value);
            return dt > DateTime.Today;
        }
    }
}
