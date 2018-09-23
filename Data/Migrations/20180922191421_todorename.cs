using Microsoft.EntityFrameworkCore.Migrations;

namespace DNC.ManageBoard.Data.Migrations
{
    public partial class todorename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "ToDoItem",
                newName: "Published");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Published",
                table: "ToDoItem",
                newName: "DateTime");
        }
    }
}
