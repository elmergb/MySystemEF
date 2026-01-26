using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Teachers_TeachersTeacherID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeachersTeacherID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeachersTeacherID",
                table: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "ClassTeacherID",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "StudentClasses",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_StudentClasses_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClasses_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SubjectCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSubjects",
                columns: table => new
                {
                    ClassSubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    Schedule = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjects", x => x.ClassSubjectID);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_ClassID_SubjectID",
                table: "ClassSubjects",
                columns: new[] { "ClassID", "SubjectID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_SubjectID",
                table: "ClassSubjects",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_TeacherID",
                table: "ClassSubjects",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_ClassID",
                table: "StudentClasses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_StudentID_ClassID",
                table: "StudentClasses",
                columns: new[] { "StudentID", "ClassID" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherID",
                table: "Classes",
                column: "ClassTeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherID",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "ClassSubjects");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "TeachersTeacherID",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassTeacherID",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeachersTeacherID",
                table: "Teachers",
                column: "TeachersTeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherID",
                table: "Classes",
                column: "ClassTeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Teachers_TeachersTeacherID",
                table: "Teachers",
                column: "TeachersTeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }
    }
}
