using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_departments_departmentId",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_instructors_instructorId",
                table: "ins_Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ins_Departments",
                table: "ins_Departments");

            migrationBuilder.DropIndex(
                name: "IX_ins_Departments_departmentId",
                table: "ins_Departments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ins_Departments");

            migrationBuilder.RenameColumn(
                name: "instructorId",
                table: "ins_Departments",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "ins_Departments",
                newName: "Ins_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ins_Departments_instructorId",
                table: "ins_Departments",
                newName: "IX_ins_Departments_Dept_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ins_Departments",
                table: "ins_Departments",
                columns: new[] { "Ins_ID", "Dept_ID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_departments_Dept_ID",
                table: "ins_Departments",
                column: "Dept_ID",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ins_Departments_instructors_Ins_ID",
                table: "ins_Departments",
                column: "Ins_ID",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_departments_Dept_ID",
                table: "ins_Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_ins_Departments_instructors_Ins_ID",
                table: "ins_Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ins_Departments",
                table: "ins_Departments");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "ins_Departments",
                newName: "instructorId");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "ins_Departments",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ins_Departments_Dept_ID",
                table: "ins_Departments",
                newName: "IX_ins_Departments_instructorId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ins_Departments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ins_Departments",
                table: "ins_Departments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ins_Departments_departmentId",
                table: "ins_Departments",
                column: "departmentId");

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
        }
    }
}
