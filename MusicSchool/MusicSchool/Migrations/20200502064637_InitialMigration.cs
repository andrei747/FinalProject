using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicSchool.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    ShortDescription = table.Column<string>(maxLength: 350, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "ImageUrl", "LastName", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Alexandra", "~/images/dariescu.jpg", "Dariescu", "Alexandra Dariescu este o pianistă solo de origine română." },
                    { 2, "Alexandru", "~/images/tomescu.jpg", "Tomescu", "Alexandru Tomescu (n. 15 septembrie 1976, București, România) este un violonist român," },
                    { 3, "Carlos", "~/images/santana.jpg", "Santana", " Carlos Santana născut la 20 iulie 1947 este un chitarist mexican și american. " },
                    { 4, "Irina", "~/images/rimes.jpg", "Rimes", "Irina Rimes este o cântăreață și compozitoare din Republica Moldova " }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "TeacherId" },
                values: new object[,]
                {
                    { 1, "PianoCourses", 1 },
                    { 2, "ViolinCourses", 2 },
                    { 3, "GuitarCourses", 3 },
                    { 4, "Canto", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
