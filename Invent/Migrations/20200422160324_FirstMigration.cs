using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invent.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shopkeeper",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    ProductPrice = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopkeeper", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Shopkeeper",
                columns: new[] { "ProductId", "Date", "ProductName", "ProductPrice", "Quantity", "amount" },
                values: new object[] { 1, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Usha Celling Fan", 550, 10, 5500 });

            migrationBuilder.InsertData(
                table: "Shopkeeper",
                columns: new[] { "ProductId", "Date", "ProductName", "ProductPrice", "Quantity", "amount" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Usha Mixer Grinder", 800, 10, 8000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopkeeper");
        }
    }
}
