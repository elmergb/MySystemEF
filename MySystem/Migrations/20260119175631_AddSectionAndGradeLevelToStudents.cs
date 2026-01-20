using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionAndGradeLevelToStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
    name: "Section",
    table: "students",
    type: "longtext",
    nullable: false,
    defaultValue: ""); // default required for existing rows

            migrationBuilder.AddColumn<string>(
                name: "GradeLevel",
                table: "students",
                type: "longtext",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Section", table: "students");
            migrationBuilder.DropColumn(name: "GradeLevel", table: "students");
        }
    }
}
