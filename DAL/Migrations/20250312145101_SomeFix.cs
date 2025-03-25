using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class SomeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "733a6401-5307-4567-94c0-1f4dab8d977e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae2cc92e-9614-443d-ba4f-3c0889a43c49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3be8991-5db1-4de0-8472-83026ca2bc8c");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "733a6401-5307-4567-94c0-1f4dab8d977e", null, "учащийся", "УЧАЩИЙСЯ" },
                    { "ae2cc92e-9614-443d-ba4f-3c0889a43c49", null, "администратор", "АДМИНИСТРАТОР" },
                    { "c3be8991-5db1-4de0-8472-83026ca2bc8c", null, "преподаватель", "ПРЕПОДАВАТЕЛЬ" }
                });
        }
    }
}
