using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MinimalAPIen.NET.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Category_CategoriaId",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Task",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_CategoriaId",
                table: "Task",
                newName: "IX_Task_CategoryId");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Description", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("b11dc8d6-437d-41d0-829b-523b5d1e7302"), "Work related tasks", "Categoryt 2", 50 },
                    { new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73bd"), "Work related tasks", "Category 1", 1 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreationDate", "Description", "IsComplete", "TaskPriority", "Title" },
                values: new object[,]
                {
                    { new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"), new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73bd"), new DateTime(2024, 11, 22, 21, 6, 45, 588, DateTimeKind.Local).AddTicks(347), "Create a new project in Visual Studio", false, 2, "Create a new project" },
                    { new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"), new Guid("b11dc8d6-437d-41d0-829b-523b5d1e7302"), new DateTime(2024, 11, 22, 21, 6, 45, 589, DateTimeKind.Local).AddTicks(1687), "Whatch Netflix", false, 0, "Create a new project2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Category_CategoryId",
                table: "Task",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Category_CategoryId",
                table: "Task");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e7302"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73bd"));

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Task",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_CategoryId",
                table: "Task",
                newName: "IX_Task_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Category_CategoriaId",
                table: "Task",
                column: "CategoriaId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
