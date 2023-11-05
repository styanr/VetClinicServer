using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class Doctor
{
    [Key]
    [Column("doctorId")]
    public int DoctorId { get; set; }

    [Column("firstName")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("lastName")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("postalCode")]
    [StringLength(50)]
    public string PostalCode { get; set; } = null!;

    [Column("address")]
    [StringLength(200)]
    public string Address { get; set; } = null!;

    [Column("specializationId")]
    public int SpecializationId { get; set; }

    [InverseProperty("Doctor")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("Doctor")]
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    [InverseProperty("Doctor")]
    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    [ForeignKey("SpecializationId")]
    [InverseProperty("Doctors")]
    public virtual DoctorSpecialization Specialization { get; set; } = null!;
}
