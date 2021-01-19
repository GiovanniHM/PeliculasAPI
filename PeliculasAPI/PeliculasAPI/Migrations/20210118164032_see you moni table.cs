using Microsoft.EntityFrameworkCore.Migrations;

namespace PeliculasAPI.Migrations
{
    public partial class seeyoumonitable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genero",
                table: "Genero");

            migrationBuilder.RenameTable(
                name: "Genero",
                newName: "Generos");

            migrationBuilder.RenameColumn(
                name: "foto",
                table: "Actores",
                newName: "Foto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Actores",
                newName: "foto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genero",
                table: "Genero",
                column: "Id");
        }
    }
}
