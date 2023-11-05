using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

[Keyless]
public partial class AppointmentInfo
{
    [Column("appointmentId")]
    public int AppointmentId { get; set; }

    [Column("appointmentType")]
    [StringLength(50)]
    public string AppointmentType { get; set; } = null!;

    [Column("patientId")]
    public int PatientId { get; set; }

    [Column("patientSpecies")]
    [StringLength(50)]
    public string PatientSpecies { get; set; } = null!;

    [Column("patientName")]
    [StringLength(50)]
    public string? PatientName { get; set; }

    [Column("clientName")]
    [StringLength(101)]
    public string ClientName { get; set; } = null!;

    [Column("clientPhoneNumber")]
    [StringLength(20)]
    public string ClientPhoneNumber { get; set; } = null!;

    [Column("doctorId")]
    public int DoctorId { get; set; }

    [Column("doctorName")]
    [StringLength(101)]
    public string DoctorName { get; set; } = null!;
}
