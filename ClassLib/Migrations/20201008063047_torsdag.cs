using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLib.Migrations
{
    public partial class torsdag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Professors_ProfessorId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProfessorId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfessorId",
                table: "Students",
                column: "ProfessorId",
                unique: true,
                filter: "[ProfessorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Professors_ProfessorId",
                table: "Students",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Professors_ProfessorId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProfessorId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
