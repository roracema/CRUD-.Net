using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _05Fiap.Web.AspNet.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ANIMAL",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Carnivoro = table.Column<bool>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ANIMAL", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "TB_ZOO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Jaulas = table.Column<int>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    EntidadeAdministradora = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ZOO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ANIMAL");

            migrationBuilder.DropTable(
                name: "TB_ZOO");
        }
    }
}
