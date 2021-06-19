using Microsoft.EntityFrameworkCore.Migrations;

namespace DimikInfoProject.Migrations
{
    public partial class InitialCommit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns",
                column: "CourseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns",
                column: "CourseId");
        }
    }
}
