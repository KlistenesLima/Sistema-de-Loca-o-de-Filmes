using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaLocacao.Migrations
{
    public partial class AtualizacaoModelFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Lancamento",
                table: "Filmes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Lancamento",
                table: "Filmes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
