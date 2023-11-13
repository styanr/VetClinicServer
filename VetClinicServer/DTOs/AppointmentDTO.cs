using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetClinicServer.Models;
using VetClinicServer.Validation;
using Swashbuckle.AspNetCore.Annotations;

namespace VetClinicServer.DTOs
{
    public class AppointmentDTO
    {
        [SwaggerSchema(ReadOnly = true)]
        public int AppointmentId { get; set; }

        [Required]
        [AppointmentDateValidation(
            ErrorMessage = "Please enter a valid date for an appointment.")]
        public DateTime Date { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        public AppointmentType Type { get; set; }
    }
}
