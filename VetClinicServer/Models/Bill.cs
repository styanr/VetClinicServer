using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class Bill
{
    [Key]
    [Column("billId")]
    public int BillId { get; set; }

    [Column("patientId")]
    public int PatientId { get; set; }

    [Column("amount", TypeName = "decimal(10, 2)")]
    public decimal Amount { get; set; }

    [Column("paymentDate", TypeName = "date")]
    public DateTime? PaymentDate { get; set; }

    [Column("statusId")]
    public int StatusId { get; set; }

    [Column("doctorId")]
    public int DoctorId { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Bills")]
    public virtual Doctor Doctor { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("Bills")]
    public virtual Patient Patient { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Bills")]
    public virtual BillStatus Status { get; set; } = null!;
}
