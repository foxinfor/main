using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class chan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GroupId",
                table: "AspNetUsers",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Group_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GroupId",
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

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "AspNetUsers");

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
    }
}
