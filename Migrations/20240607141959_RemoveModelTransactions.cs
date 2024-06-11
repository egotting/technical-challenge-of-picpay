using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace technical_challenge_of_picpay.Migrations
{
    /// <inheritdoc />
    public partial class RemoveModelTransactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailDoRecebedorLogista = table.Column<string>(type: "text", nullable: false),
                    EmailDoRecebedorUsuario = table.Column<string>(type: "text", nullable: false),
                    EmailDoRemetente = table.Column<string>(type: "text", nullable: false),
                    HoraDoEnvio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    QuantiaTransferida = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                });
        }
    }
}
