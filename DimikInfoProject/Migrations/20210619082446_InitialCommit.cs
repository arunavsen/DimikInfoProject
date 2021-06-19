using Microsoft.EntityFrameworkCore.Migrations;

namespace DimikInfoProject.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseAssignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseAssignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseAssigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAssigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseAssigns_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAssigns_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_CourseId",
                table: "CourseAssigns",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssigns_StudentId",
                table: "CourseAssigns",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseAssignId",
                table: "Courses",
                column: "CourseAssignId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseAssignId",
                table: "Students",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssigns_Courses_CourseId",
                table: "CourseAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssigns_Students_StudentId",
                table: "CourseAssigns");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "CourseAssigns");
        }
    }
}
