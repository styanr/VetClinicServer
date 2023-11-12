using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedClientData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "clientId", "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[,]
                {
                    { 1, "609 Lynch Roads, Stokeston, Luxembourg", "Yesenia.Parker@gmail.com", "Delores", "Brown", "564-839-1602", "77901-3717" },
                    { 2, "21149 Terry Squares, Lake Una, Brazil", "Fabiola.Pouros@gmail.com", "Judy", "Goodwin", "934-766-4235", "09460-1203" },
                    { 3, "2471 Annetta Drive, Lake Zellaborough, Western Sahara", "Aleen87@gmail.com", "Jerad", "Hammes", "233-530-6887", "31134" },
                    { 4, "522 Ferry Burg, Lazaroville, Monaco", "Arnoldo_Walsh@gmail.com", "Macey", "Steuber", "756-910-0102", "18690-3271" },
                    { 5, "644 Gutmann Trafficway, Ewaldbury, Tanzania", "Seamus73@hotmail.com", "Marjolaine", "Haley", "419-680-3873", "37750-3380" },
                    { 6, "4993 Orn Lock, Bednarbury, Botswana", "Dakota.Kiehn23@hotmail.com", "Ephraim", "Hansen", "729-833-1094", "12910" },
                    { 7, "06446 Stephan Divide, Lake Angelicaport, Belize", "Diego.Gulgowski@yahoo.com", "Marley", "Schuster", "458-260-3462", "31537-1697" },
                    { 8, "642 Rhiannon Harbor, Waylonville, Botswana", "Florence40@yahoo.com", "Betty", "Batz", "381-566-1362", "14025-4197" },
                    { 9, "013 Fredy Pass, East Jaedenstad, Vanuatu", "Silas85@gmail.com", "Kasandra", "Langworth", "554-971-1346", "62837" },
                    { 10, "204 Jamison Rue, Jabarifurt, Turkmenistan", "Hannah28@yahoo.com", "Leola", "Glover", "237-265-2464", "21749-0121" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 10);
        }
    }
}
