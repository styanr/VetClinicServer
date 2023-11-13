using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetClinicServer.Models;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Text.Json.Serialization;

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
        public DoctorSpecialization Specialization { get; set; }

    }
}
