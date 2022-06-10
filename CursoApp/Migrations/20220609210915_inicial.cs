using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoApp.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoHoras = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoProfesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreProfesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Profesores");
        }
    }
}
