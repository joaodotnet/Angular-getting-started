using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"), "61 Wellfield Road", new DateTime(1980, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Keen" },
                    { new Guid("261e1685-cf26-494c-b17c-3546e65f5620"), "27 Colored Row", new DateTime(1974, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Bosh" },
                    { new Guid("66774006-2371-4d5b-8518-2177bcf3f73e"), "North sunny address 102", new DateTime(1998, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nick Somion" },
                    { new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937"), "91 Western Roads", new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam Query" },
                    { new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"), "3 Edgar Buildings", new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin Miller" }
                });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"), "Domestic", new DateTime(1999, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"), "Savings", new DateTime(1999, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("aa15f658-04bb-4f73-82af-82db49d0fbef"), "Foreign", new DateTime(1999, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"), "Domestic", new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("261e1685-cf26-494c-b17c-3546e65f5620") },
                    { new Guid("c6066eb0-53ca-43e1-97aa-3c2169eec659"), "Foreign", new DateTime(1996, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("261e1685-cf26-494c-b17c-3546e65f5620") },
                    { new Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"), "Domestic", new DateTime(2010, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937") },
                    { new Guid("eccadf79-85fe-402f-893c-32d3f03ed9b1"), "Foreign", new DateTime(2010, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937") },
                    { new Guid("03e91478-5608-4132-a753-d494dafce00b"), "Domestic", new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("03e91478-5608-4132-a753-d494dafce00b"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("aa15f658-04bb-4f73-82af-82db49d0fbef"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("c6066eb0-53ca-43e1-97aa-3c2169eec659"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "AccountId",
                keyValue: new Guid("eccadf79-85fe-402f-893c-32d3f03ed9b1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("66774006-2371-4d5b-8518-2177bcf3f73e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("261e1685-cf26-494c-b17c-3546e65f5620"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"));
        }
    }
}
