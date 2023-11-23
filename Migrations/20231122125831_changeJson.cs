using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroMetricsApp.Migrations
{
    /// <inheritdoc />
    public partial class changeJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
           name: "IX_Countries_Name",
           table: "Countries",
           column: "name");

            migrationBuilder.AlterColumn<string>(
                name: "timezones",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "timezones",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
