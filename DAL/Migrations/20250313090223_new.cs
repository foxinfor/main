using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0939ce92-94f2-4dc9-8a1c-1129158a6de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a4b663-fe0f-44e2-b75d-658e974f5508");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cdee269-79d1-4c0d-8d50-95b914c3e8c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96f4d3c-c16d-4098-958d-af8cbc100b43");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "085b3485-526c-4a06-8531-4cb70e2bb730", null, "student", "STUDENT" },
                    { "1cab0d20-4e94-4bb7-b588-62cfc0b26c6b", null, "teacher", "TEACHER" },
                    { "52474311-a880-456a-8b9f-5ea4fe6a979c", null, "admin", "ADMIN" },
                    { "b871d2da-7570-49a4-bb7c-3c2f4eac4f5d", null, "starosta", "STAROSTA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085b3485-526c-4a06-8531-4cb70e2bb730");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cab0d20-4e94-4bb7-b588-62cfc0b26c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52474311-a880-456a-8b9f-5ea4fe6a979c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b871d2da-7570-49a4-bb7c-3c2f4eac4f5d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0939ce92-94f2-4dc9-8a1c-1129158a6de7", null, "starosta", "STAROSTA" },
                    { "14a4b663-fe0f-44e2-b75d-658e974f5508", null, "admin", "ADMIN" },
                    { "1cdee269-79d1-4c0d-8d50-95b914c3e8c8", null, "student", "STUDENT" },
                    { "d96f4d3c-c16d-4098-958d-af8cbc100b43", null, "teacher", "TEACHER" }
                });
        }
    }
}
