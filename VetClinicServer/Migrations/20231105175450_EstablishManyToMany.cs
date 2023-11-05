using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class EstablishManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentTypes",
                columns: table => new
                {
                    appointmentTypeId = table.Column<int>(type: "int", nullable: false),
                    appointmentTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTypes", x => x.appointmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BillStatus",
                columns: table => new
                {
                    statusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatus", x => x.statusId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSpecializations",
                columns: table => new
                {
                    specializationId = table.Column<int>(type: "int", nullable: false),
                    specializationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecializations", x => x.specializationId);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    medicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.medicationId);
                });

            migrationBuilder.CreateTable(
                name: "RecordTypes",
                columns: table => new
                {
                    recordTypeId = table.Column<int>(type: "int", nullable: false),
                    recordTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordTypes", x => x.recordTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    patientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    species = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.patientId);
                    table.ForeignKey(
                        name: "FK_Patients_Clients",
                        column: x => x.clientId,
                        principalTable: "Clients",
                        principalColumn: "clientId");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    doctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    specializationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.doctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_DoctorSpecializations",
                        column: x => x.specializationId,
                        principalTable: "DoctorSpecializations",
                        principalColumn: "specializationId");
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    recordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    recordTypeId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.recordId);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId");
                    table.ForeignKey(
                        name: "FK_MedicalRecords_RecordTypes1",
                        column: x => x.recordTypeId,
                        principalTable: "RecordTypes",
                        principalColumn: "recordTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    appointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.appointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_AppointmentTypes",
                        column: x => x.typeId,
                        principalTable: "AppointmentTypes",
                        principalColumn: "appointmentTypeId");
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "doctorId");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    billId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    paymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    statusId = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices_1", x => x.billId);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatus",
                        column: x => x.statusId,
                        principalTable: "BillStatus",
                        principalColumn: "statusId");
                    table.ForeignKey(
                        name: "FK_Bills_Doctors",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "doctorId");
                    table.ForeignKey(
                        name: "FK_Bills_Patients",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    prescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.prescriptionId);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "doctorId");
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId");
                });

            migrationBuilder.CreateTable(
                name: "MedicationPrescription",
                columns: table => new
                {
                    MedicationsMedicationId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionsPrescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationPrescription", x => new { x.MedicationsMedicationId, x.PrescriptionsPrescriptionId });
                    table.ForeignKey(
                        name: "FK_MedicationPrescription_Medications_MedicationsMedicationId",
                        column: x => x.MedicationsMedicationId,
                        principalTable: "Medications",
                        principalColumn: "medicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationPrescription_Prescriptions_PrescriptionsPrescriptionId",
                        column: x => x.PrescriptionsPrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "prescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_doctorId",
                table: "Appointments",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_patientId",
                table: "Appointments",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_typeId",
                table: "Appointments",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_doctorId",
                table: "Bills",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_patientId",
                table: "Bills",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_statusId",
                table: "Bills",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_specializationId",
                table: "Doctors",
                column: "specializationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_patientId",
                table: "MedicalRecords",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_recordTypeId",
                table: "MedicalRecords",
                column: "recordTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationPrescription_PrescriptionsPrescriptionId",
                table: "MedicationPrescription",
                column: "PrescriptionsPrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_clientId",
                table: "Patients",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_doctorId",
                table: "Prescriptions",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_patientId",
                table: "Prescriptions",
                column: "patientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "MedicationPrescription");

            migrationBuilder.DropTable(
                name: "AppointmentTypes");

            migrationBuilder.DropTable(
                name: "BillStatus");

            migrationBuilder.DropTable(
                name: "RecordTypes");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "DoctorSpecializations");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
