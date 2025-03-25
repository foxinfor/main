using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class newEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88f2ea4d-b963-47fa-afc1-3b50ff25f3bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97467b48-f2ac-4211-a3c9-bd26d70fc747");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa955a6a-f8e3-4607-8c13-fcfd0fb76f16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad360f5f-d332-4578-8f78-bf32dbd8927f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "88f2ea4d-b963-47fa-afc1-3b50ff25f3bd", null, "student", "STUDENT" },
                    { "97467b48-f2ac-4211-a3c9-bd26d70fc747", null, "teacher", "TEACHER" },
                    { "aa955a6a-f8e3-4607-8c13-fcfd0fb76f16", null, "admin", "ADMIN" },
                    { "ad360f5f-d332-4578-8f78-bf32dbd8927f", null, "Starosta", "STAROSTA" }
                });
        }
    }
}
