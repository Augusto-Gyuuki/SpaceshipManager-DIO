using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceshipManager.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "espaco_naves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modelo = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passageiros = table.Column<int>(type: "int", nullable: false),
                    carga = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    classe = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_espaco_naves", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "planetas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rotacao = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    orbita = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    diametro = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    clima = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    populacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planetas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pilotos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    planeta = table.Column<int>(type: "int", nullable: false),
                    ano_nascimento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pilotos", x => x.id);
                    table.ForeignKey(
                        name: "FK_pilotos_planetas_planeta",
                        column: x => x.planeta,
                        principalTable: "planetas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "espaco_nave_piloto",
                columns: table => new
                {
                    piloto = table.Column<int>(type: "int", nullable: false),
                    espaco_nave = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_espaco_nave_piloto", x => new { x.piloto, x.espaco_nave });
                    table.ForeignKey(
                        name: "FK_espaco_nave_piloto_espaco_naves_espaco_nave",
                        column: x => x.espaco_nave,
                        principalTable: "espaco_naves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_espaco_nave_piloto_pilotos_piloto",
                        column: x => x.piloto,
                        principalTable: "pilotos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_espaco_nave_piloto_espaco_nave",
                table: "espaco_nave_piloto",
                column: "espaco_nave");

            migrationBuilder.CreateIndex(
                name: "IX_espaco_naves_nome",
                table: "espaco_naves",
                column: "nome")
                .Annotation("MySql:IndexPrefixLength", new[] { 4 });

            migrationBuilder.CreateIndex(
                name: "IX_pilotos_nome",
                table: "pilotos",
                column: "nome")
                .Annotation("MySql:IndexPrefixLength", new[] { 4 });

            migrationBuilder.CreateIndex(
                name: "IX_pilotos_planeta",
                table: "pilotos",
                column: "planeta");

            migrationBuilder.CreateIndex(
                name: "IX_planetas_nome",
                table: "planetas",
                column: "nome")
                .Annotation("MySql:IndexPrefixLength", new[] { 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "espaco_nave_piloto");

            migrationBuilder.DropTable(
                name: "espaco_naves");

            migrationBuilder.DropTable(
                name: "pilotos");

            migrationBuilder.DropTable(
                name: "planetas");
        }
    }
}
