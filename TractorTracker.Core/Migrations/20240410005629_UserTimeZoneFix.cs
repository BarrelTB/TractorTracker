using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TractorTracker.Core.Migrations
{
    /// <inheritdoc />
    public partial class UserTimeZoneFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "TimeZoneInfo",
                table: "User",
                newName: "TimeZoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeZoneId",
                table: "User",
                newName: "TimeZoneInfo");

        }
    }
}
