using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinicServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedMedicationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 1,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 7, 6, 18, 18, 0, 785, DateTimeKind.Unspecified).AddTicks(3976), 2, 22, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 2,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 6, 18, 22, 19, 40, 665, DateTimeKind.Unspecified).AddTicks(9596), 14, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 3,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 25, 21, 835, DateTimeKind.Unspecified).AddTicks(9761), 14, 31, 8 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 4,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 3, 11, 4, 37, 34, 133, DateTimeKind.Unspecified).AddTicks(9758), 6, 12, 7 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 5,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 9, 14, 8, 57, 53, 154, DateTimeKind.Unspecified).AddTicks(3542), 4, 31, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 6,
                columns: new[] { "date", "doctorId", "patientId" },
                values: new object[] { new DateTime(2024, 3, 24, 23, 30, 37, 31, DateTimeKind.Unspecified).AddTicks(1267), 13, 5 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 1,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "859 Ayden Causeway, South Leila, Saudi Arabia", "Jaquelin_OConner81@yahoo.com", "Brooks", "Schneider", "484-768-4978", "44471-5110" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 2,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "753 Lowe Tunnel, Port Artton, Nicaragua", "Rhiannon.OConner18@gmail.com", "Haskell", "Hodkiewicz", "861-938-6044", "73635" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 3,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "120 West Mission, Larissaton, France", "Saige_Conn@hotmail.com", "Niko", "Kuhn", "523-833-8021", "79139" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 4,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "69457 Rosa Fields, Ignaciochester, Virgin Islands, British", "Hadley50@hotmail.com", "Maxime", "Rath", "920-227-6530", "04359" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 5,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "231 Elmira Vista, Brainport, Philippines", "Kira_Klein@hotmail.com", "Guiseppe", "Lueilwitz", "963-984-9011", "17977-1006" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 6,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "1295 Mercedes Key, West Helen, Kenya", "Dock65@yahoo.com", "Cornell", "Corwin", "637-407-3001", "79667-6671" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 7,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "32923 Modesto Fort, Wiltonmouth, Bosnia and Herzegovina", "Laverna.Bogisich@yahoo.com", "Zackary", "Hammes", "461-267-2249", "66501-9360" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 8,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "151 Luella Village, Lake Simeon, Montenegro", "Sabina37@hotmail.com", "Icie", "Reilly", "470-251-3146", "90238-5160" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 9,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "134 Heathcote Manor, Kshlerinmouth, Djibouti", "Zelma.Larson91@gmail.com", "Mandy", "Lubowitz", "423-955-4019", "80983-1545" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 10,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "52931 MacGyver Island, Stanleyside, Luxembourg", "Amaya_Langworth96@gmail.com", "Lela", "Carter", "762-769-6614", "78027-4748" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 11,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "3051 Sabryna Square, South Annabell, Falkland Islands (Malvinas)", "Krystal.Tromp90@yahoo.com", "Ubaldo", "Predovic", "624-366-7978", "72565-0585" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 12,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "379 Alejandrin Mission, New Jack, Cook Islands", "Dayne3@gmail.com", "Anne", "Ferry", "251-860-4971", "76022" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 13,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "7094 Herzog Loaf, South Elvie, Kenya", "Milo16@gmail.com", "Fiona", "Moore", "741-649-6576", "42803-9411" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 14,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "496 Philip Port, Hazleburgh, Sudan", "Davin.Heaney@gmail.com", "Kole", "Erdman", "614-297-9686", "12073-7128" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 15,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "98106 Price Viaduct, West Lonview, Belgium", "Guido_Bartell@yahoo.com", "Zita", "Douglas", "400-871-4662", "89858-0981" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 16,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "77524 Goyette Village, Corkeryport, Zimbabwe", "Irma86@hotmail.com", "Gwen", "Hirthe", "222-845-8753", "96989" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 17,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "275 Elias Trafficway, Weissnatberg, Burundi", "Carmela_Buckridge13@yahoo.com", "Benedict", "Murazik", "967-793-5967", "33559-4711" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 18,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "8330 Rowe Trafficway, Ritchieborough, Falkland Islands (Malvinas)", "Axel.OConner@yahoo.com", "Alvis", "Heathcote", "752-845-4566", "19670-6638" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 19,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "767 Rippin Forest, New Stephanie, Malta", "Ericka28@hotmail.com", "Garland", "Lakin", "725-867-6149", "12332" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 20,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "403 Adeline Ways, Satterfieldborough, Brazil", "Shanny_Bogan63@yahoo.com", "Brielle", "Champlin", "407-504-2171", "90370" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 21,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "42759 Odessa Branch, Clementinestad, Netherlands", "Timmothy.Weimann98@hotmail.com", "Alec", "Moore", "228-698-9613", "83292" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 22,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "183 Feest Shoal, South Irving, Bulgaria", "Shakira_Grimes@hotmail.com", "Lukas", "Ebert", "408-960-3053", "67223-2854" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 23,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "26520 Bahringer Branch, Port Velva, Cayman Islands", "Julius.Shanahan@hotmail.com", "Bruce", "Lubowitz", "342-765-3492", "01532-2687" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 24,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "539 Dickens Alley, Collinsshire, Marshall Islands", "Lavina97@gmail.com", "Willow", "Batz", "943-822-4844", "55358" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 25,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "1952 Craig Ridges, North Grant, Switzerland", "Omari33@gmail.com", "Felton", "Huels", "545-395-6559", "47424" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 26,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "92603 Ila Shoal, South Everetteburgh, Republic of Korea", "Elenor_OConner@yahoo.com", "Laura", "Zemlak", "240-918-3912", "11955" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 27,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "848 Ericka Center, East Dan, Tanzania", "Carlee89@yahoo.com", "Emmy", "Kemmer", "246-609-0821", "48615" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 28,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "3221 Wiegand Ville, North Jalen, Moldova", "Bernie38@yahoo.com", "Marlee", "Cartwright", "592-231-6486", "48185-6320" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 29,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "851 Hartmann Lodge, Nitzschemouth, Uzbekistan", "Gregg_Roberts80@hotmail.com", "Elissa", "Bailey", "904-989-7243", "62256-5831" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 30,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "8688 Thora Stream, New Delfinaville, Somalia", "Pattie46@yahoo.com", "Herminia", "Bednar", "555-429-5456", "41060" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 1,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "62738 Spencer Light, Tyriquemouth, Greece", "Jack", "Becker", "32206" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 2,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "04368 Bahringer Plaza, New Virgil, Chad", "Autumn", "Emard", "19162-2900" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 3,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "2928 Brionna Mews, South Constantin, Panama", "Davin", "Harber", "76121", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 4,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "989 Dooley Lock, Hendersonport, Tajikistan", "Rhianna", "Balistreri", "09027-0178" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 5,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "59367 Tillman Lake, West Marlenside, Marshall Islands", "Braeden", "Parisian", "52496-6538", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 6,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "27353 Reinger Spur, Spinkastad, Zambia", "Obie", "Berge", "50184", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 7,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "087 Stamm Parkway, East Orville, Greece", "Roma", "Mann", "33528", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 8,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "5832 Mayer Spring, Ricardoberg, Italy", "Osvaldo", "Ernser", "39783-0777", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 9,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "170 Krystal Fort, Justynside, Colombia", "Edison", "Osinski", "55868-0380" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 10,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "56771 Brown Camp, Port Mayraberg, Nicaragua", "Miracle", "Weber", "92338-7416" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 11,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "88079 Hyatt Forge, Aleenburgh, Lao People's Democratic Republic", "Forest", "McClure", "74988-6989", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 12,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "204 Donato Mountain, New Macyberg, Micronesia", "Karen", "Ward", "29795" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 13,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "256 Quigley Stravenue, New Rosario, Nauru", "Lenora", "Orn", "45639-7490", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 14,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "99349 Breanna Falls, Port Germainehaven, Jordan", "Reta", "Purdy", "53623-9344" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 15,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "220 Loyce Dam, South Chris, Saint Helena", "Vada", "Effertz", "81179-8448" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 16,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "27506 Horace Freeway, Leuschkeport, Portugal", "Edythe", "Schmidt", "56141-5374", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 17,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "961 Dedric Island, New Cristopher, Mauritania", "Leone", "Kautzer", "40189" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 18,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "8729 Tiana Branch, Dorthychester, Gibraltar", "Susan", "McLaughlin", "24186" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 19,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "83259 Anna River, East Erichview, Falkland Islands (Malvinas)", "Landen", "Thompson", "35454", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 20,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "64879 Jenkins Courts, Port Sydnichester, British Indian Ocean Territory (Chagos Archipelago)", "Ezra", "Christiansen", "84998-7991" });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "medicationId", "description", "name", "price", "quantity" },
                values: new object[,]
                {
                    { 1, "A aut quod. Dolorum numquam rerum tempora aut error natus veritatis consequuntur. Blanditiis soluta natus sint voluptatum deserunt quia sunt possimus. Quidem tenetur consequatur molestiae doloribus magni nesciunt eos.", "Tasty Cotton Towels", 46.930642286283271m, 63 },
                    { 2, "Beatae impedit in tenetur officia in et labore. Est consequatur molestiae molestiae quasi aut soluta et eius. Consectetur nam quia porro ut placeat voluptate nihil iusto distinctio.", "Awesome Metal Bike", 77.866729690165624m, 28 },
                    { 3, "Maxime dolores ipsum nisi quia porro incidunt ut voluptatibus nihil. Et illum repellendus quisquam. Modi repudiandae eaque officiis asperiores laboriosam. Dolor reiciendis asperiores in.", "Practical Granite Bacon", 91.340365564143442m, 50 },
                    { 4, "Recusandae minus quae et voluptatibus hic reiciendis deleniti aliquam ipsa. Ex dolorum debitis natus. Labore ut est cupiditate saepe. Non doloribus consequatur numquam qui minus. Odio id fugit reprehenderit eveniet.", "Awesome Frozen Computer", 98.759617595355826m, 86 },
                    { 5, "Excepturi dicta neque alias dolorum autem optio itaque animi nemo. Nisi voluptatem doloremque non aut inventore. Assumenda aut et nesciunt vel.", "Practical Rubber Sausages", 7.1203327281960886m, 31 },
                    { 6, "Libero est nobis harum vel voluptatem voluptas doloribus maxime voluptas. Quibusdam est dolores nemo est et. Quia sit ea veniam neque veniam est ex ad. Itaque distinctio et libero consequatur cumque quidem qui expedita. Est non eaque et perspiciatis non ea.", "Tasty Metal Chair", 43.74457720515532m, 45 },
                    { 7, "Nihil iure ut eum dignissimos in voluptatibus accusantium quae. Ab dicta consectetur omnis et accusantium dolores corrupti fugit qui. Aut qui nostrum quod. Molestiae sed et deserunt. Et earum autem sapiente reiciendis nesciunt aliquam autem quaerat.", "Handcrafted Steel Ball", 62.644241280688066m, 54 },
                    { 8, "Culpa sit voluptate amet excepturi ipsum doloribus quidem. Et dolore rerum non voluptatum dolor aut. Illo in qui qui illum qui. Et fugit vero consectetur mollitia rerum perferendis minima veniam.", "Rustic Wooden Chair", 35.169576727398508m, 50 },
                    { 9, "Hic nesciunt consequatur minus voluptates laborum. Dolor facere occaecati quo. Laborum ipsam nisi. Similique ut rerum in ipsam quibusdam ipsa est incidunt.", "Intelligent Granite Shirt", 36.471501873094375m, 98 },
                    { 10, "Quo et consectetur. Ducimus porro tenetur et. Architecto odio architecto incidunt itaque nam ut voluptatem culpa et. Blanditiis itaque neque sequi sed quisquam quas earum magnam ducimus. Sequi recusandae nam ea est quia aut ipsam.", "Handmade Wooden Soap", 59.106581072838298m, 85 },
                    { 11, "Esse nostrum corporis iure error unde voluptatibus laborum deserunt est. Eaque sed qui numquam perferendis autem quas nihil veniam. Similique in aut pariatur. Ut assumenda iure.", "Incredible Cotton Bike", 49.378909216438801m, 15 },
                    { 12, "Quidem et aut aut. Quia quasi qui non. Doloribus officia quidem. Itaque hic illum beatae qui nulla quo.", "Unbranded Soft Keyboard", 54.429774210988417m, 33 },
                    { 13, "Quis quo et delectus nihil alias. Excepturi dolorum voluptatem aut qui et. Quae voluptas illo cum magni vel sed ut odit porro.", "Sleek Plastic Bike", 46.317922033517551m, 34 },
                    { 14, "A aspernatur dolorum ullam explicabo quo voluptatem neque harum. Molestiae voluptas et delectus. Ut quisquam veniam. Rem id vitae voluptate dolore maxime qui non quidem.", "Sleek Plastic Gloves", 50.50643172976864m, 97 },
                    { 15, "Quisquam aut eligendi hic. Doloremque sint et dolorum omnis non est facere voluptas aut. Voluptatem omnis necessitatibus eius officiis est quis iste commodi. Iure velit dolores quia labore.", "Ergonomic Concrete Ball", 1.33497959623810858m, 7 },
                    { 16, "Pariatur dignissimos dicta qui temporibus. Sed quia est nemo vero quisquam. Quidem quis minima.", "Licensed Plastic Shoes", 3.9930573143032606m, 28 },
                    { 17, "Voluptatem commodi et sed qui id itaque quae. Facere est cumque dignissimos magni nostrum ut ut. Labore sed beatae. Esse quasi id optio est. Magnam a necessitatibus maxime ut et assumenda.", "Sleek Wooden Soap", 29.454967390492126m, 23 },
                    { 18, "Non ut ea recusandae molestiae. Maiores consequuntur est sed. Architecto natus reiciendis hic molestiae. Ducimus debitis ea autem nobis eos rerum totam facilis ea. Et delectus et. Cumque illum magni dignissimos impedit libero assumenda in.", "Unbranded Cotton Hat", 13.368142653428089m, 55 },
                    { 19, "Autem enim vero repellat. Facilis iusto rem non aut esse laudantium veniam temporibus sint. Rerum corrupti fuga autem maxime nulla quas.", "Incredible Soft Shirt", 27.395775912513898m, 72 },
                    { 20, "Dicta perspiciatis enim ea similique. Possimus ut nobis beatae ut ut id suscipit exercitationem. Atque temporibus et laborum. Quis est repellendus dolores rerum voluptas eos minus. Nisi culpa et adipisci voluptatem.", "Handcrafted Plastic Pizza", 16.311046623769666m, 87 },
                    { 21, "Et unde odit in et dolorem nihil veritatis. Molestias tempora illo dolorum. Est non et dolorum doloremque et labore nihil minus. Perspiciatis velit enim nihil ab id similique molestias. Eaque atque modi cum aspernatur nihil mollitia porro libero. Fugiat ex placeat.", "Refined Concrete Computer", 23.052096284018878m, 58 },
                    { 22, "Eos iusto vel. Esse at fugiat vero repellat perferendis officia itaque porro. Qui voluptatem unde pariatur. Sint et ut similique aliquid ut suscipit autem quo. Voluptas quam harum.", "Ergonomic Rubber Chips", 42.26758866909316m, 97 },
                    { 23, "Et accusamus quod porro et. Saepe quidem omnis doloribus et unde. Dolorem nobis distinctio ut et accusantium repudiandae vitae inventore. Voluptas tempore deserunt tenetur ut ullam voluptatum reiciendis numquam eos.", "Handmade Rubber Computer", 56.686574927850922m, 59 },
                    { 24, "Consequatur cumque et pariatur sit dolor rerum laudantium quis. Corrupti quod beatae dolores dolor amet officiis reiciendis quae. Non molestiae suscipit. Perferendis eligendi voluptate. Id quidem ut quae. Sequi voluptates eum illum qui culpa necessitatibus tenetur quos nobis.", "Small Metal Mouse", 98.735789231832961m, 55 },
                    { 25, "Ipsum quo qui at nisi beatae. Dolorem quo quos quis ducimus. Est temporibus odio temporibus et officia autem consequatur qui. Sequi odit aperiam labore autem sunt.", "Gorgeous Wooden Tuna", 55.874044784286046m, 78 },
                    { 26, "Et explicabo consequatur eum sit. Nemo sunt occaecati molestias et aperiam facere unde. Numquam illo laborum aut odio voluptatem. Placeat nemo quo sunt architecto veritatis itaque id distinctio harum.", "Licensed Soft Bike", 53.866435488158116m, 19 },
                    { 27, "Porro nihil nemo harum animi voluptate quia eaque perspiciatis. Laboriosam quo ipsum eius voluptatem. Repudiandae ut et doloribus ducimus in et voluptatem sint nulla. Pariatur eius aut placeat aut ullam quo nostrum sit perferendis. Ratione ut harum provident provident. Animi saepe quos esse neque animi dolorum ut.", "Awesome Metal Computer", 76.890912566748895m, 62 },
                    { 28, "Possimus velit ex illum provident qui ut esse. Molestiae consequatur et natus sed. Ex repudiandae ipsa sint unde accusantium aliquid.", "Incredible Wooden Mouse", 68.936902903922338m, 58 },
                    { 29, "Excepturi ratione quo vero rerum reprehenderit quos. Quo alias ratione commodi voluptatum. Corrupti nesciunt cum veritatis. Perferendis velit velit aut.", "Generic Cotton Shirt", 61.058547657941734m, 67 },
                    { 30, "Qui dolor maxime aut. Dolor ipsum veritatis et vel odit beatae sed ipsa. Amet unde consectetur sunt non. Voluptas quaerat deleniti quia aspernatur quae ipsum magnam rerum maiores. Est sint vero delectus et mollitia laboriosam impedit.", "Handcrafted Cotton Bacon", 61.818217714698202m, 99 }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Beagle", 11, new DateTime(2017, 5, 30, 21, 3, 55, 536, DateTimeKind.Unspecified).AddTicks(1547), "Weldon", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 29, new DateTime(2022, 11, 7, 15, 18, 8, 796, DateTimeKind.Unspecified).AddTicks(8961), "Glen", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3,
                columns: new[] { "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { 20, new DateTime(2017, 6, 2, 5, 13, 14, 348, DateTimeKind.Unspecified).AddTicks(9624), "Hyman", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Sphynx", 30, new DateTime(2016, 4, 17, 10, 34, 46, 988, DateTimeKind.Unspecified).AddTicks(406), "Sasha", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Syrian", 13, new DateTime(2017, 6, 16, 5, 24, 52, 909, DateTimeKind.Unspecified).AddTicks(8890), "Hermina", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Chinese", 13, new DateTime(2016, 10, 10, 22, 16, 15, 812, DateTimeKind.Unspecified).AddTicks(5947), "Kenyon", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Cockatiel", 8, new DateTime(2021, 4, 3, 12, 10, 52, 454, DateTimeKind.Unspecified).AddTicks(956), "Chauncey", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 1, new DateTime(2016, 6, 26, 2, 57, 37, 930, DateTimeKind.Unspecified).AddTicks(5281), "June", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Bengal", 8, new DateTime(2022, 3, 29, 6, 52, 17, 790, DateTimeKind.Unspecified).AddTicks(8375), "Gustave" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 20, new DateTime(2021, 11, 1, 19, 5, 56, 306, DateTimeKind.Unspecified).AddTicks(9574), "Xzavier", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Syrian", 6, new DateTime(2021, 10, 28, 3, 44, 18, 803, DateTimeKind.Unspecified).AddTicks(7702), "Jeffry", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Dutch", 8, new DateTime(2021, 8, 17, 17, 44, 27, 192, DateTimeKind.Unspecified).AddTicks(1342), "Estell", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Dwarf", 9, new DateTime(2016, 12, 12, 4, 29, 30, 433, DateTimeKind.Unspecified).AddTicks(5214), "Markus" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bengal", 15, new DateTime(2019, 11, 17, 18, 18, 7, 980, DateTimeKind.Unspecified).AddTicks(5708), "Charlie", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Dwarf", 10, new DateTime(2016, 5, 22, 12, 37, 48, 136, DateTimeKind.Unspecified).AddTicks(4614), "Brennon", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 5, new DateTime(2020, 1, 4, 9, 20, 30, 973, DateTimeKind.Unspecified).AddTicks(7854), "Dexter", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Chinese", 17, new DateTime(2023, 5, 2, 17, 15, 11, 558, DateTimeKind.Unspecified).AddTicks(8880), "Freddie", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "German Shepherd", 26, new DateTime(2022, 12, 6, 23, 10, 4, 123, DateTimeKind.Unspecified).AddTicks(8726), "Webster", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Beagle", 8, new DateTime(2019, 1, 13, 19, 2, 45, 609, DateTimeKind.Unspecified).AddTicks(176), "Elmer", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20,
                columns: new[] { "breed", "dateOfBirth", "name" },
                values: new object[] { "Angora", new DateTime(2014, 12, 17, 13, 41, 5, 73, DateTimeKind.Unspecified).AddTicks(9854), "Michael" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Siamese", 26, new DateTime(2016, 10, 9, 6, 48, 31, 946, DateTimeKind.Unspecified).AddTicks(4378), "Laila" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Dutch", 26, new DateTime(2014, 12, 8, 6, 30, 21, 791, DateTimeKind.Unspecified).AddTicks(548), "Naomie" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 19, new DateTime(2022, 12, 26, 8, 48, 33, 136, DateTimeKind.Unspecified).AddTicks(1483), "Una", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Finch", 13, new DateTime(2022, 6, 1, 19, 46, 9, 221, DateTimeKind.Unspecified).AddTicks(9738), "London", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Sphynx", 1, new DateTime(2018, 6, 7, 19, 5, 45, 417, DateTimeKind.Unspecified).AddTicks(6582), "Aron", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Cockatiel", 16, new DateTime(2018, 11, 21, 4, 16, 28, 521, DateTimeKind.Unspecified).AddTicks(8900), "Mabel", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Dutch", 7, new DateTime(2021, 4, 23, 11, 5, 46, 793, DateTimeKind.Unspecified).AddTicks(3632), "Gage", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bengal", 17, new DateTime(2021, 11, 16, 13, 24, 8, 334, DateTimeKind.Unspecified).AddTicks(4586), "Madilyn", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Maine Coon", 27, new DateTime(2021, 7, 10, 10, 12, 39, 95, DateTimeKind.Unspecified).AddTicks(5846), "Armando", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Poodle", 13, new DateTime(2015, 1, 15, 7, 3, 46, 656, DateTimeKind.Unspecified).AddTicks(2222), "Curtis", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Labrador", 2, new DateTime(2019, 4, 7, 10, 43, 42, 751, DateTimeKind.Unspecified).AddTicks(170), "Keven", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bulldog", 5, new DateTime(2016, 11, 9, 15, 19, 56, 108, DateTimeKind.Unspecified).AddTicks(6053), "Alvina", "Bird" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "medicationId",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 1,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 6, 29, 23, 33, 16, 788, DateTimeKind.Unspecified).AddTicks(957), 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 2,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 5, 13, 3, 6, 50, 526, DateTimeKind.Unspecified).AddTicks(6862), 4, 13, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 3,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 9, 2, 15, 3, 54, 594, DateTimeKind.Unspecified).AddTicks(6892), 1, 14, 5 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 4,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2023, 11, 25, 11, 42, 48, 200, DateTimeKind.Unspecified).AddTicks(2651), 4, 8, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 5,
                columns: new[] { "date", "doctorId", "patientId", "appointmentType" },
                values: new object[] { new DateTime(2024, 4, 7, 1, 13, 34, 209, DateTimeKind.Unspecified).AddTicks(4126), 10, 15, 6 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "appointmentId",
                keyValue: 6,
                columns: new[] { "date", "doctorId", "patientId" },
                values: new object[] { new DateTime(2024, 3, 2, 4, 57, 29, 255, DateTimeKind.Unspecified).AddTicks(1946), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 1,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "609 Lynch Roads, Stokeston, Luxembourg", "Yesenia.Parker@gmail.com", "Delores", "Brown", "564-839-1602", "77901-3717" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 2,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "21149 Terry Squares, Lake Una, Brazil", "Fabiola.Pouros@gmail.com", "Judy", "Goodwin", "934-766-4235", "09460-1203" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 3,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "2471 Annetta Drive, Lake Zellaborough, Western Sahara", "Aleen87@gmail.com", "Jerad", "Hammes", "233-530-6887", "31134" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 4,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "522 Ferry Burg, Lazaroville, Monaco", "Arnoldo_Walsh@gmail.com", "Macey", "Steuber", "756-910-0102", "18690-3271" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 5,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "644 Gutmann Trafficway, Ewaldbury, Tanzania", "Seamus73@hotmail.com", "Marjolaine", "Haley", "419-680-3873", "37750-3380" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 6,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "4993 Orn Lock, Bednarbury, Botswana", "Dakota.Kiehn23@hotmail.com", "Ephraim", "Hansen", "729-833-1094", "12910" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 7,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "06446 Stephan Divide, Lake Angelicaport, Belize", "Diego.Gulgowski@yahoo.com", "Marley", "Schuster", "458-260-3462", "31537-1697" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 8,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "642 Rhiannon Harbor, Waylonville, Botswana", "Florence40@yahoo.com", "Betty", "Batz", "381-566-1362", "14025-4197" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 9,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "013 Fredy Pass, East Jaedenstad, Vanuatu", "Silas85@gmail.com", "Kasandra", "Langworth", "554-971-1346", "62837" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 10,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "204 Jamison Rue, Jabarifurt, Turkmenistan", "Hannah28@yahoo.com", "Leola", "Glover", "237-265-2464", "21749-0121" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 11,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "59776 Tremblay Dale, Connellybury, Mali", "Danika14@gmail.com", "Audreanne", "Rolfson", "358-799-6719", "98166" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 12,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "0638 Erika Club, Minnieside, Cameroon", "Estell_Haley@hotmail.com", "Opal", "Konopelski", "325-317-2157", "40565-9746" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 13,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "958 Misael Ferry, Lake Dulcefurt, Saint Helena", "Ella92@hotmail.com", "Jairo", "Spinka", "833-866-4282", "37814" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 14,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "4734 Louisa Village, Constantinberg, Denmark", "Demetrius.Thompson@hotmail.com", "Shaniya", "Price", "680-551-5037", "32480" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 15,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "9150 Schinner River, Nikolasbury, Cameroon", "Grayson_Rempel34@yahoo.com", "Marilie", "Weissnat", "962-837-0947", "06683" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 16,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "69635 Rosie Way, New Camila, Luxembourg", "Jared.Hansen54@hotmail.com", "Kenya", "Pfeffer", "329-569-9300", "15395" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 17,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "610 Felipe Islands, Nedchester, Burundi", "Bennett56@hotmail.com", "Guido", "Price", "252-567-0476", "75928" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 18,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "9324 Samara Cliffs, North Miles, Bulgaria", "Ursula.Bergstrom94@hotmail.com", "Fredy", "Bahringer", "368-870-6039", "51825-2930" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 19,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "4875 Von Streets, Wittingview, Trinidad and Tobago", "Yoshiko_Kris50@gmail.com", "Deondre", "D'Amore", "834-646-1971", "56029-5896" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 20,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "2652 Botsford Spring, Cortezburgh, Slovenia", "Immanuel_Dach6@gmail.com", "Jaycee", "Schoen", "569-598-4892", "57752" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 21,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "405 Earline Crescent, Port Berneiceville, Dominican Republic", "Mollie_Stracke@hotmail.com", "Kyla", "Shields", "873-977-6607", "62153" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 22,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "17865 Glover Pine, Rodrigoberg, Belize", "Amina_Hyatt@hotmail.com", "Louvenia", "Okuneva", "285-516-6394", "60450" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 23,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "14250 Doyle Field, Robbiehaven, Malaysia", "Michael.Swaniawski@hotmail.com", "Dasia", "Kling", "666-551-7336", "06341-3558" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 24,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "10718 Kelsi Valley, New Guiseppe, Seychelles", "Odessa27@yahoo.com", "Larry", "Gerlach", "491-909-2387", "17988-1145" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 25,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "794 Ryan Divide, Cummeratamouth, Pitcairn Islands", "Kaylee.Ryan@gmail.com", "Kiana", "Berge", "745-464-3787", "55668-7955" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 26,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "010 Parker Alley, South Adriana, Nicaragua", "Benedict91@hotmail.com", "Shaina", "Swaniawski", "957-210-5976", "83906" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 27,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "3942 Cletus Avenue, Jamarcuston, Luxembourg", "Soledad_Smith@gmail.com", "Michale", "O'Conner", "707-440-0961", "38822" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 28,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "5445 Litzy Divide, Handberg, Micronesia", "Magali3@gmail.com", "Destini", "Windler", "840-657-2761", "84455" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 29,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "49528 Emiliano View, Lake Wilbertchester, Puerto Rico", "Helen_Erdman@yahoo.com", "Haylie", "Ryan", "464-888-4077", "06380-9432" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "clientId",
                keyValue: 30,
                columns: new[] { "address", "email", "firstName", "lastName", "phoneNumber", "postalCode" },
                values: new object[] { "66819 Sipes Ville, Demetriusstad, Fiji", "Keyshawn.Ratke@gmail.com", "Lauriane", "Kozey", "771-920-9125", "20537" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 1,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "6571 Feil Rue, Lake Humbertoborough, Maldives", "Aryanna", "Brekke", "53669-5034" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 2,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "3116 Robel Ridge, Johnathonhaven, Montenegro", "Trudie", "Orn", "57541" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 3,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "25568 Schaefer Prairie, South Elissa, Puerto Rico", "Jamie", "Bins", "80482", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 4,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "28503 Douglas Way, West Noelside, Tunisia", "Sophia", "Schoen", "90278" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 5,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "48043 Ardith Prairie, South Myrticetown, Madagascar", "Timothy", "Pacocha", "06517", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 6,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "711 Garland Court, East Jabarichester, Serbia", "Ocie", "Harber", "12409", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 7,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "3241 Agustina Locks, Kertzmannview, Virgin Islands, U.S.", "Rosalee", "Maggio", "98473-9818", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 8,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "615 Haley Park, Considineberg, Falkland Islands (Malvinas)", "Celestine", "Barrows", "55849", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 9,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "27842 Wanda Extension, West Domenic, Sweden", "Reed", "Wolf", "71535" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 10,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "1356 Kohler Green, Evansborough, Guinea-Bissau", "Hector", "Conroy", "52612-2613" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 11,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "209 Smitham Tunnel, Jessystad, South Africa", "Madalyn", "Howe", "89296-6639", 0 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 12,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "793 Kertzmann Harbors, Lake Clemens, Bhutan", "Celia", "Terry", "79832" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 13,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "789 Marietta Turnpike, Coltshire, American Samoa", "Bryon", "Kemmer", "86034-7170", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 14,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "27070 Jasmin Tunnel, Wolffbury, Kuwait", "Keyshawn", "Larson", "52747" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 15,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "33179 Leffler Junctions, North Imaton, Tonga", "Kaylie", "Quitzon", "93169-4740" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 16,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "096 Lamont Way, East Christa, Suriname", "Burdette", "Considine", "90558", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 17,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "906 Nikolas Lane, Lake Lillianaborough, Portugal", "Justina", "Kiehn", "12265-5532" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 18,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "27322 Gulgowski Divide, Tiffanytown, French Polynesia", "Lyla", "Waters", "51801-6748" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 19,
                columns: new[] { "address", "firstName", "lastName", "postalCode", "specialization" },
                values: new object[] { "35177 Davis Place, Ortizbury, New Zealand", "Cheyenne", "O'Kon", "82316-7993", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "doctorId",
                keyValue: 20,
                columns: new[] { "address", "firstName", "lastName", "postalCode" },
                values: new object[] { "662 Connelly Mill, East Rudolph, Eritrea", "Valentine", "Hermiston", "55878" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 1,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Angora", 10, new DateTime(2018, 3, 26, 14, 43, 47, 835, DateTimeKind.Unspecified).AddTicks(7544), "Arlene", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 2,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Poodle", 21, new DateTime(2015, 2, 15, 2, 19, 33, 831, DateTimeKind.Unspecified).AddTicks(8318), "Maya", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 3,
                columns: new[] { "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { 15, new DateTime(2017, 5, 6, 8, 55, 56, 123, DateTimeKind.Unspecified).AddTicks(4058), "Jeremy", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 4,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Angora", 22, new DateTime(2021, 9, 16, 20, 8, 15, 550, DateTimeKind.Unspecified).AddTicks(3265), "Burley", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 5,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Lionhead", 9, new DateTime(2020, 10, 26, 2, 39, 43, 305, DateTimeKind.Unspecified).AddTicks(2158), "Casey", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 6,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Maine Coon", 19, new DateTime(2022, 8, 17, 2, 58, 0, 107, DateTimeKind.Unspecified).AddTicks(4748), "Ernest", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 7,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Maine Coon", 26, new DateTime(2023, 1, 30, 1, 4, 13, 814, DateTimeKind.Unspecified).AddTicks(4234), "Brain", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 8,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Poodle", 9, new DateTime(2021, 2, 23, 16, 16, 38, 721, DateTimeKind.Unspecified).AddTicks(2111), "Jeramy", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 9,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Beagle", 25, new DateTime(2015, 5, 12, 5, 18, 37, 904, DateTimeKind.Unspecified).AddTicks(4798), "Harmony" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 10,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Poodle", 11, new DateTime(2020, 3, 16, 21, 34, 34, 356, DateTimeKind.Unspecified).AddTicks(7188), "Wilson", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 11,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Finch", 12, new DateTime(2015, 1, 11, 2, 12, 0, 58, DateTimeKind.Unspecified).AddTicks(5938), "Alfred", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 12,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Finch", 28, new DateTime(2020, 11, 26, 9, 54, 52, 757, DateTimeKind.Unspecified).AddTicks(9361), "Opal", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 13,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Syrian", 4, new DateTime(2021, 3, 26, 18, 20, 4, 833, DateTimeKind.Unspecified).AddTicks(9704), "Kirstin" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 14,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Parrot", 25, new DateTime(2015, 12, 20, 19, 15, 12, 655, DateTimeKind.Unspecified).AddTicks(1370), "Hassan", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 15,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bulldog", 3, new DateTime(2014, 7, 20, 12, 30, 10, 149, DateTimeKind.Unspecified).AddTicks(9692), "Schuyler", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 16,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Persian", 26, new DateTime(2018, 12, 23, 10, 57, 9, 991, DateTimeKind.Unspecified).AddTicks(9819), "Elyssa", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 17,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Maine Coon", 11, new DateTime(2016, 4, 6, 11, 19, 25, 288, DateTimeKind.Unspecified).AddTicks(7430), "Vincent", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 18,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Maine Coon", 30, new DateTime(2016, 12, 18, 19, 23, 52, 156, DateTimeKind.Unspecified).AddTicks(3226), "Deangelo", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 19,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Sphynx", 15, new DateTime(2020, 4, 27, 7, 19, 48, 682, DateTimeKind.Unspecified).AddTicks(8292), "Clifton", "Dog" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 20,
                columns: new[] { "breed", "dateOfBirth", "name" },
                values: new object[] { "Cockatiel", new DateTime(2016, 9, 2, 6, 47, 40, 23, DateTimeKind.Unspecified).AddTicks(6053), "Camila" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 21,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Dutch", 24, new DateTime(2018, 7, 10, 1, 31, 13, 562, DateTimeKind.Unspecified).AddTicks(1060), "Clementine" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 22,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name" },
                values: new object[] { "Lionhead", 19, new DateTime(2015, 11, 14, 21, 35, 14, 67, DateTimeKind.Unspecified).AddTicks(1451), "Bella" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 23,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bulldog", 20, new DateTime(2019, 6, 22, 6, 50, 22, 804, DateTimeKind.Unspecified).AddTicks(5772), "Edison", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 24,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Dwarf", 3, new DateTime(2014, 9, 21, 1, 37, 5, 159, DateTimeKind.Unspecified).AddTicks(3140), "Reagan", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 25,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bulldog", 21, new DateTime(2015, 10, 8, 5, 31, 35, 619, DateTimeKind.Unspecified).AddTicks(7146), "Mohammad", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 26,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Winter White", 9, new DateTime(2019, 6, 5, 1, 49, 35, 233, DateTimeKind.Unspecified).AddTicks(4596), "Joshuah", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 27,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "German Shepherd", 27, new DateTime(2020, 2, 26, 23, 47, 58, 893, DateTimeKind.Unspecified).AddTicks(278), "Laurel", "Cat" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 28,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Poodle", 9, new DateTime(2013, 12, 10, 13, 39, 27, 91, DateTimeKind.Unspecified).AddTicks(126), "Hilbert", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 29,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Bulldog", 10, new DateTime(2022, 12, 25, 11, 38, 28, 629, DateTimeKind.Unspecified).AddTicks(7156), "Iliana", "Bird" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 30,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Beagle", 1, new DateTime(2016, 11, 3, 11, 28, 2, 123, DateTimeKind.Unspecified).AddTicks(8799), "Nikko", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 31,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Dutch", 22, new DateTime(2017, 5, 6, 0, 59, 4, 316, DateTimeKind.Unspecified).AddTicks(8865), "Darryl", "Hamster" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "patientId",
                keyValue: 32,
                columns: new[] { "breed", "clientId", "dateOfBirth", "name", "species" },
                values: new object[] { "Winter White", 17, new DateTime(2015, 6, 29, 3, 20, 6, 445, DateTimeKind.Unspecified).AddTicks(3226), "Gerard", "Hamster" });
        }
    }
}
