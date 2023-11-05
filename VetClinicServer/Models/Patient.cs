using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class Patient
{
    [Key]
    [Column("patientId")]
    public int PatientId { get; set; }

    [Column("species")]
    [StringLength(50)]
    public string Species { get; set; } = null!;

    [Column("breed")]
    [StringLength(50)]
    public string Breed { get; set; } = null!;

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("dateOfBirth", TypeName = "date")]
    public DateTime DateOfBirth { get; set; }

    [Column("clientId")]
    public int? ClientId { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("Patient")]
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    [ForeignKey("ClientId")]
    [InverseProperty("Patients")]
    public virtual Client? Client { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    [InverseProperty("Patient")]
    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}
