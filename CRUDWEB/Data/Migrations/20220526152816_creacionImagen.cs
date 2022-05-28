using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDWEB.Data.Migrations
{
    public partial class creacionImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Cervezas",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "URLImagen",
                table: "Cervezas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URLImagen",
                table: "Cervezas");

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Cervezas",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
