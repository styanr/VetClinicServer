using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedAppointmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "appointmentId", "date", "doctorId", "patientId", "appointmentType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 29, 23, 33, 16, 788, DateTimeKind.Unspecified).AddTicks(957), 3, 3, 5 },
                    { 2, new DateTime(2024, 5, 13, 3, 6, 50, 526, DateTimeKind.Unspecified).AddTicks(6862), 4, 13, 3 },
                    { 3, new DateTime(2024, 9, 2, 15, 3, 54, 594, DateTimeKind.Unspecified).AddTicks(6892), 1, 14, 5 },
                    { 4, new DateTime(2023, 11, 25, 11, 42, 48, 200, DateTimeKind.Unspecified).AddTicks(2651), 4, 8, 4 },
                    { 5, new DateTime(2024, 4, 7, 1, 13, 34, 209, DateTimeKind.Unspecified).AddTicks(4126), 10, 15, 6 },
                    { 6, new DateTime(2024, 3, 2, 4, 57, 29, 255, DateTimeKind.Unspecified).AddTicks(1946), 3, 9, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1,
                column: "dateOfBirth",
                value: new DateTime(2018, 3, 26, 14, 43, 47, 835, DateTimeKind.Unspecified).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2,
                column: "dateOfBirth",
                value: new DateTime(2015, 2, 15, 2, 19, 33, 831, DateTimeKind.Unspecified).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 6, 8, 55, 56, 123, DateTimeKind.Unspecified).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4,
                column: "dateOfBirth",
                value: new DateTime(2021, 9, 16, 20, 8, 15, 550, DateTimeKind.Unspecified).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5,
                column: "dateOfBirth",
                value: new DateTime(2020, 10, 26, 2, 39, 43, 305, DateTimeKind.Unspecified).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6,
                column: "dateOfBirth",
                value: new DateTime(2022, 8, 17, 2, 58, 0, 107, DateTimeKind.Unspecified).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7,
                column: "dateOfBirth",
                value: new DateTime(2023, 1, 30, 1, 4, 13, 814, DateTimeKind.Unspecified).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8,
                column: "dateOfBirth",
                value: new DateTime(2021, 2, 23, 16, 16, 38, 721, DateTimeKind.Unspecified).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9,
                column: "dateOfBirth",
                value: new DateTime(2015, 5, 12, 5, 18, 37, 904, DateTimeKind.Unspecified).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10,
                column: "dateOfBirth",
                value: new DateTime(2020, 3, 16, 21, 34, 34, 356, DateTimeKind.Unspecified).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11,
                column: "dateOfBirth",
                value: new DateTime(2015, 1, 11, 2, 12, 0, 58, DateTimeKind.Unspecified).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12,
                column: "dateOfBirth",
                value: new DateTime(2020, 11, 26, 9, 54, 52, 757, DateTimeKind.Unspecified).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13,
                column: "dateOfBirth",
                value: new DateTime(2021, 3, 26, 18, 20, 4, 833, DateTimeKind.Unspecified).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14,
                column: "dateOfBirth",
                value: new DateTime(2015, 12, 20, 19, 15, 12, 655, DateTimeKind.Unspecified).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15,
                column: "dateOfBirth",
                value: new DateTime(2014, 7, 20, 12, 30, 10, 149, DateTimeKind.Unspecified).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16,
                column: "dateOfBirth",
                value: new DateTime(2018, 12, 23, 10, 57, 9, 991, DateTimeKind.Unspecified).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17,
                column: "dateOfBirth",
                value: new DateTime(2016, 4, 6, 11, 19, 25, 288, DateTimeKind.Unspecified).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18,
                column: "dateOfBirth",
                value: new DateTime(2016, 12, 18, 19, 23, 52, 156, DateTimeKind.Unspecified).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19,
                column: "dateOfBirth",
                value: new DateTime(2020, 4, 27, 7, 19, 48, 682, DateTimeKind.Unspecified).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20,
                column: "dateOfBirth",
                value: new DateTime(2016, 9, 2, 6, 47, 40, 23, DateTimeKind.Unspecified).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21,
                column: "dateOfBirth",
                value: new DateTime(2018, 7, 10, 1, 31, 13, 562, DateTimeKind.Unspecified).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22,
                column: "dateOfBirth",
                value: new DateTime(2015, 11, 14, 21, 35, 14, 67, DateTimeKind.Unspecified).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 22, 6, 50, 22, 804, DateTimeKind.Unspecified).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24,
                column: "dateOfBirth",
                value: new DateTime(2014, 9, 21, 1, 37, 5, 159, DateTimeKind.Unspecified).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25,
                column: "dateOfBirth",
                value: new DateTime(2015, 10, 8, 5, 31, 35, 619, DateTimeKind.Unspecified).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26,
                column: "dateOfBirth",
                value: new DateTime(2019, 6, 5, 1, 49, 35, 233, DateTimeKind.Unspecified).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27,
                column: "dateOfBirth",
                value: new DateTime(2020, 2, 26, 23, 47, 58, 893, DateTimeKind.Unspecified).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28,
                column: "dateOfBirth",
                value: new DateTime(2013, 12, 10, 13, 39, 27, 91, DateTimeKind.Unspecified).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29,
                column: "dateOfBirth",
                value: new DateTime(2022, 12, 25, 11, 38, 28, 629, DateTimeKind.Unspecified).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30,
                column: "dateOfBirth",
                value: new DateTime(2016, 11, 3, 11, 28, 2, 123, DateTimeKind.Unspecified).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31,
                column: "dateOfBirth",
                value: new DateTime(2017, 5, 6, 0, 59, 4, 316, DateTimeKind.Unspecified).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32,
                column: "dateOfBirth",
                value: new DateTime(2015, 6, 29, 3, 20, 6, 445, DateTimeKind.Unspecified).AddTicks(3226));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 6);

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
    }
}
