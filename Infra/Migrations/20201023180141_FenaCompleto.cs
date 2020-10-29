using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class FenaCompleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gerentes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome_Gerente = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cargo_Gerente = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Analistas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome_Analista = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cargo_Analista = table.Column<string>(type: "varchar(15)", nullable: false),
                    SupervisorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analistas_Gerentes_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Gerentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estagiarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome_Estagiario = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cargo_Estagiario = table.Column<string>(type: "varchar(15)", nullable: false),
                    SupervisorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estagiarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estagiarios_Analistas_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Analistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome_Tecnico = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cargo_Tecnico = table.Column<string>(type: "varchar(15)", nullable: false),
                    SupervisorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnicos_Analistas_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Analistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analistas_SupervisorId",
                table: "Analistas",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Estagiarios_SupervisorId",
                table: "Estagiarios",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_SupervisorId",
                table: "Tecnicos",
                column: "SupervisorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estagiarios");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Analistas");

            migrationBuilder.DropTable(
                name: "Gerentes");
        }
    }
}
