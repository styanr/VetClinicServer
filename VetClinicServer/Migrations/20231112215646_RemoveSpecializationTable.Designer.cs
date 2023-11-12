﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetClinicServer.Models;

#nullable disable

namespace VetClinicServer.Migrations
{
    [DbContext(typeof(VetClinicContext))]
    [Migration("20231112215646_RemoveSpecializationTable")]
    partial class RemoveSpecializationTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Ukrainian_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicationPrescription", b =>
                {
                    b.Property<int>("MedicationsMedicationId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionsPrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("MedicationsMedicationId", "PrescriptionsPrescriptionId");

                    b.HasIndex("PrescriptionsPrescriptionId");

                    b.ToTable("MedicationPrescription");
                });

            modelBuilder.Entity("VetClinicServer.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("appointmentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctorId");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("typeId");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("TypeId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("VetClinicServer.Models.AppointmentType", b =>
                {
                    b.Property<int>("AppointmentTypeId")
                        .HasColumnType("int")
                        .HasColumnName("appointmentTypeId");

                    b.Property<string>("AppointmentTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("appointmentTypeName");

                    b.HasKey("AppointmentTypeId");

                    b.ToTable("AppointmentTypes");
                });

            modelBuilder.Entity("VetClinicServer.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("billId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("amount");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctorId");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("date")
                        .HasColumnName("paymentDate");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("statusId");

                    b.HasKey("BillId")
                        .HasName("PK_Invoices_1");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StatusId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("VetClinicServer.Models.BillStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("statusId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("statusName")
                        .IsFixedLength();

                    b.HasKey("StatusId");

                    b.ToTable("BillStatus");
                });

            modelBuilder.Entity("VetClinicServer.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("clientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("postalCode");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("VetClinicServer.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("doctorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("postalCode");

                    b.Property<int>("Specialization")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("VetClinicServer.Models.MedicalRecord", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("recordId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    b.Property<int?>("RecordTypeId")
                        .HasColumnType("int")
                        .HasColumnName("recordTypeId");

                    b.HasKey("RecordId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RecordTypeId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("VetClinicServer.Models.Medication", b =>
                {
                    b.Property<int>("MedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("medicationId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicationId"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("MedicationId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("VetClinicServer.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("breed");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("clientId");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("species");

                    b.HasKey("PatientId");

                    b.HasIndex("ClientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("VetClinicServer.Models.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prescriptionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctorId");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("VetClinicServer.Models.RecordType", b =>
                {
                    b.Property<int>("RecordTypeId")
                        .HasColumnType("int")
                        .HasColumnName("recordTypeId");

                    b.Property<string>("RecordTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("recordTypeName");

                    b.HasKey("RecordTypeId");

                    b.ToTable("RecordTypes");
                });

            modelBuilder.Entity("MedicationPrescription", b =>
                {
                    b.HasOne("VetClinicServer.Models.Medication", null)
                        .WithMany()
                        .HasForeignKey("MedicationsMedicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetClinicServer.Models.Prescription", null)
                        .WithMany()
                        .HasForeignKey("PrescriptionsPrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VetClinicServer.Models.Appointment", b =>
                {
                    b.HasOne("VetClinicServer.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .IsRequired()
                        .HasConstraintName("FK_Appointments_Doctors");

                    b.HasOne("VetClinicServer.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_Appointments_Patients");

                    b.HasOne("VetClinicServer.Models.AppointmentType", "Type")
                        .WithMany("Appointments")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_Appointments_AppointmentTypes");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("VetClinicServer.Models.Bill", b =>
                {
                    b.HasOne("VetClinicServer.Models.Doctor", "Doctor")
                        .WithMany("Bills")
                        .HasForeignKey("DoctorId")
                        .IsRequired()
                        .HasConstraintName("FK_Bills_Doctors");

                    b.HasOne("VetClinicServer.Models.Patient", "Patient")
                        .WithMany("Bills")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_Bills_Patients");

                    b.HasOne("VetClinicServer.Models.BillStatus", "Status")
                        .WithMany("Bills")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Bills_BillStatus");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("VetClinicServer.Models.MedicalRecord", b =>
                {
                    b.HasOne("VetClinicServer.Models.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_MedicalRecords_Patients");

                    b.HasOne("VetClinicServer.Models.RecordType", "RecordType")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("RecordTypeId")
                        .HasConstraintName("FK_MedicalRecords_RecordTypes1");

                    b.Navigation("Patient");

                    b.Navigation("RecordType");
                });

            modelBuilder.Entity("VetClinicServer.Models.Patient", b =>
                {
                    b.HasOne("VetClinicServer.Models.Client", "Client")
                        .WithMany("Patients")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Patients_Clients");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VetClinicServer.Models.Prescription", b =>
                {
                    b.HasOne("VetClinicServer.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .IsRequired()
                        .HasConstraintName("FK_Prescriptions_Doctors");

                    b.HasOne("VetClinicServer.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_Prescriptions_Patients");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("VetClinicServer.Models.AppointmentType", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("VetClinicServer.Models.BillStatus", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("VetClinicServer.Models.Client", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("VetClinicServer.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Bills");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("VetClinicServer.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Bills");

                    b.Navigation("MedicalRecords");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("VetClinicServer.Models.RecordType", b =>
                {
                    b.Navigation("MedicalRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
