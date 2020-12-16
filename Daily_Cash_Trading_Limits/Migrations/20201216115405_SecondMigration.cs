using Microsoft.EntityFrameworkCore.Migrations;

namespace Daily_Cash_Trading_Limits.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RiskRating",
                table: "RiskRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyCalculatedLimit",
                table: "DailyCalculatedLimit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankName",
                table: "BankName");

            migrationBuilder.RenameTable(
                name: "RiskRating",
                newName: "RiskRatings");

            migrationBuilder.RenameTable(
                name: "DailyCalculatedLimit",
                newName: "DailyCalculatedLimits");

            migrationBuilder.RenameTable(
                name: "BankName",
                newName: "BankNames");

            migrationBuilder.RenameColumn(
                name: "Limit",
                table: "DailyCalculatedLimits",
                newName: "BaseLimit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiskRatings",
                table: "RiskRatings",
                column: "Rating");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyCalculatedLimits",
                table: "DailyCalculatedLimits",
                column: "BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankNames",
                table: "BankNames",
                column: "BankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RiskRatings",
                table: "RiskRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyCalculatedLimits",
                table: "DailyCalculatedLimits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankNames",
                table: "BankNames");

            migrationBuilder.RenameTable(
                name: "RiskRatings",
                newName: "RiskRating");

            migrationBuilder.RenameTable(
                name: "DailyCalculatedLimits",
                newName: "DailyCalculatedLimit");

            migrationBuilder.RenameTable(
                name: "BankNames",
                newName: "BankName");

            migrationBuilder.RenameColumn(
                name: "BaseLimit",
                table: "DailyCalculatedLimit",
                newName: "Limit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiskRating",
                table: "RiskRating",
                column: "Rating");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyCalculatedLimit",
                table: "DailyCalculatedLimit",
                column: "BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankName",
                table: "BankName",
                column: "BankId");
        }
    }
}
