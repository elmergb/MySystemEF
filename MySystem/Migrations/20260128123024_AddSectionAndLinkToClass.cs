using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySystem.Migrations
{
    public partial class AddSectionAndLinkToClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1️⃣ CREATE Sections table
          
            // 2️⃣ ADD SectionID to Classes (nullable for now)
       

            // 3️⃣ CREATE INDEX for FK
        

       


            // 6️⃣ MANY-TO-MANY join table (Student ↔ Class)
            migrationBuilder.CreateTable(
                name: "Classstudents",
                columns: table => new
                {
                    ClassesClassID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_Classstudents",
                        x => new { x.ClassesClassID, x.StudentsStudentID });

                    table.ForeignKey(
                        name: "FK_Classstudents_Classes_ClassesClassID",
                        column: x => x.ClassesClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);

                    table.ForeignKey(
                        name: "FK_Classstudents_students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Classstudents_StudentsStudentID",
                table: "Classstudents",
                column: "StudentsStudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Classstudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Sections_SectionID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SectionID",
                table: "Classes");

       

            migrationBuilder.DropTable(name: "Sections");

       
        }
    }
}
