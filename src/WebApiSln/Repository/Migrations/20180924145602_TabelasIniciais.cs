using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class TabelasIniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigo",
                columns: table => new
                {
                    AmigoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    DDD = table.Column<string>(maxLength: 3, nullable: false),
                    Telefone = table.Column<string>(maxLength: 9, nullable: false),
                    Whats = table.Column<bool>(nullable: false),
                    CEP = table.Column<string>(maxLength: 8, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 200, nullable: false),
                    Bairro = table.Column<string>(maxLength: 30, nullable: false),
                    Localidade = table.Column<string>(maxLength: 30, nullable: false),
                    UF = table.Column<string>(maxLength: 3, nullable: false),
                    Observacao = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigo", x => x.AmigoId);
                });

            migrationBuilder.CreateTable(
                name: "FabricanteJogos",
                columns: table => new
                {
                    FabricanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 20, nullable: false),
                    ImagemLogo = table.Column<string>(maxLength: 200, nullable: false),
                    TipoFabricante = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricanteJogos", x => x.FabricanteId);
                });

            migrationBuilder.CreateTable(
                name: "Console",
                columns: table => new
                {
                    ConsoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    FabricanteId = table.Column<int>(nullable: false),
                    Modelo = table.Column<string>(maxLength: 100, nullable: false),
                    Energia = table.Column<string>(maxLength: 6, nullable: false),
                    QtdControles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Console", x => x.ConsoleId);
                    table.ForeignKey(
                        name: "FK_Console_FabricanteJogos_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "FabricanteJogos",
                        principalColumn: "FabricanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    JogoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsoleId = table.Column<int>(nullable: false),
                    GeneroId = table.Column<int>(nullable: false),
                    FabricanteId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    NumJogadores = table.Column<int>(nullable: false),
                    ClassificacaoEtaria = table.Column<string>(maxLength: 8, nullable: false),
                    LinkVideo = table.Column<string>(maxLength: 8, nullable: false),
                    Idioma = table.Column<string>(maxLength: 3, nullable: false),
                    Observacao = table.Column<string>(maxLength: 8000, nullable: false),
                    Foto = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogo_Console_ConsoleId",
                        column: x => x.ConsoleId,
                        principalTable: "Console",
                        principalColumn: "ConsoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogo_FabricanteJogos_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "FabricanteJogos",
                        principalColumn: "FabricanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    EmprestimoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JogoId = table.Column<int>(nullable: false),
                    AmigoId = table.Column<int>(nullable: false),
                    DtEmprestimo = table.Column<DateTime>(nullable: false),
                    DtDevolucao = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => x.EmprestimoId);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Amigo_AmigoId",
                        column: x => x.AmigoId,
                        principalTable: "Amigo",
                        principalColumn: "AmigoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogo",
                        principalColumn: "JogoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Console_FabricanteId",
                table: "Console",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_AmigoId",
                table: "Emprestimo",
                column: "AmigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_JogoId",
                table: "Emprestimo",
                column: "JogoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_ConsoleId",
                table: "Jogo",
                column: "ConsoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_FabricanteId",
                table: "Jogo",
                column: "FabricanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimo");

            migrationBuilder.DropTable(
                name: "Amigo");

            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Console");

            migrationBuilder.DropTable(
                name: "FabricanteJogos");
        }
    }
}
