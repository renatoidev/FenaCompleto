using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Reestruturacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analistas_Gerentes_SupervisorId",
                table: "Analistas");

            migrationBuilder.AlterColumn<Guid>(
                name: "SupervisorId",
                table: "Analistas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Analistas_Gerentes_SupervisorId",
                table: "Analistas",
                column: "SupervisorId",
                principalTable: "Gerentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analistas_Gerentes_SupervisorId",
                table: "Analistas");

            migrationBuilder.AlterColumn<Guid>(
                name: "SupervisorId",
                table: "Analistas",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Analistas_Gerentes_SupervisorId",
                table: "Analistas",
                column: "SupervisorId",
                principalTable: "Gerentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
