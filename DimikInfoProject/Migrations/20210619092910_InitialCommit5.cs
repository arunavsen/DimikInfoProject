using Microsoft.EntityFrameworkCore.Migrations;

namespace DimikInfoProject.Migrations
{
    public partial class InitialCommit5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns");

            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns");

            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns",
                column: "StudentId",
                unique: true);
        }
    }
}
