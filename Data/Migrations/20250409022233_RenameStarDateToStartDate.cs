using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaltaTest.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameStarDateToStartDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StarDate",
                table: "Premiums",
                newName: "StartDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Premiums",
                newName: "StarDate");
        }
    }
}
