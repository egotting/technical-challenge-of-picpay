using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace technical_challenge_of_picpay.Migrations
{
    /// <inheritdoc />
    public partial class AddLogistaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Chave",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Cpf_Cnpj",
                table: "Usuarios",
                newName: "Cpf");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Cpf_Cnpj",
                table: "Usuarios",
                newName: "IX_Usuarios_Cpf");

            migrationBuilder.CreateTable(
                name: "Logistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Cnpj = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    Saldo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logistas_Cnpj",
                table: "Logistas",
                column: "Cnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logistas_Email",
                table: "Logistas",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logistas");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Usuarios",
                newName: "Cpf_Cnpj");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Cpf",
                table: "Usuarios",
                newName: "IX_Usuarios_Cpf_Cnpj");

            migrationBuilder.AddColumn<Guid>(
                name: "Chave",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PId",
                table: "Usuarios",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PId",
                table: "Usuarios",
                column: "PId",
                unique: true);
        }
    }
}
