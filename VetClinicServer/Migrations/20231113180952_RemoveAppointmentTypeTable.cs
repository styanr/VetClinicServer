using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAppointmentTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentTypes",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_typeId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Specialization",
                table: "Doctors",
                newName: "specialization");

            migrationBuilder.RenameColumn(
                name: "typeId",
                table: "Appointments",
                newName: "appointmentType");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1,
                column: "dateOfBirth",
                value: new DateTime(2018, 3, 27, 10, 53, 39, 986, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2,
                column: "dateOfBirth",
                value: new DateTime(2015, 2, 15, 22, 29, 25, 982, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 7, 5, 5, 48, 273, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4,
                column: "dateOfBirth",
                value: new DateTime(2021, 9, 17, 16, 18, 7, 700, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5,
                column: "dateOfBirth",
                value: new DateTime(2020, 10, 26, 22, 49, 35, 455, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6,
                column: "dateOfBirth",
                value: new DateTime(2022, 8, 17, 23, 7, 52, 258, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7,
                column: "dateOfBirth",
                value: new DateTime(2023, 1, 30, 21, 14, 5, 964, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8,
                column: "dateOfBirth",
                value: new DateTime(2021, 2, 24, 12, 26, 30, 871, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9,
                column: "dateOfBirth",
                value: new DateTime(2015, 5, 13, 1, 28, 30, 55, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10,
                column: "dateOfBirth",
                value: new DateTime(2020, 3, 17, 17, 44, 26, 507, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11,
                column: "dateOfBirth",
                value: new DateTime(2015, 1, 11, 22, 21, 52, 209, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12,
                column: "dateOfBirth",
                value: new DateTime(2020, 11, 27, 6, 4, 44, 908, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13,
                column: "dateOfBirth",
                value: new DateTime(2021, 3, 27, 14, 29, 56, 984, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14,
                column: "dateOfBirth",
                value: new DateTime(2015, 12, 21, 15, 25, 4, 805, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15,
                column: "dateOfBirth",
                value: new DateTime(2014, 7, 21, 8, 40, 2, 300, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16,
                column: "dateOfBirth",
                value: new DateTime(2018, 12, 24, 7, 7, 2, 142, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17,
                column: "dateOfBirth",
                value: new DateTime(2016, 4, 7, 7, 29, 17, 439, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18,
                column: "dateOfBirth",
                value: new DateTime(2016, 12, 19, 15, 33, 44, 306, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19,
                column: "dateOfBirth",
                value: new DateTime(2020, 4, 28, 3, 29, 40, 833, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20,
                column: "dateOfBirth",
                value: new DateTime(2016, 9, 3, 2, 57, 32, 174, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21,
                column: "dateOfBirth",
                value: new DateTime(2018, 7, 10, 21, 41, 5, 712, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22,
                column: "dateOfBirth",
                value: new DateTime(2015, 11, 15, 17, 45, 6, 217, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 23, 3, 0, 14, 955, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24,
                column: "dateOfBirth",
                value: new DateTime(2014, 9, 21, 21, 46, 57, 309, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25,
                column: "dateOfBirth",
                value: new DateTime(2015, 10, 9, 1, 41, 27, 770, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 5, 21, 59, 27, 384, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27,
                column: "dateOfBirth",
                value: new DateTime(2020, 2, 27, 19, 57, 51, 43, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28,
                column: "dateOfBirth",
                value: new DateTime(2013, 12, 11, 9, 49, 19, 241, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29,
                column: "dateOfBirth",
                value: new DateTime(2022, 12, 26, 7, 48, 20, 780, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30,
                column: "dateOfBirth",
                value: new DateTime(2016, 11, 4, 7, 37, 54, 274, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 6, 21, 8, 56, 467, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32,
                column: "dateOfBirth",
                value: new DateTime(2015, 6, 29, 23, 29, 58, 595, DateTimeKind.Local).AddTicks(9252));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specialization",
                table: "Doctors",
                newName: "Specialization");

            migrationBuilder.RenameColumn(
                name: "appointmentType",
                table: "Appointments",
                newName: "typeId");

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

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1,
                column: "dateOfBirth",
                value: new DateTime(2018, 3, 27, 8, 47, 55, 345, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2,
                column: "dateOfBirth",
                value: new DateTime(2015, 2, 15, 20, 23, 41, 341, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 7, 3, 0, 3, 633, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4,
                column: "dateOfBirth",
                value: new DateTime(2021, 9, 17, 14, 12, 23, 60, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5,
                column: "dateOfBirth",
                value: new DateTime(2020, 10, 26, 20, 43, 50, 815, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6,
                column: "dateOfBirth",
                value: new DateTime(2022, 8, 17, 21, 2, 7, 617, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7,
                column: "dateOfBirth",
                value: new DateTime(2023, 1, 30, 19, 8, 21, 324, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8,
                column: "dateOfBirth",
                value: new DateTime(2021, 2, 24, 10, 20, 46, 231, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9,
                column: "dateOfBirth",
                value: new DateTime(2015, 5, 12, 23, 22, 45, 414, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10,
                column: "dateOfBirth",
                value: new DateTime(2020, 3, 17, 15, 38, 41, 866, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11,
                column: "dateOfBirth",
                value: new DateTime(2015, 1, 11, 20, 16, 7, 568, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12,
                column: "dateOfBirth",
                value: new DateTime(2020, 11, 27, 3, 59, 0, 268, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13,
                column: "dateOfBirth",
                value: new DateTime(2021, 3, 27, 12, 24, 12, 344, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14,
                column: "dateOfBirth",
                value: new DateTime(2015, 12, 21, 13, 19, 20, 165, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15,
                column: "dateOfBirth",
                value: new DateTime(2014, 7, 21, 6, 34, 17, 660, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16,
                column: "dateOfBirth",
                value: new DateTime(2018, 12, 24, 5, 1, 17, 502, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17,
                column: "dateOfBirth",
                value: new DateTime(2016, 4, 7, 5, 23, 32, 798, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18,
                column: "dateOfBirth",
                value: new DateTime(2016, 12, 19, 13, 27, 59, 666, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19,
                column: "dateOfBirth",
                value: new DateTime(2020, 4, 28, 1, 23, 56, 192, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20,
                column: "dateOfBirth",
                value: new DateTime(2016, 9, 3, 0, 51, 47, 533, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21,
                column: "dateOfBirth",
                value: new DateTime(2018, 7, 10, 19, 35, 21, 72, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22,
                column: "dateOfBirth",
                value: new DateTime(2015, 11, 15, 15, 39, 21, 577, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 23, 0, 54, 30, 314, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24,
                column: "dateOfBirth",
                value: new DateTime(2014, 9, 21, 19, 41, 12, 669, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25,
                column: "dateOfBirth",
                value: new DateTime(2015, 10, 8, 23, 35, 43, 129, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 5, 19, 53, 42, 743, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27,
                column: "dateOfBirth",
                value: new DateTime(2020, 2, 27, 17, 52, 6, 403, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28,
                column: "dateOfBirth",
                value: new DateTime(2013, 12, 11, 7, 43, 34, 601, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29,
                column: "dateOfBirth",
                value: new DateTime(2022, 12, 26, 5, 42, 36, 139, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30,
                column: "dateOfBirth",
                value: new DateTime(2016, 11, 4, 5, 32, 9, 634, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 6, 19, 3, 11, 827, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32,
                column: "dateOfBirth",
                value: new DateTime(2015, 6, 29, 21, 24, 13, 955, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_typeId",
                table: "Appointments",
                column: "typeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentTypes",
                table: "Appointments",
                column: "typeId",
                principalTable: "AppointmentTypes",
                principalColumn: "appointmentTypeId");
        }
    }
}
