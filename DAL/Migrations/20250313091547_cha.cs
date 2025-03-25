using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class cha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d9eda55-ffc7-4944-b656-2196fc9f5001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aeccc20-0ab2-4259-b651-88c35a98aa14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c98a4097-fc81-424a-a73e-9b3d458616f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0283210-351e-423c-8552-01c5f151337f");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "976b5c0b-4a88-48f9-a8a8-ae1f8f5995d6", null, "student", "STUDENT" },
                    { "caaf9310-1568-4cc0-a5c7-3930a4856b4a", null, "starosta", "STAROSTA" },
                    { "cc5d2e23-8388-421a-9194-20ee5ef4458d", null, "teacher", "TEACHER" },
                    { "f6c15f15-2c5d-49fe-aa5c-b50a7462656c", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "976b5c0b-4a88-48f9-a8a8-ae1f8f5995d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caaf9310-1568-4cc0-a5c7-3930a4856b4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc5d2e23-8388-421a-9194-20ee5ef4458d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6c15f15-2c5d-49fe-aa5c-b50a7462656c");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d9eda55-ffc7-4944-b656-2196fc9f5001", null, "starosta", "STAROSTA" },
                    { "4aeccc20-0ab2-4259-b651-88c35a98aa14", null, "admin", "ADMIN" },
                    { "c98a4097-fc81-424a-a73e-9b3d458616f9", null, "student", "STUDENT" },
                    { "d0283210-351e-423c-8552-01c5f151337f", null, "teacher", "TEACHER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId");
        }
    }
}
