using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiSluzbaBackend.Migrations
{
    /// <inheritdoc />
    public partial class AdminSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "PasswordHash" },
                values: new object[] { 1, "admin@pijacar.hr", "Cz+JROeSaMyFKl/2+JiteHMu2fqwegiCVaCZl4cAESw=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
