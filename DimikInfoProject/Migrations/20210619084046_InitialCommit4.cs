using Microsoft.EntityFrameworkCore.Migrations;

namespace DimikInfoProject.Migrations
{
    public partial class InitialCommit4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns",
                column: "StudentId");
        }
    }
}
