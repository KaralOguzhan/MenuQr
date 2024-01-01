using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrMenuAdonis.DataAccessLayer.Migrations
{
    public partial class mig_add_typeofmenuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "typeOfMenus",
                columns: table => new
                {
                    TypeOfMenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfMenus", x => x.TypeOfMenuID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "typeOfMenus");
        }
    }
}
