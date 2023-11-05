using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class RecordType
{
    [Key]
    [Column("recordTypeId")]
    public int RecordTypeId { get; set; }

    [Column("recordTypeName")]
    [StringLength(50)]
    public string RecordTypeName { get; set; } = null!;

    [InverseProperty("RecordType")]
    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}
