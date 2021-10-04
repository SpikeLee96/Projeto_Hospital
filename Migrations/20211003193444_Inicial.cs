using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_CRUD.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoExame",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoExame", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Exame",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeExame = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    observacoes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TipoExameId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exame", x => x.id);
                    table.ForeignKey(
                        name: "FK_Exame_TipoExame_TipoExameId",
                        column: x => x.TipoExameId,
                        principalTable: "TipoExame",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExameId = table.Column<long>(type: "bigint", nullable: false),
                    PacienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Consulta_Exame_ExameId",
                        column: x => x.ExameId,
                        principalTable: "Exame",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ExameId",
                table: "Consulta",
                column: "ExameId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Exame_TipoExameId",
                table: "Exame",
                column: "TipoExameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Exame");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "TipoExame");
        }
    }
}
