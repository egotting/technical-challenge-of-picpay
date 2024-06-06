using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technical_challenge_of_picpay.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTransactionInOthersThingss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailDoRecebedor",
                table: "Transacoes",
                newName: "EmailDoRecebedorUsuario");

            migrationBuilder.AddColumn<string>(
                name: "EmailDoRecebedorLogista",
                table: "Transacoes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailDoRecebedorLogista",
                table: "Transacoes");

            migrationBuilder.RenameColumn(
                name: "EmailDoRecebedorUsuario",
                table: "Transacoes",
                newName: "EmailDoRecebedor");
        }
    }
}
