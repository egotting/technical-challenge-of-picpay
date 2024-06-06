using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technical_challenge_of_picpay.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTransactionInOthersThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDoRemetente",
                table: "Transacoes",
                newName: "EmailDoRemetente");

            migrationBuilder.RenameColumn(
                name: "NomeDoRecebedor",
                table: "Transacoes",
                newName: "EmailDoRecebedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailDoRemetente",
                table: "Transacoes",
                newName: "NomeDoRemetente");

            migrationBuilder.RenameColumn(
                name: "EmailDoRecebedor",
                table: "Transacoes",
                newName: "NomeDoRecebedor");
        }
    }
}
