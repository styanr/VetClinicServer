using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class DoctorSpecialization
{
    [Key]
    [Column("specializationId")]
    public int SpecializationId { get; set; }

    [Column("specializationName")]
    [StringLength(50)]
    public string SpecializationName { get; set; } = null!;

    [InverseProperty("Specialization")]
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
