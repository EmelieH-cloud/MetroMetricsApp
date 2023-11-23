using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroMetricsApp.Migrations
{
    /// <inheritdoc />
    public partial class n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "captial",
                table: "Countries",
                newName: "capital");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "capital",
                table: "Countries",
                newName: "captial");
        }
    }
}
