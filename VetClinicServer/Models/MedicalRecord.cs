using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class MedicalRecord
{
    [Key]
    [Column("recordId")]
    public int RecordId { get; set; }

    [Column("patientId")]
    public int PatientId { get; set; }

    [Column("recordTypeId")]
    public int? RecordTypeId { get; set; }

    [Column("date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("MedicalRecords")]
    public virtual Patient Patient { get; set; } = null!;

    [ForeignKey("RecordTypeId")]
    [InverseProperty("MedicalRecords")]
    public virtual RecordType? RecordType { get; set; }
}
