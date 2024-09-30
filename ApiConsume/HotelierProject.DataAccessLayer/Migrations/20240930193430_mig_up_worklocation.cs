using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelierProject.DataAccessLayer.Migrations
{
    public partial class mig_up_worklocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WorkLocations",
                newName: "WorkLocationName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkLocationName",
                table: "WorkLocations",
                newName: "Name");
        }
    }
}
