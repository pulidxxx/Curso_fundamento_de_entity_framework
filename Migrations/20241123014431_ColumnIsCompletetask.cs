using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPIen.NET.Migrations
{
    /// <inheritdoc />
    public partial class ColumnIsCompletetask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Task",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Task");
        }
    }
}
