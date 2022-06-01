using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen3.Data.Migrations
{
    public partial class enviarModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Postre",
                table: "Postre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platillo",
                table: "Platillo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bebida",
                table: "Bebida");

            migrationBuilder.RenameTable(
                name: "Postre",
                newName: "Postres");

            migrationBuilder.RenameTable(
                name: "Platillo",
                newName: "Platillos");

            migrationBuilder.RenameTable(
                name: "Bebida",
                newName: "Bebidas");

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Postres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Platillos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Bebidas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postres",
                table: "Postres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platillos",
                table: "Platillos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bebidas",
                table: "Bebidas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Postres",
                table: "Postres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platillos",
                table: "Platillos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bebidas",
                table: "Bebidas");

            migrationBuilder.RenameTable(
                name: "Postres",
                newName: "Postre");

            migrationBuilder.RenameTable(
                name: "Platillos",
                newName: "Platillo");

            migrationBuilder.RenameTable(
                name: "Bebidas",
                newName: "Bebida");

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Postre",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Platillo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Bebida",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postre",
                table: "Postre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platillo",
                table: "Platillo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bebida",
                table: "Bebida",
                column: "Id");
        }
    }
}
