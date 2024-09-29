using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelierProject.DataAccessLayer.Migrations
{
    public partial class up_work_location2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkLocationName",
                table: "WorkLocations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "WorkLocationCity",
                table: "WorkLocations",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WorkLocations",
                newName: "WorkLocationName");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "WorkLocations",
                newName: "WorkLocationCity");
        }
    }
}
