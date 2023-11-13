using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatientAndDoctorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "clientId", "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[,]
                {
                    { 11, "59776 Tremblay Dale, Connellybury, Mali", "Danika14@gmail.com", "Audreanne", "Rolfson", "358-799-6719", "98166" },
                    { 12, "0638 Erika Club, Minnieside, Cameroon", "Estell_Haley@hotmail.com", "Opal", "Konopelski", "325-317-2157", "40565-9746" },
                    { 13, "958 Misael Ferry, Lake Dulcefurt, Saint Helena", "Ella92@hotmail.com", "Jairo", "Spinka", "833-866-4282", "37814" },
                    { 14, "4734 Louisa Village, Constantinberg, Denmark", "Demetrius.Thompson@hotmail.com", "Shaniya", "Price", "680-551-5037", "32480" },
                    { 15, "9150 Schinner River, Nikolasbury, Cameroon", "Grayson_Rempel34@yahoo.com", "Marilie", "Weissnat", "962-837-0947", "06683" },
                    { 16, "69635 Rosie Way, New Camila, Luxembourg", "Jared.Hansen54@hotmail.com", "Kenya", "Pfeffer", "329-569-9300", "15395" },
                    { 17, "610 Felipe Islands, Nedchester, Burundi", "Bennett56@hotmail.com", "Guido", "Price", "252-567-0476", "75928" },
                    { 18, "9324 Samara Cliffs, North Miles, Bulgaria", "Ursula.Bergstrom94@hotmail.com", "Fredy", "Bahringer", "368-870-6039", "51825-2930" },
                    { 19, "4875 Von Streets, Wittingview, Trinidad and Tobago", "Yoshiko_Kris50@gmail.com", "Deondre", "D'Amore", "834-646-1971", "56029-5896" },
                    { 20, "2652 Botsford Spring, Cortezburgh, Slovenia", "Immanuel_Dach6@gmail.com", "Jaycee", "Schoen", "569-598-4892", "57752" },
                    { 21, "405 Earline Crescent, Port Berneiceville, Dominican Republic", "Mollie_Stracke@hotmail.com", "Kyla", "Shields", "873-977-6607", "62153" },
                    { 22, "17865 Glover Pine, Rodrigoberg, Belize", "Amina_Hyatt@hotmail.com", "Louvenia", "Okuneva", "285-516-6394", "60450" },
                    { 23, "14250 Doyle Field, Robbiehaven, Malaysia", "Michael.Swaniawski@hotmail.com", "Dasia", "Kling", "666-551-7336", "06341-3558" },
                    { 24, "10718 Kelsi Valley, New Guiseppe, Seychelles", "Odessa27@yahoo.com", "Larry", "Gerlach", "491-909-2387", "17988-1145" },
                    { 25, "794 Ryan Divide, Cummeratamouth, Pitcairn Islands", "Kaylee.Ryan@gmail.com", "Kiana", "Berge", "745-464-3787", "55668-7955" },
                    { 26, "010 Parker Alley, South Adriana, Nicaragua", "Benedict91@hotmail.com", "Shaina", "Swaniawski", "957-210-5976", "83906" },
                    { 27, "3942 Cletus Avenue, Jamarcuston, Luxembourg", "Soledad_Smith@gmail.com", "Michale", "O'Conner", "707-440-0961", "38822" },
                    { 28, "5445 Litzy Divide, Handberg, Micronesia", "Magali3@gmail.com", "Destini", "Windler", "840-657-2761", "84455" },
                    { 29, "49528 Emiliano View, Lake Wilbertchester, Puerto Rico", "Helen_Erdman@yahoo.com", "Haylie", "Ryan", "464-888-4077", "06380-9432" },
                    { 30, "66819 Sipes Ville, Demetriusstad, Fiji", "Keyshawn.Ratke@gmail.com", "Lauriane", "Kozey", "771-920-9125", "20537" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "doctorId", "address", "firstName", "lastName", "postalCode", "Specialization" },
                values: new object[,]
                {
                    { 1, "6571 Feil Rue, Lake Humbertoborough, Maldives", "Aryanna", "Brekke", "53669-5034", 2 },
                    { 2, "3116 Robel Ridge, Johnathonhaven, Montenegro", "Trudie", "Orn", "57541", 0 },
                    { 3, "25568 Schaefer Prairie, South Elissa, Puerto Rico", "Jamie", "Bins", "80482", 2 },
                    { 4, "28503 Douglas Way, West Noelside, Tunisia", "Sophia", "Schoen", "90278", 2 },
                    { 5, "48043 Ardith Prairie, South Myrticetown, Madagascar", "Timothy", "Pacocha", "06517", 0 },
                    { 6, "711 Garland Court, East Jabarichester, Serbia", "Ocie", "Harber", "12409", 2 },
                    { 7, "3241 Agustina Locks, Kertzmannview, Virgin Islands, U.S.", "Rosalee", "Maggio", "98473-9818", 2 },
                    { 8, "615 Haley Park, Considineberg, Falkland Islands (Malvinas)", "Celestine", "Barrows", "55849", 1 },
                    { 9, "27842 Wanda Extension, West Domenic, Sweden", "Reed", "Wolf", "71535", 1 },
                    { 10, "1356 Kohler Green, Evansborough, Guinea-Bissau", "Hector", "Conroy", "52612-2613", 1 },
                    { 11, "209 Smitham Tunnel, Jessystad, South Africa", "Madalyn", "Howe", "89296-6639", 0 },
                    { 12, "793 Kertzmann Harbors, Lake Clemens, Bhutan", "Celia", "Terry", "79832", 1 },
                    { 13, "789 Marietta Turnpike, Coltshire, American Samoa", "Bryon", "Kemmer", "86034-7170", 1 },
                    { 14, "27070 Jasmin Tunnel, Wolffbury, Kuwait", "Keyshawn", "Larson", "52747", 2 },
                    { 15, "33179 Leffler Junctions, North Imaton, Tonga", "Kaylie", "Quitzon", "93169-4740", 2 },
                    { 16, "096 Lamont Way, East Christa, Suriname", "Burdette", "Considine", "90558", 2 },
                    { 17, "906 Nikolas Lane, Lake Lillianaborough, Portugal", "Justina", "Kiehn", "12265-5532", 0 },
                    { 18, "27322 Gulgowski Divide, Tiffanytown, French Polynesia", "Lyla", "Waters", "51801-6748", 0 },
                    { 19, "35177 Davis Place, Ortizbury, New Zealand", "Cheyenne", "O'Kon", "82316-7993", 1 },
                    { 20, "662 Connelly Mill, East Rudolph, Eritrea", "Valentine", "Hermiston", "55878", 0 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "patientId", "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[,]
                {
                    { 1, "Angora", 10, new DateTime(2018, 3, 27, 8, 47, 55, 345, DateTimeKind.Local).AddTicks(7356), "Arlene", "Bird" },
                    { 5, "Lionhead", 9, new DateTime(2020, 10, 26, 20, 43, 50, 815, DateTimeKind.Local).AddTicks(3136), "Casey", "Hamster" },
                    { 8, "Poodle", 9, new DateTime(2021, 2, 24, 10, 20, 46, 231, DateTimeKind.Local).AddTicks(3141), "Jeramy", "Rabbit" },
                    { 13, "Syrian", 4, new DateTime(2021, 3, 27, 12, 24, 12, 344, DateTimeKind.Local).AddTicks(883), "Kirstin", "Rabbit" },
                    { 15, "Bulldog", 3, new DateTime(2014, 7, 21, 6, 34, 17, 660, DateTimeKind.Local).AddTicks(905), "Schuyler", "Bird" },
                    { 20, "Cockatiel", 4, new DateTime(2016, 9, 3, 0, 51, 47, 533, DateTimeKind.Local).AddTicks(7358), "Camila", "Rabbit" },
                    { 24, "Dwarf", 3, new DateTime(2014, 9, 21, 19, 41, 12, 669, DateTimeKind.Local).AddTicks(4544), "Reagan", "Bird" },
                    { 26, "Winter White", 9, new DateTime(2019, 6, 5, 19, 53, 42, 743, DateTimeKind.Local).AddTicks(6035), "Joshuah", "Cat" },
                    { 28, "Poodle", 9, new DateTime(2013, 12, 11, 7, 43, 34, 601, DateTimeKind.Local).AddTicks(1599), "Hilbert", "Bird" },
                    { 29, "Bulldog", 10, new DateTime(2022, 12, 26, 5, 42, 36, 139, DateTimeKind.Local).AddTicks(8646), "Iliana", "Bird" },
                    { 30, "Beagle", 1, new DateTime(2016, 11, 4, 5, 32, 9, 634, DateTimeKind.Local).AddTicks(306), "Nikko", "Hamster" },
                    { 2, "Poodle", 21, new DateTime(2015, 2, 15, 20, 23, 41, 341, DateTimeKind.Local).AddTicks(9226), "Maya", "Dog" },
                    { 3, "Cockatiel", 15, new DateTime(2017, 5, 7, 3, 0, 3, 633, DateTimeKind.Local).AddTicks(4998), "Jeremy", "Dog" },
                    { 4, "Angora", 22, new DateTime(2021, 9, 17, 14, 12, 23, 60, DateTimeKind.Local).AddTicks(4224), "Burley", "Rabbit" },
                    { 6, "Maine Coon", 19, new DateTime(2022, 8, 17, 21, 2, 7, 617, DateTimeKind.Local).AddTicks(5743), "Ernest", "Cat" },
                    { 7, "Maine Coon", 26, new DateTime(2023, 1, 30, 19, 8, 21, 324, DateTimeKind.Local).AddTicks(5247), "Brain", "Bird" },
                    { 9, "Beagle", 25, new DateTime(2015, 5, 12, 23, 22, 45, 414, DateTimeKind.Local).AddTicks(5846), "Harmony", "Rabbit" },
                    { 10, "Poodle", 11, new DateTime(2020, 3, 17, 15, 38, 41, 866, DateTimeKind.Local).AddTicks(8254), "Wilson", "Bird" },
                    { 11, "Finch", 12, new DateTime(2015, 1, 11, 20, 16, 7, 568, DateTimeKind.Local).AddTicks(7081), "Alfred", "Cat" },
                    { 12, "Finch", 28, new DateTime(2020, 11, 27, 3, 59, 0, 268, DateTimeKind.Local).AddTicks(522), "Opal", "Hamster" },
                    { 14, "Parrot", 25, new DateTime(2015, 12, 21, 13, 19, 20, 165, DateTimeKind.Local).AddTicks(2566), "Hassan", "Rabbit" },
                    { 16, "Persian", 26, new DateTime(2018, 12, 24, 5, 1, 17, 502, DateTimeKind.Local).AddTicks(1050), "Elyssa", "Rabbit" },
                    { 17, "Maine Coon", 11, new DateTime(2016, 4, 7, 5, 23, 32, 798, DateTimeKind.Local).AddTicks(8678), "Vincent", "Cat" },
                    { 18, "Maine Coon", 30, new DateTime(2016, 12, 19, 13, 27, 59, 666, DateTimeKind.Local).AddTicks(4492), "Deangelo", "Dog" },
                    { 19, "Sphynx", 15, new DateTime(2020, 4, 28, 1, 23, 56, 192, DateTimeKind.Local).AddTicks(9576), "Clifton", "Dog" },
                    { 21, "Dutch", 24, new DateTime(2018, 7, 10, 19, 35, 21, 72, DateTimeKind.Local).AddTicks(2383), "Clementine", "Hamster" },
                    { 22, "Lionhead", 19, new DateTime(2015, 11, 15, 15, 39, 21, 577, DateTimeKind.Local).AddTicks(2792), "Bella", "Dog" },
                    { 23, "Bulldog", 20, new DateTime(2019, 6, 23, 0, 54, 30, 314, DateTimeKind.Local).AddTicks(7131), "Edison", "Rabbit" },
                    { 25, "Bulldog", 21, new DateTime(2015, 10, 8, 23, 35, 43, 129, DateTimeKind.Local).AddTicks(8567), "Mohammad", "Bird" },
                    { 27, "German Shepherd", 27, new DateTime(2020, 2, 27, 17, 52, 6, 403, DateTimeKind.Local).AddTicks(1734), "Laurel", "Cat" },
                    { 31, "Dutch", 22, new DateTime(2017, 5, 6, 19, 3, 11, 827, DateTimeKind.Local).AddTicks(390), "Darryl", "Hamster" },
                    { 32, "Winter White", 17, new DateTime(2015, 6, 29, 21, 24, 13, 955, DateTimeKind.Local).AddTicks(4768), "Gerard", "Hamster" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 30);
        }
    }
}
