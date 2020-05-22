using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicSchool.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    ShortDescription = table.Column<string>(nullable: false),
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
                    Teachers = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_Teachers",
                        column: x => x.Teachers,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "Teachers" },
                values: new object[,]
                {
                    { 1, "PianoCourses", null },
                    { 2, "ViolinCourses", null },
                    { 3, "GuitarCourses", null },
                    { 4, "Canto", null }
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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Teachers",
                table: "Courses",
                column: "Teachers",
                unique: true,
                filter: "[Teachers] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
