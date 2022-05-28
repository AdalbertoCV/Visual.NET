using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDWEB.Data.Migrations
{
    public partial class creacionCerveza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cervezas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEstilo = table.Column<int>(type: "int", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cervezas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cervezas_Estilos_IdEstilo",
                        column: x => x.IdEstilo,
                        principalTable: "Estilos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cervezas_IdEstilo",
                table: "Cervezas",
                column: "IdEstilo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cervezas");
        }
    }
}
