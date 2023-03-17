using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
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
                    DeptNames = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Exams",
                columns: table => new
                {
                    Ex_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ex_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ex_Marks = table.Column<int>(type: "int", nullable: false),
                    CrsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Ex_Id);
                    table.ForeignKey(
                        name: "FK_Exams_courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Q_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsID = table.Column<int>(type: "int", nullable: false),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    Q_Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Q_Id);
                    table.ForeignKey(
                        name: "FK_Questions_courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_topics_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_students_departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ins_Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ins_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ins_Courses_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ins_Courses_instructors_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ins_Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instructorId = table.Column<int>(type: "int", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ins_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ins_Departments_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ins_Departments_instructors_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    Ch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ch_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.Ch_Id);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_Q_ID",
                        column: x => x.Q_ID,
                        principalTable: "Questions",
                        principalColumn: "Q_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam_Question_Crs",
                columns: table => new
                {
                    Ex_ID = table.Column<int>(type: "int", nullable: false),
                    Ques_ID = table.Column<int>(type: "int", nullable: false),
                    Crs_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Question_Crs", x => new { x.Ex_ID, x.Ques_ID, x.Crs_ID });
                    table.ForeignKey(
                        name: "FK_Exam_Question_Crs_Exams_Ex_ID",
                        column: x => x.Ex_ID,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id");
                    table.ForeignKey(
                        name: "FK_Exam_Question_Crs_Questions_Ques_ID",
                        column: x => x.Ques_ID,
                        principalTable: "Questions",
                        principalColumn: "Q_Id");
                    table.ForeignKey(
                        name: "FK_Exam_Question_Crs_courses_Crs_ID",
                        column: x => x.Crs_ID,
                        principalTable: "courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "stud_Crs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stud_Crs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stud_Crs_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stud_Crs_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_Exams",
                columns: table => new
                {
                    St_ID = table.Column<int>(type: "int", nullable: false),
                    Ex_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Exams", x => new { x.St_ID, x.Ex_ID });
                    table.ForeignKey(
                        name: "FK_Student_Exams_Exams_Ex_ID",
                        column: x => x.Ex_ID,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Exams_students_St_ID",
                        column: x => x.St_ID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dept_Crs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false),
                    Ins_Courseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dept_Crs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dept_Crs_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dept_Crs_ins_Courses_Ins_Courseid",
                        column: x => x.Ins_Courseid,
                        principalTable: "ins_Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "course_1" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Ex_Id", "CrsID", "Ex_Marks", "Ex_Name" },
                values: new object[] { 1, 1, 50, "asd" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Q_Id", "AnsID", "AnsTitle", "CrsID", "Q_Mark", "QuesTitle", "type" },
                values: new object[] { 1, 1, "asdjnasd", 1, 25, "asdasd", "MCQ" });

            migrationBuilder.InsertData(
                table: "Exam_Question_Crs",
                columns: new[] { "Crs_ID", "Ex_ID", "Ques_ID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_Q_ID",
                table: "Choices",
                column: "Q_ID");

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_departmentId",
                table: "dept_Crs",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_Ins_Courseid",
                table: "dept_Crs",
                column: "Ins_Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Question_Crs_Crs_ID",
                table: "Exam_Question_Crs",
                column: "Crs_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Question_Crs_Ques_ID",
                table: "Exam_Question_Crs",
                column: "Ques_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CrsID",
                table: "Exams",
                column: "CrsID");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_courseId",
                table: "ins_Courses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_instructorId",
                table: "ins_Courses",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_departmentId",
                table: "ins_Departments",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_instructorId",
                table: "ins_Departments",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CrsID",
                table: "Questions",
                column: "CrsID");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Crs_courseId",
                table: "stud_Crs",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Crs_studentId",
                table: "stud_Crs",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exams_Ex_ID",
                table: "Student_Exams",
                column: "Ex_ID");

            migrationBuilder.CreateIndex(
                name: "IX_students_DeptId",
                table: "students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_topics_courseId",
                table: "topics",
                column: "courseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "dept_Crs");

            migrationBuilder.DropTable(
                name: "Exam_Question_Crs");

            migrationBuilder.DropTable(
                name: "ins_Departments");

            migrationBuilder.DropTable(
                name: "stud_Crs");

            migrationBuilder.DropTable(
                name: "Student_Exams");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "ins_Courses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
