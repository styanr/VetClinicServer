using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

[Table("BillStatus")]
public partial class BillStatus
{
    [Key]
    [Column("statusId")]
    public int StatusId { get; set; }

    [Column("statusName")]
    [StringLength(10)]
    public string StatusName { get; set; } = null!;

    [InverseProperty("Status")]
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
