using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrMenuAdonis.DataAccessLayer.Migrations
{
    public partial class mig_first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryNameTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryNameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    ProductGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupNameTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroupNameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ProductGroupDescriptionTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroupDescriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroupImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroupStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.ProductGroupID);
                    table.ForeignKey(
                        name: "FK_ProductGroups_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNameTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductNameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescriptionTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescriptionEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    ProductImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupID",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ProductGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_CategoryID",
                table: "ProductGroups",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupID",
                table: "Products",
                column: "ProductGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
