using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class AppointmentType
{
    [Key]
    [Column("appointmentTypeId")]
    public int AppointmentTypeId { get; set; }

    [Column("appointmentTypeName")]
    [StringLength(50)]
    public string AppointmentTypeName { get; set; } = null!;

    [InverseProperty("Type")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
