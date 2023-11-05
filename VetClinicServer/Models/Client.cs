using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace VetClinicServer.Models;

public partial class Client
{
    [Key]
    [Column("clientId")]
    public int ClientId { get; set; }

    [Column("firstName")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("lastName")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("phoneNumber")]
    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("postalCode")]
    [StringLength(50)]
    public string? PostalCode { get; set; }

    [Column("address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [InverseProperty("Client")]
    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
