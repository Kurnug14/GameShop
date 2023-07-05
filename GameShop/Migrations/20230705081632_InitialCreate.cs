using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFGetStarted.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PlayerNumbers = table.Column<int>(type: "int", nullable: false),
                    StorageNumber = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                    table.ForeignKey(
                        name: "FK_Products_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "GameTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerProducts",
                columns: table => new
                {
                    ManufacturerProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerProducts", x => x.ManufacturerProductsId);
                    table.ForeignKey(
                        name: "FK_ManufacturerProducts_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerProducts_ManufacturerId",
                table: "ManufacturerProducts",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerProducts_ProductsId",
                table: "ManufacturerProducts",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GameTypeId",
                table: "Products",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StateId",
                table: "Products",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManufacturerProducts");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
