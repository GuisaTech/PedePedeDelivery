using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPD.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntidadeArquivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arquivos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoUpload = table.Column<int>(type: "int", nullable: false),
                    TipoArquivo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Base64 = table.Column<string>(type: "varchar(100)", nullable: false),
                    Privado = table.Column<bool>(type: "bit", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removido = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arquivos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arquivos_UsuarioId",
                table: "Arquivos",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivos");
        }
    }
}
