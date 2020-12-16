using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Daily_Cash_Trading_Limits.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankName",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Approved = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankName", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "DailyCalculatedLimit",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Limit = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyCalculatedLimit", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "RiskRating",
                columns: table => new
                {
                    Rating = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EffectOnLimit = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskRating", x => x.Rating);
                });

            migrationBuilder.CreateTable(
                name: "TotalAssets",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BankName = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Assets = table.Column<long>(type: "INTEGER", nullable: false),
                    DateApplied = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalAssets", x => x.BankId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankName");

            migrationBuilder.DropTable(
                name: "DailyCalculatedLimit");

            migrationBuilder.DropTable(
                name: "RiskRating");

            migrationBuilder.DropTable(
                name: "TotalAssets");
        }
    }
}
