using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddClassTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeachersTeacherID",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Section = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcademicYear = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassTeacherID = table.Column<int>(type: "int", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_ClassTeacherID",
                        column: x => x.ClassTeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeachersTeacherID",
                table: "Teachers",
                column: "TeachersTeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassID",
                table: "Classes",
                column: "ClassID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassTeacherID",
                table: "Classes",
                column: "ClassTeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Teachers_TeachersTeacherID",
                table: "Teachers",
                column: "TeachersTeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Teachers_TeachersTeacherID",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeachersTeacherID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeachersTeacherID",
                table: "Teachers");
        }
    }
}
