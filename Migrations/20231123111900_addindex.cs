using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroMetricsApp.Migrations
{
    /// <inheritdoc />
    public partial class addindex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
           name: "IX_Countries_Name",
           table: "Countries",
           column: "Name",
           unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
