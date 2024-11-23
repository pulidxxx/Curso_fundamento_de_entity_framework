using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPIen.NET.Migrations
{
    /// <inheritdoc />
    public partial class InitialData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 21, 48, 419, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 21, 48, 419, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 16, 29, 88, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 16, 29, 89, DateTimeKind.Local).AddTicks(9040));
        }
    }
}
