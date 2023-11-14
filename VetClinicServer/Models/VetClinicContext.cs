using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.Utils;

namespace VetClinicServer.Models;

public partial class VetClinicContext : DbContext
{
    public VetClinicContext()
    {
    }

    public VetClinicContext(DbContextOptions<VetClinicContext> options)
        : base(options)
    {
    } 

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillStatus> BillStatuses { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<Medication> Medications { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<RecordType> RecordTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=VetClinicDBConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Ukrainian_CI_AS");

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasOne(d => d.Doctor).WithMany(p => p.Appointments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointments_Doctors");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointments_Patients");
        });


        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK_Invoices_1");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Bills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_Doctors");

            entity.HasOne(d => d.Patient).WithMany(p => p.Bills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_Patients");

            entity.HasOne(d => d.Status).WithMany(p => p.Bills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_BillStatus");
        });

        modelBuilder.Entity<BillStatus>(entity =>
        {
            entity.Property(e => e.StatusName).IsFixedLength();
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.Property(e => e.Specialization).HasConversion<int>();
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicalRecords_Patients");

            entity.HasOne(d => d.RecordType).WithMany(p => p.MedicalRecords).HasConstraintName("FK_MedicalRecords_RecordTypes1");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.Patients).HasConstraintName("FK_Patients_Clients");
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.HasOne(d => d.Doctor).WithMany(p => p.Prescriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prescriptions_Doctors");

            entity.HasOne(d => d.Patient).WithMany(p => p.Prescriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prescriptions_Patients");

            entity.HasMany(d => d.Medications).WithMany(d => d.Prescriptions);
        });

        modelBuilder.Entity<RecordType>(entity =>
        {
            entity.Property(e => e.RecordTypeId).ValueGeneratedNever();
        });

        Randomizer.Seed = new Random(1);

        var seeder = new DatabaseSeeder(30, 32, 20, 6, 30);

        modelBuilder.Entity<Client>().HasData(seeder.Clients);
        modelBuilder.Entity<Patient>().HasData(seeder.Patients);
        modelBuilder.Entity<Doctor>().HasData(seeder.Doctors);
        modelBuilder.Entity<Appointment>().HasData(seeder.Appointments);
        modelBuilder.Entity<Medication>().HasData(seeder.Medications);

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
