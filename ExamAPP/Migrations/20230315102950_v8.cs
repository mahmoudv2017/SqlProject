using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "students");

            migrationBuilder.CreateIndex(
                name: "IX_students_DeptId",
                table: "students",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeptId",
                table: "students",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeptId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_DeptId",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentId",
                table: "students",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }
    }
}
