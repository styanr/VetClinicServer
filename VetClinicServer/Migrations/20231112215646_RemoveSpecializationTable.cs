using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSpecializationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_DoctorSpecializations",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "DoctorSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_specializationId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "specializationId",
                table: "Doctors",
                newName: "Specialization");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specialization",
                table: "Doctors",
                newName: "specializationId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_specializationId",
                table: "Doctors",
                column: "specializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_DoctorSpecializations",
                table: "Doctors",
                column: "specializationId",
                principalTable: "DoctorSpecializations",
                principalColumn: "specializationId");
        }
    }
}
