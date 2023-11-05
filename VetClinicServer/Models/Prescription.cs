using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class Prescription
{
    [Key]
    [Column("prescriptionId")]
    public int PrescriptionId { get; set; }

    [Column("patientId")]
    public int PatientId { get; set; }

    [Column("doctorId")]
    public int DoctorId { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Prescriptions")]
    public virtual Doctor Doctor { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("Prescriptions")]
    public virtual Patient Patient { get; set; } = null!;

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
