using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetClinicServer.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace VetClinicServer.DTOs
{
    public class PatientDTO
    {
        [SwaggerSchema(ReadOnly = true)]
        public int PatientId { get; set; }
        [Required]
        public int ClientId { get; set; }

        [Required]
        public string Species { get; set; }

        [Required]
        public string Breed { get; set; } = null!;
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
