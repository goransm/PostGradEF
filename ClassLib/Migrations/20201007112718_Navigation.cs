using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLib.Migrations
{
    public partial class Navigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfessorId",
                table: "Students",
                column: "ProfessorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Professors_ProfessorId",
                table: "Students",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Professors_ProfessorId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProfessorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Students");
        }
    }
}
