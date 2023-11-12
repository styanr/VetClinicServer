using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetClinicServer.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace VetClinicServer.DTOs
{
    public class DoctorDTO
    {
        [SwaggerSchema(ReadOnly = true)]
        public int DoctorId { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;
        
        [Required]
        public int Specialization { get; set; }

    }
}
