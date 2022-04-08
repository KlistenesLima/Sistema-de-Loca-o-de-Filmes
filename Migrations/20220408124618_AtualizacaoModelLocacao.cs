using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaLocacao.Migrations
{
    public partial class AtualizacaoModelLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Filme",
                table: "Locacoes");

            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente",
                table: "Locacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Filme",
                table: "Locacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Id_Filme",
                table: "Locacoes");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Locacoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Filme",
                table: "Locacoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
