using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dept_Crs_departments_departmentsId",
                table: "dept_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_dept_Crs_ins_Courses_Ins_CourseId",
                table: "dept_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Courses_courses_coursesId",
                table: "ins_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Courses_instructors_InstructorId",
                table: "ins_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_departments_DepartmentsId",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_instructors_instructorId",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Crs_courses_CourseId",
                table: "stud_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Crs_students_StudentID",
                table: "stud_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_topics_courses_coursesId",
                table: "topics");

            migrationBuilder.DropIndex(
                name: "IX_topics_coursesId",
                table: "topics");

            migrationBuilder.DropIndex(
                name: "IX_ins_Departments_DepartmentsId",
                table: "ins_Departments");

            migrationBuilder.DropIndex(
                name: "IX_ins_Courses_coursesId",
                table: "ins_Courses");

            migrationBuilder.DropIndex(
                name: "IX_dept_Crs_departmentsId",
                table: "dept_Crs");

            migrationBuilder.DropColumn(
                name: "coursesId",
                table: "topics");

            migrationBuilder.DropColumn(
                name: "CrsID",
                table: "stud_Crs");

            migrationBuilder.DropColumn(
                name: "StudID",
                table: "stud_Crs");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "ins_Departments");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "ins_Departments");

            migrationBuilder.DropColumn(
                name: "CrsID",
                table: "ins_Courses");

            migrationBuilder.DropColumn(
                name: "coursesId",
                table: "ins_Courses");

            migrationBuilder.DropColumn(
                name: "departmentsId",
                table: "dept_Crs");

            migrationBuilder.RenameColumn(
                name: "CrsID",
                table: "topics",
                newName: "courseId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "stud_Crs",
                newName: "studentId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "stud_Crs",
                newName: "courseId");

            migrationBuilder.RenameIndex(
                name: "IX_stud_Crs_StudentID",
                table: "stud_Crs",
                newName: "IX_stud_Crs_studentId");

            migrationBuilder.RenameIndex(
                name: "IX_stud_Crs_CourseId",
                table: "stud_Crs",
                newName: "IX_stud_Crs_courseId");

            migrationBuilder.RenameColumn(
                name: "InsID",
                table: "ins_Departments",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "ins_Courses",
                newName: "instructorId");

            migrationBuilder.RenameColumn(
                name: "InsID",
                table: "ins_Courses",
                newName: "courseId");

            migrationBuilder.RenameIndex(
                name: "IX_ins_Courses_InstructorId",
                table: "ins_Courses",
                newName: "IX_ins_Courses_instructorId");

            migrationBuilder.RenameColumn(
                name: "Ins_CourseId",
                table: "dept_Crs",
                newName: "Ins_Courseid");

            migrationBuilder.RenameColumn(
                name: "DeptID",
                table: "dept_Crs",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "CrsID",
                table: "dept_Crs",
                newName: "courseId");

            migrationBuilder.RenameIndex(
                name: "IX_dept_Crs_Ins_CourseId",
                table: "dept_Crs",
                newName: "IX_dept_Crs_Ins_Courseid");

            migrationBuilder.AlterColumn<int>(
                name: "studentId",
                table: "stud_Crs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "courseId",
                table: "stud_Crs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "instructorId",
                table: "ins_Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "instructorId",
                table: "ins_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ins_Courseid",
                table: "dept_Crs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                    Q_Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Q_Id);
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
                name: "Exam_Question",
                columns: table => new
                {
                    Ex_ID = table.Column<int>(type: "int", nullable: false),
                    Ques_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Question", x => new { x.Ex_ID, x.Ques_ID });
                    table.ForeignKey(
                        name: "FK_Exam_Question_Exams_Ex_ID",
                        column: x => x.Ex_ID,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Question_Questions_Ques_ID",
                        column: x => x.Ques_ID,
                        principalTable: "Questions",
                        principalColumn: "Q_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_topics_courseId",
                table: "topics",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_departmentId",
                table: "ins_Departments",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_courseId",
                table: "ins_Courses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_departmentId",
                table: "dept_Crs",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Choices_Q_ID",
                table: "Choices",
                column: "Q_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Question_Ques_ID",
                table: "Exam_Question",
                column: "Ques_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CrsID",
                table: "Exams",
                column: "CrsID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Exams_Ex_ID",
                table: "Student_Exams",
                column: "Ex_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_dept_Crs_departments_departmentId",
                table: "dept_Crs",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dept_Crs_ins_Courses_Ins_Courseid",
                table: "dept_Crs",
                column: "Ins_Courseid",
                principalTable: "ins_Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Courses_courses_courseId",
                table: "ins_Courses",
                column: "courseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Courses_instructors_instructorId",
                table: "ins_Courses",
                column: "instructorId",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_departments_departmentId",
                table: "ins_Departments",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_instructors_instructorId",
                table: "ins_Departments",
                column: "instructorId",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Crs_courses_courseId",
                table: "stud_Crs",
                column: "courseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Crs_students_studentId",
                table: "stud_Crs",
                column: "studentId",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_topics_courses_courseId",
                table: "topics",
                column: "courseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dept_Crs_departments_departmentId",
                table: "dept_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_dept_Crs_ins_Courses_Ins_Courseid",
                table: "dept_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Courses_courses_courseId",
                table: "ins_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Courses_instructors_instructorId",
                table: "ins_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_departments_departmentId",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_instructors_instructorId",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Crs_courses_courseId",
                table: "stud_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Crs_students_studentId",
                table: "stud_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_topics_courses_courseId",
                table: "topics");

            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "Exam_Question");

            migrationBuilder.DropTable(
                name: "Student_Exams");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_topics_courseId",
                table: "topics");

            migrationBuilder.DropIndex(
                name: "IX_ins_Departments_departmentId",
                table: "ins_Departments");

            migrationBuilder.DropIndex(
                name: "IX_ins_Courses_courseId",
                table: "ins_Courses");

            migrationBuilder.DropIndex(
                name: "IX_dept_Crs_departmentId",
                table: "dept_Crs");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "topics",
                newName: "CrsID");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "stud_Crs",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "stud_Crs",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_stud_Crs_studentId",
                table: "stud_Crs",
                newName: "IX_stud_Crs_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_stud_Crs_courseId",
                table: "stud_Crs",
                newName: "IX_stud_Crs_CourseId");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "ins_Departments",
                newName: "InsID");

            migrationBuilder.RenameColumn(
                name: "instructorId",
                table: "ins_Courses",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "ins_Courses",
                newName: "InsID");

            migrationBuilder.RenameIndex(
                name: "IX_ins_Courses_instructorId",
                table: "ins_Courses",
                newName: "IX_ins_Courses_InstructorId");

            migrationBuilder.RenameColumn(
                name: "Ins_Courseid",
                table: "dept_Crs",
                newName: "Ins_CourseId");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "dept_Crs",
                newName: "DeptID");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "dept_Crs",
                newName: "CrsID");

            migrationBuilder.RenameIndex(
                name: "IX_dept_Crs_Ins_Courseid",
                table: "dept_Crs",
                newName: "IX_dept_Crs_Ins_CourseId");

            migrationBuilder.AddColumn<int>(
                name: "coursesId",
                table: "topics",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "stud_Crs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "stud_Crs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CrsID",
                table: "stud_Crs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudID",
                table: "stud_Crs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "instructorId",
                table: "ins_Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "ins_Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "ins_Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "ins_Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CrsID",
                table: "ins_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "coursesId",
                table: "ins_Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ins_CourseId",
                table: "dept_Crs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "departmentsId",
                table: "dept_Crs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_topics_coursesId",
                table: "topics",
                column: "coursesId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_DepartmentsId",
                table: "ins_Departments",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Courses_coursesId",
                table: "ins_Courses",
                column: "coursesId");

            migrationBuilder.CreateIndex(
                name: "IX_dept_Crs_departmentsId",
                table: "dept_Crs",
                column: "departmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_dept_Crs_departments_departmentsId",
                table: "dept_Crs",
                column: "departmentsId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dept_Crs_ins_Courses_Ins_CourseId",
                table: "dept_Crs",
                column: "Ins_CourseId",
                principalTable: "ins_Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Courses_courses_coursesId",
                table: "ins_Courses",
                column: "coursesId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Courses_instructors_InstructorId",
                table: "ins_Courses",
                column: "InstructorId",
                principalTable: "instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_departments_DepartmentsId",
                table: "ins_Departments",
                column: "DepartmentsId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_instructors_instructorId",
                table: "ins_Departments",
                column: "instructorId",
                principalTable: "instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Crs_courses_CourseId",
                table: "stud_Crs",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Crs_students_StudentID",
                table: "stud_Crs",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_topics_courses_coursesId",
                table: "topics",
                column: "coursesId",
                principalTable: "courses",
                principalColumn: "Id");
        }
    }
}
