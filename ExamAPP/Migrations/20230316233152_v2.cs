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
            migrationBuilder.CreateTable(
                name: "Stude_Answers",
                columns: table => new
                {
                    Stud_id = table.Column<int>(type: "int", nullable: false),
                    Ex_id = table.Column<int>(type: "int", nullable: false),
                    Q_id = table.Column<int>(type: "int", nullable: false),
                    ch_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stude_Answers", x => new { x.Ex_id, x.Q_id, x.Stud_id });
                    table.ForeignKey(
                        name: "FK_Stude_Answers_Choices_ch_id",
                        column: x => x.ch_id,
                        principalTable: "Choices",
                        principalColumn: "Ch_Id");
                    table.ForeignKey(
                        name: "FK_Stude_Answers_Exams_Ex_id",
                        column: x => x.Ex_id,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id");
                    table.ForeignKey(
                        name: "FK_Stude_Answers_Questions_Q_id",
                        column: x => x.Q_id,
                        principalTable: "Questions",
                        principalColumn: "Q_Id");
                    table.ForeignKey(
                        name: "FK_Stude_Answers_students_Stud_id",
                        column: x => x.Stud_id,
                        principalTable: "students",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stude_Answers_ch_id",
                table: "Stude_Answers",
                column: "ch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stude_Answers_Q_id",
                table: "Stude_Answers",
                column: "Q_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stude_Answers_Stud_id",
                table: "Stude_Answers",
                column: "Stud_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stude_Answers");
        }
    }
}
