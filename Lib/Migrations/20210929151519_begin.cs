using Microsoft.EntityFrameworkCore.Migrations;

namespace Lib.Migrations
{
    public partial class begin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckingAccounts_Bank_BankId",
                table: "CheckingAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CheckingAccounts_BankId",
                table: "CheckingAccounts");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "CheckingAccounts");

            migrationBuilder.AddColumn<string>(
                name: "Log",
                table: "Bank",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Log",
                table: "Bank");

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "CheckingAccounts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckingAccounts_BankId",
                table: "CheckingAccounts",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckingAccounts_Bank_BankId",
                table: "CheckingAccounts",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
