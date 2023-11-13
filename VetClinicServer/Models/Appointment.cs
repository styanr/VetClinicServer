using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public enum AppointmentType
{
    Consultation,
    Examination,
    Vaccination,
    Surgery,
    FollowUp,
    Diagnostic,
    Therapy,
    Emergency,
    RoutineCheckup
}

public partial class Appointment
{
    [Key]
    [Column("appointmentId")]
    public int AppointmentId { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("doctorId")]
    public int DoctorId { get; set; }

    [Column("patientId")]
    public int PatientId { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Appointments")]
    public virtual Doctor Doctor { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("Appointments")]
    public virtual Patient Patient { get; set; } = null!;

    [Column("appointmentType")]
    public AppointmentType? Type { get; set; }
}
