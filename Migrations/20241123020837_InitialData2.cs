using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPIen.NET.Migrations
{
    /// <inheritdoc />
    public partial class InitialData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 8, 37, 385, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 8, 37, 386, DateTimeKind.Local).AddTicks(948));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b3"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 6, 45, 588, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("b11dc8d6-437d-41d0-829b-523b5d1e73b4"),
                column: "CreationDate",
                value: new DateTime(2024, 11, 22, 21, 6, 45, 589, DateTimeKind.Local).AddTicks(1687));
        }
    }
}
