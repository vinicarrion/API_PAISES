using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace API_PAISES.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    Capital = table.Column<string>(type: "text", nullable: false),
                    Moeda = table.Column<string>(type: "text", nullable: false),
                    Populacao = table.Column<double>(type: "double", nullable: false),
                    Continente = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paises");
        }
    }
}
