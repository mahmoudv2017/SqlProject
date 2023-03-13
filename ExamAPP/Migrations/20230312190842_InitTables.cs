using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptNames = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coursesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_topics_courses_coursesId",
                        column: x => x.coursesId,
                        principalTable: "courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_students_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ins_Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    InsID = table.Column<int>(type: "int", nullable: false),
                    coursesId = table.Column<int>(type: "int", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ins_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ins_Courses_courses_coursesId",
                        column: x => x.coursesId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ins_Courses_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ins_Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsID = table.Column<int>(type: "int", nullable: false),
                    DeptID = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: true),
                    DepartmentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ins_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ins_Departments_departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ins_Departments_instructors_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "stud_Crs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    StudID = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stud_Crs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stud_Crs_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stud_Crs_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "dept_Crs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    DeptID = table.Column<int>(type: "int", nullable: false),
                    departmentsId = table.Column<int>(type: "int", nullable: true),
                    Ins_CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dept_Crs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dept_Crs_departments_departmentsId",
                        column: x => x.departmentsId,
                        principalTable: "departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dept_Crs_ins_Courses_Ins_CourseId",
                        column: x => x.Ins_CourseId,
                        principalTable: "ins_Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_departmentsId",
                table: "dept_Crs",
                column: "departmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_Ins_CourseId",
                table: "dept_Crs",
                column: "Ins_CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_coursesId",
                table: "ins_Courses",
                column: "coursesId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_InstructorId",
                table: "ins_Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_DepartmentsId",
                table: "ins_Departments",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_instructorId",
                table: "ins_Departments",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Crs_CourseId",
                table: "stud_Crs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Crs_StudentID",
                table: "stud_Crs",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentId",
                table: "students",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_topics_coursesId",
                table: "topics",
                column: "coursesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dept_Crs");

            migrationBuilder.DropTable(
                name: "ins_Departments");

            migrationBuilder.DropTable(
                name: "stud_Crs");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "ins_Courses");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
