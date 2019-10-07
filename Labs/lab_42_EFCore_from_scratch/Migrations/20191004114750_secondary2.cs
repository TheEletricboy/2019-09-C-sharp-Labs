using Microsoft.EntityFrameworkCore.Migrations;

namespace lab_42_EFCore_from_scratch.Migrations
{
    public partial class secondary2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_toDoItems",
                table: "toDoItems");

            migrationBuilder.RenameTable(
                name: "toDoItems",
                newName: "ToDoItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoItems",
                table: "ToDoItems",
                column: "ToDoItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoItems",
                table: "ToDoItems");

            migrationBuilder.RenameTable(
                name: "ToDoItems",
                newName: "toDoItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_toDoItems",
                table: "toDoItems",
                column: "ToDoItemId");
        }
    }
}
