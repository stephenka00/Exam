using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class T2208E1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rank",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rank",
                table: "Employees");
        }
    }
}
