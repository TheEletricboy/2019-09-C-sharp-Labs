﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab_50_api_todo_list_core.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    TaskItemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: false),
                    TaskDone = table.Column<bool>(nullable: false),
                    DateDue = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.TaskItemID);
                    table.ForeignKey(
                        name: "FK_TaskItems_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskItems_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Category1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Category2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Category3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserName" },
                values: new object[] { 1, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserName" },
                values: new object[] { 2, "User2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserName" },
                values: new object[] { 3, "User3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserName" },
                values: new object[] { 4, "User4" });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "TaskItemID", "CategoryID", "DateDue", "Description", "TaskDone", "UserID" },
                values: new object[] { 1, 2, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study", false, 1 });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "TaskItemID", "CategoryID", "DateDue", "Description", "TaskDone", "UserID" },
                values: new object[] { 2, 3, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work", false, 3 });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "TaskItemID", "CategoryID", "DateDue", "Description", "TaskDone", "UserID" },
                values: new object[] { 3, 1, new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do nothing", false, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_CategoryID",
                table: "TaskItems",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_UserID",
                table: "TaskItems",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
