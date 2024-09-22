using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelierProject.DataAccessLayer.Migrations
{
    public partial class up_message_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MessageCategories",
                newName: "MessageCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageCategoryId",
                table: "MessageCategories",
                newName: "Id");
        }
    }
}
