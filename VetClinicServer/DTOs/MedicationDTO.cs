using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VetClinicServer.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace VetClinicServer.DTOs
{
    public class MedicationDTO
    {
        [SwaggerSchema(ReadOnly = true)]
        public int MedicationId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string? Description { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
