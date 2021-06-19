using Microsoft.EntityFrameworkCore.Migrations;

namespace DimikInfoProject.Migrations
{
    public partial class InitialCommit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseAssigns_CourseAssignId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_CourseAssigns_CourseAssignId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseAssignId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseAssignId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseAssignId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseAssignId",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseAssignId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseAssignId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseAssignId",
                table: "Students",
                column: "CourseAssignId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseAssignId",
                table: "Courses",
                column: "CourseAssignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseAssigns_CourseAssignId",
                table: "Courses",
                column: "CourseAssignId",
                principalTable: "CourseAssigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CourseAssigns_CourseAssignId",
                table: "Students",
                column: "CourseAssignId",
                principalTable: "CourseAssigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
